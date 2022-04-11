using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.Threading;
using System.Timers;
using System.Windows.Forms.VisualStyles;
using Classes.Classes;
using Type = Classes.Classes.Type;




namespace Labb1Egen
{
    
    public partial class FormAlarm : Form
    {
        private Hour clockHour;
        private Minutes clockMins;
        private Alarm alarmOne;
        private Alarm alarmTwo;
        private Clock c = new Clock();

        public FormAlarm()
        {
            InitializeComponent();

            //Ties the method to event
            c.LabelChanged += new Clock.TimerElapsedHandler(OnPrintTimeToTimerLabel);
        }

        
        /// <summary>
        /// Update the time label every second
        /// </summary>
        /// <param name="newTime">the actual time every second second</param>
        protected void OnPrintTimeToTimerLabel(string newTime)
        {
            lblTimer.Invoke((MethodInvoker)(() => lblTimer.Text = newTime));
        }

        /// <summary>
        /// Check when the clock time is equal to alarm time one
        /// </summary>
        /// <param name="newTime">the actual time every second second</param>
        protected void OnCheckWhenAlarmOneGoesOf(string newTime)
        {
            if (newTime == alarmOne.GetAlarmTime())
                ThreadPool.QueueUserWorkItem(AlarmOneGoesOf);
        }

        /// <summary>
        /// Check when the clock time is equal to alarm time one
        /// </summary>
        /// <param name="newTime">the actual time every second second</param>
        private void OnCheckWhenAlarmTwoGoesOf(string newTime)
        {
            if (newTime == alarmTwo.GetAlarmTime())
                ThreadPool.QueueUserWorkItem(AlarmTwoGoesOf);
        }

        /// <summary>
        /// calls when the two timestamps matches
        /// </summary>
        /// <param name="stateInfo"></param>
        private void AlarmOneGoesOf(object stateInfo)
        {
            SoundPlayer play = new SoundPlayer("alarmOne.wav");
            play.PlayLooping();

            var count = 0;
            while (count < 20)
            {
                
                GbIndicateLarm1.Invoke((MethodInvoker)(() => GbIndicateLarm1.BackColor = Color.White));
                //tabAlarmOne.BackColor = Color.White;
                Thread.Sleep(250);
                GbIndicateLarm1.Invoke((MethodInvoker)(() => GbIndicateLarm1.BackColor = Color.Black));
                Thread.Sleep(250);
                count++;
            }
            Invoke((MethodInvoker) (() =>
            {
                GbIndicateLarm1.BackColor = Color.Black;
                btnSetAlarmOne.Text = "SET";
                txtAlarmOneHrs.Enabled = true;
                txtAlarmOneMins.Enabled = true;
            }));
            play.Stop();
        }

        /// <summary>
        /// calls when the two timestamps matches
        /// </summary>
        /// <param name="stateInfo"></param>
        private void AlarmTwoGoesOf(object stateInfo)
        {
            SoundPlayer play = new SoundPlayer("alarmTwo.wav");
            play.PlayLooping();

            //var ti = new Thread(new ThreadStart(PlaySoundForAlarm2));
            //ti.Start();

            var count = 0;
            while (count < 20)
            {
                GbIndicateLarm2.Invoke((MethodInvoker)(() => GbIndicateLarm2.BackColor = Color.White));
                Thread.Sleep(250);
                GbIndicateLarm2.Invoke((MethodInvoker)(() => GbIndicateLarm2.BackColor = Color.Black));
                Thread.Sleep(250);
                count++;
            }
            Invoke((MethodInvoker)(() =>
            {
                GbIndicateLarm2.BackColor = Color.Black;
                btnSetAlarmTwo.Text = "SET";
                txtAlarmTwoHrs.Enabled = true;
                txtAlarmTwoMins.Enabled = true;
            }));
            play.Stop();
            
        }

