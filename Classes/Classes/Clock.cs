using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;


namespace Classes.Classes
{
    public class Clock 
    {
        private Timer _timer;

        private string _theTime;
        public string TheTime
        {
            get
            {
                return _theTime;
            }
            set
            {
                _theTime = value;
                OnLabelChange(_theTime);
            }
        }

        public delegate void TimerElapsedHandler(string newTime);
        public event TimerElapsedHandler LabelChanged;
        
        /// <summary>
        /// Handles the function for the timer so the digital clock increase every second 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var hrs = Hour.GetHour();
            var min = Minutes.Tick(Minutes.GetMinute());
            TheTime = GetClockTime(hrs, min);
            if (min == 59)
                hrs = Hour.Tick(Hour.GetHour());

        }

        /// <summary>
        /// Trigger the event
        /// </summary>
        /// <param name="newTime"></param>
        protected void OnLabelChange(string newTime)
        {
            LabelChanged?.Invoke(newTime);
        }

        /// <summary>
        /// Return a formatted string of the time
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public string GetClockTime(int hours, int min )
        {
            return $"{hours:00}:{min:00}";
        }

        /// <summary>
        /// sets of the timer so the clock starts ticking
        /// </summary>
        public void StartClock()
        {
            _timer = new Timer();
            _timer.Elapsed += Timer_Elapsed;
            _timer.Interval = 1000;
            _timer.Start();
        }

        /// <summary>
        /// Stops timer
        /// </summary>
        public void StopClock()
        {
            _timer.Stop();
        }

        

        
    }
}