        /// <summary>
        /// executes everything inside the event every time the start button been clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "START")
            {
                c.LabelChanged += new Clock.TimerElapsedHandler(OnPrintTimeToTimerLabel);
                CheckIfInputIsValid(Type.Clock, txtClockSetHrs.Text, txtClockSetMins.Text);
                
            }
                

            else
            {
                c.StopClock();
                txtClockSetHrs.Enabled = true;
                txtClockSetMins.Enabled = true;
                btnStartStop.Text = "START";
                lblTimer.Text = $"{Hour.HourStart:00}:{Minutes.MinuteStart:00}";
                c.LabelChanged -= new Clock.TimerElapsedHandler(OnPrintTimeToTimerLabel);

            }
        }

        /// <summary>
        /// executes everything inside the event every time the set button for alarm1 been clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSetAlarmOne_Click(object sender, EventArgs e)
        {
            if (btnSetAlarmOne.Text == "SET")
                CheckIfInputIsValid(Type.AlarmOne, txtAlarmOneHrs.Text, txtAlarmOneMins.Text);
            else
            {
                btnSetAlarmOne.Text = "SET";
                txtAlarmOneHrs.Enabled = true;
                txtAlarmOneMins.Enabled = true;
            }

        }

        /// <summary>
        /// executes everything inside the event every time the set button for alarm2 been clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSetAlarmTwo_Click(object sender, EventArgs e)
        {
            if (btnSetAlarmTwo.Text == "SET")
                CheckIfInputIsValid(Type.AlarmTwo, txtAlarmTwoHrs.Text, txtAlarmTwoMins.Text);
            else
            {
                btnSetAlarmTwo.Text = "SET";
                txtAlarmTwoHrs.Enabled = true;
                txtAlarmTwoMins.Enabled = true;
            }
        }

        /// <summary>
        /// Check if the input is in valid state en creates new instance of the chosen class  
        /// </summary>
        /// <param name="type">type of class</param>
        /// <param name="hrs">hour input</param>
        /// <param name="mins">minute input</param>
        private void CheckIfInputIsValid(Type type, string hrs, string mins)
        {
            int hour;
            int minute;
            try
            {
                hour = int.Parse(hrs);
                minute = int.Parse(mins);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message + "\n" +
                                "Please enter valid numbers of type integer.");
                return;
            }

            if (hour > 23 || minute > 59)
                MessageBox.Show("Please enter valid numbers!\nHour 0-23\nMinutes 0-59");
            else
            {
                if (type == Type.Clock)
                {
                    clockHour = new Hour(hour);
                    clockMins = new Minutes(minute);
                    WireUpBtn(Type.Clock);

                }
                else if (type == Type.AlarmOne)
                {
                    alarmOne = new Alarm(hour, minute);
                    WireUpBtn(Type.AlarmOne);
                }
                else
                {
                    alarmTwo = new Alarm(hour, minute);
                    WireUpBtn(Type.AlarmTwo);
                }
            }

        }

        /// <summary>
        /// Wire upp the chosen button with correct data
        /// </summary>
        /// <param name="type"></param>
        private void WireUpBtn(Type type)
        {
            if (type == Type.Clock)
            {
                lblTimer.Text = c.GetClockTime(Hour.GetHour(), Minutes.GetMinute());

                c.StartClock();
                txtClockSetHrs.Enabled = false;
                txtClockSetMins.Enabled = false;
                btnStartStop.Text = "STOP"; 
            }
            else if (type == Type.AlarmOne)
            {
                c.LabelChanged += new Clock.TimerElapsedHandler(OnCheckWhenAlarmOneGoesOf);

                btnSetAlarmOne.Text = "UNSET";
                txtAlarmOneHrs.Enabled = false;
                txtAlarmOneMins.Enabled = false;
            }
            else
            {
                c.LabelChanged += new Clock.TimerElapsedHandler(OnCheckWhenAlarmTwoGoesOf);

                btnSetAlarmTwo.Text = "UNSET";
                txtAlarmTwoHrs.Enabled = false;
                txtAlarmTwoMins.Enabled = false;
            }
        }

        
    }
}
