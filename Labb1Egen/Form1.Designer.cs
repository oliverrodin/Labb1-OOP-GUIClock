
namespace Labb1Egen
{
    partial class FormAlarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GBoxClock = new System.Windows.Forms.GroupBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtClockSetMins = new System.Windows.Forms.TextBox();
            this.txtClockSetHrs = new System.Windows.Forms.TextBox();
            this.lblClockSetMins = new System.Windows.Forms.Label();
            this.lblClockSetHour = new System.Windows.Forms.Label();
            this.tabAlarm = new System.Windows.Forms.TabControl();
            this.tabAlarmOne = new System.Windows.Forms.TabPage();
            this.btnSetAlarmOne = new System.Windows.Forms.Button();
            this.lblAlarmOneHrs = new System.Windows.Forms.Label();
            this.txtAlarmOneMins = new System.Windows.Forms.TextBox();
            this.lblAlarmOneMins = new System.Windows.Forms.Label();
            this.txtAlarmOneHrs = new System.Windows.Forms.TextBox();
            this.tabAlarmTwo = new System.Windows.Forms.TabPage();
            this.btnSetAlarmTwo = new System.Windows.Forms.Button();
            this.txtAlarmTwoMins = new System.Windows.Forms.TextBox();
            this.txtAlarmTwoHrs = new System.Windows.Forms.TextBox();
            this.lblAlarmTwoMins = new System.Windows.Forms.Label();
            this.lblAlarmTwoHrs = new System.Windows.Forms.Label();
            this.GbIndicateLarm1 = new System.Windows.Forms.GroupBox();
            this.GbIndicateLarm2 = new System.Windows.Forms.GroupBox();
            this.GBoxClock.SuspendLayout();
            this.tabAlarm.SuspendLayout();
            this.tabAlarmOne.SuspendLayout();
            this.tabAlarmTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxClock
            // 
            this.GBoxClock.BackColor = System.Drawing.Color.Black;
            this.GBoxClock.Controls.Add(this.btnStartStop);
            this.GBoxClock.Controls.Add(this.lblTimer);
            this.GBoxClock.Controls.Add(this.txtClockSetMins);
            this.GBoxClock.Controls.Add(this.txtClockSetHrs);
            this.GBoxClock.Controls.Add(this.lblClockSetMins);
            this.GBoxClock.Controls.Add(this.lblClockSetHour);
            this.GBoxClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GBoxClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GBoxClock.ForeColor = System.Drawing.Color.Red;
            this.GBoxClock.Location = new System.Drawing.Point(12, 12);
            this.GBoxClock.Name = "GBoxClock";
            this.GBoxClock.Size = new System.Drawing.Size(357, 235);
            this.GBoxClock.TabIndex = 0;
            this.GBoxClock.TabStop = false;
            this.GBoxClock.Text = "Clock";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(120, 173);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(100, 39);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.Text = "START";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.BtnStartStop_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Digital dream Fat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(88, 112);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(167, 38);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "00:00";
            // 
            // txtClockSetMins
            // 
            this.txtClockSetMins.BackColor = System.Drawing.Color.Gainsboro;
            this.txtClockSetMins.Location = new System.Drawing.Point(120, 73);
            this.txtClockSetMins.Name = "txtClockSetMins";
            this.txtClockSetMins.Size = new System.Drawing.Size(100, 20);
            this.txtClockSetMins.TabIndex = 3;
            // 
            // txtClockSetHrs
            // 
            this.txtClockSetHrs.BackColor = System.Drawing.Color.Gainsboro;
            this.txtClockSetHrs.Location = new System.Drawing.Point(120, 42);
            this.txtClockSetHrs.Multiline = true;
            this.txtClockSetHrs.Name = "txtClockSetHrs";
            this.txtClockSetHrs.Size = new System.Drawing.Size(100, 20);
            this.txtClockSetHrs.TabIndex = 2;
            // 
            // lblClockSetMins
            // 
            this.lblClockSetMins.AutoSize = true;
            this.lblClockSetMins.Location = new System.Drawing.Point(26, 76);
            this.lblClockSetMins.Name = "lblClockSetMins";
            this.lblClockSetMins.Size = new System.Drawing.Size(69, 13);
            this.lblClockSetMins.TabIndex = 1;
            this.lblClockSetMins.Text = "Set Minutes :";
            // 
            // lblClockSetHour
            // 
            this.lblClockSetHour.AutoSize = true;
            this.lblClockSetHour.ForeColor = System.Drawing.Color.Red;
            this.lblClockSetHour.Location = new System.Drawing.Point(35, 45);
            this.lblClockSetHour.Name = "lblClockSetHour";
            this.lblClockSetHour.Size = new System.Drawing.Size(63, 13);
            this.lblClockSetHour.TabIndex = 0;
            this.lblClockSetHour.Text = "Set Hours : ";
            // 
            // tabAlarm
            // 
            this.tabAlarm.Controls.Add(this.tabAlarmOne);
            this.tabAlarm.Controls.Add(this.tabAlarmTwo);
            this.tabAlarm.Location = new System.Drawing.Point(12, 253);
            this.tabAlarm.Name = "tabAlarm";
            this.tabAlarm.SelectedIndex = 0;
            this.tabAlarm.Size = new System.Drawing.Size(357, 209);
            this.tabAlarm.TabIndex = 5;
            // 
            // tabAlarmOne
            // 
            this.tabAlarmOne.BackColor = System.Drawing.Color.Black;
            this.tabAlarmOne.Controls.Add(this.btnSetAlarmOne);
            this.tabAlarmOne.Controls.Add(this.lblAlarmOneHrs);
            this.tabAlarmOne.Controls.Add(this.txtAlarmOneMins);
            this.tabAlarmOne.Controls.Add(this.lblAlarmOneMins);
            this.tabAlarmOne.Controls.Add(this.txtAlarmOneHrs);
            this.tabAlarmOne.ForeColor = System.Drawing.Color.Red;
            this.tabAlarmOne.Location = new System.Drawing.Point(4, 22);
            this.tabAlarmOne.Name = "tabAlarmOne";
            this.tabAlarmOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlarmOne.Size = new System.Drawing.Size(349, 183);
            this.tabAlarmOne.TabIndex = 0;
            this.tabAlarmOne.Text = "Alarm1";
            // 
            // btnSetAlarmOne
            // 
            this.btnSetAlarmOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarmOne.Location = new System.Drawing.Point(116, 116);
            this.btnSetAlarmOne.Name = "btnSetAlarmOne";
            this.btnSetAlarmOne.Size = new System.Drawing.Size(100, 39);
            this.btnSetAlarmOne.TabIndex = 4;
            this.btnSetAlarmOne.Text = "SET";
            this.btnSetAlarmOne.UseVisualStyleBackColor = true;
            this.btnSetAlarmOne.Click += new System.EventHandler(this.BtnSetAlarmOne_Click);
            // 
            // lblAlarmOneHrs
            // 
            this.lblAlarmOneHrs.AutoSize = true;
            this.lblAlarmOneHrs.Location = new System.Drawing.Point(22, 32);
            this.lblAlarmOneHrs.Name = "lblAlarmOneHrs";
            this.lblAlarmOneHrs.Size = new System.Drawing.Size(63, 13);
            this.lblAlarmOneHrs.TabIndex = 0;
            this.lblAlarmOneHrs.Text = "Set Hours : ";
            // 
            // txtAlarmOneMins
            // 
            this.txtAlarmOneMins.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAlarmOneMins.Location = new System.Drawing.Point(116, 64);
            this.txtAlarmOneMins.Name = "txtAlarmOneMins";
            this.txtAlarmOneMins.Size = new System.Drawing.Size(100, 20);
            this.txtAlarmOneMins.TabIndex = 3;
            // 
            // lblAlarmOneMins
            // 
            this.lblAlarmOneMins.AutoSize = true;
            this.lblAlarmOneMins.Location = new System.Drawing.Point(16, 64);
            this.lblAlarmOneMins.Name = "lblAlarmOneMins";
            this.lblAlarmOneMins.Size = new System.Drawing.Size(69, 13);
            this.lblAlarmOneMins.TabIndex = 1;
            this.lblAlarmOneMins.Text = "Set Minutes :";
            // 
            // txtAlarmOneHrs
            // 
            this.txtAlarmOneHrs.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAlarmOneHrs.Location = new System.Drawing.Point(116, 29);
            this.txtAlarmOneHrs.Name = "txtAlarmOneHrs";
            this.txtAlarmOneHrs.Size = new System.Drawing.Size(100, 20);
            this.txtAlarmOneHrs.TabIndex = 2;
            // 
            // tabAlarmTwo
            // 
            this.tabAlarmTwo.BackColor = System.Drawing.Color.Black;
            this.tabAlarmTwo.Controls.Add(this.btnSetAlarmTwo);
            this.tabAlarmTwo.Controls.Add(this.txtAlarmTwoMins);
            this.tabAlarmTwo.Controls.Add(this.txtAlarmTwoHrs);
            this.tabAlarmTwo.Controls.Add(this.lblAlarmTwoMins);
            this.tabAlarmTwo.Controls.Add(this.lblAlarmTwoHrs);
            this.tabAlarmTwo.ForeColor = System.Drawing.Color.Red;
            this.tabAlarmTwo.Location = new System.Drawing.Point(4, 22);
            this.tabAlarmTwo.Name = "tabAlarmTwo";
            this.tabAlarmTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlarmTwo.Size = new System.Drawing.Size(349, 183);
            this.tabAlarmTwo.TabIndex = 1;
            this.tabAlarmTwo.Text = "Alarm2";
            // 
            // btnSetAlarmTwo
            // 
            this.btnSetAlarmTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarmTwo.Location = new System.Drawing.Point(116, 114);
            this.btnSetAlarmTwo.Name = "btnSetAlarmTwo";
            this.btnSetAlarmTwo.Size = new System.Drawing.Size(100, 39);
            this.btnSetAlarmTwo.TabIndex = 5;
            this.btnSetAlarmTwo.Text = "SET";
            this.btnSetAlarmTwo.UseVisualStyleBackColor = true;
            this.btnSetAlarmTwo.Click += new System.EventHandler(this.BtnSetAlarmTwo_Click);
            // 
            // txtAlarmTwoMins
            // 
            this.txtAlarmTwoMins.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAlarmTwoMins.Location = new System.Drawing.Point(116, 64);
            this.txtAlarmTwoMins.Name = "txtAlarmTwoMins";
            this.txtAlarmTwoMins.Size = new System.Drawing.Size(100, 20);
            this.txtAlarmTwoMins.TabIndex = 4;
            // 
            // txtAlarmTwoHrs
            // 
            this.txtAlarmTwoHrs.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAlarmTwoHrs.Location = new System.Drawing.Point(116, 33);
            this.txtAlarmTwoHrs.Name = "txtAlarmTwoHrs";
            this.txtAlarmTwoHrs.Size = new System.Drawing.Size(100, 20);
            this.txtAlarmTwoHrs.TabIndex = 3;
            // 
            // lblAlarmTwoMins
            // 
            this.lblAlarmTwoMins.AutoSize = true;
            this.lblAlarmTwoMins.Location = new System.Drawing.Point(16, 67);
            this.lblAlarmTwoMins.Name = "lblAlarmTwoMins";
            this.lblAlarmTwoMins.Size = new System.Drawing.Size(69, 13);
            this.lblAlarmTwoMins.TabIndex = 2;
            this.lblAlarmTwoMins.Text = "Set Minutes :";
            // 
            // lblAlarmTwoHrs
            // 
            this.lblAlarmTwoHrs.AutoSize = true;
            this.lblAlarmTwoHrs.Location = new System.Drawing.Point(22, 36);
            this.lblAlarmTwoHrs.Name = "lblAlarmTwoHrs";
            this.lblAlarmTwoHrs.Size = new System.Drawing.Size(63, 13);
            this.lblAlarmTwoHrs.TabIndex = 1;
            this.lblAlarmTwoHrs.Text = "Set Hours : ";
            // 
            // GbIndicateLarm1
            // 
            this.GbIndicateLarm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbIndicateLarm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbIndicateLarm1.ForeColor = System.Drawing.Color.Red;
            this.GbIndicateLarm1.Location = new System.Drawing.Point(12, 468);
            this.GbIndicateLarm1.Name = "GbIndicateLarm1";
            this.GbIndicateLarm1.Size = new System.Drawing.Size(171, 61);
            this.GbIndicateLarm1.TabIndex = 6;
            this.GbIndicateLarm1.TabStop = false;
            this.GbIndicateLarm1.Text = "Larm 1";
            // 
            // GbIndicateLarm2
            // 
            this.GbIndicateLarm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbIndicateLarm2.ForeColor = System.Drawing.Color.Red;
            this.GbIndicateLarm2.Location = new System.Drawing.Point(198, 468);
            this.GbIndicateLarm2.Name = "GbIndicateLarm2";
            this.GbIndicateLarm2.Size = new System.Drawing.Size(171, 61);
            this.GbIndicateLarm2.TabIndex = 7;
            this.GbIndicateLarm2.TabStop = false;
            this.GbIndicateLarm2.Text = "Larm 2";
            // 
            // FormAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 541);
            this.Controls.Add(this.GbIndicateLarm2);
            this.Controls.Add(this.GbIndicateLarm1);
            this.Controls.Add(this.tabAlarm);
            this.Controls.Add(this.GBoxClock);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALARM";
            this.GBoxClock.ResumeLayout(false);
            this.GBoxClock.PerformLayout();
            this.tabAlarm.ResumeLayout(false);
            this.tabAlarmOne.ResumeLayout(false);
            this.tabAlarmOne.PerformLayout();
            this.tabAlarmTwo.ResumeLayout(false);
            this.tabAlarmTwo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxClock;
        private System.Windows.Forms.Label lblClockSetMins;
        private System.Windows.Forms.Label lblClockSetHour;
        private System.Windows.Forms.Label lblAlarmOneMins;
        private System.Windows.Forms.Label lblAlarmOneHrs;
        private System.Windows.Forms.TextBox txtClockSetMins;
        private System.Windows.Forms.TextBox txtClockSetHrs;
        private System.Windows.Forms.TextBox txtAlarmOneMins;
        private System.Windows.Forms.TextBox txtAlarmOneHrs;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnSetAlarmOne;
        private System.Windows.Forms.TabControl tabAlarm;
        private System.Windows.Forms.TabPage tabAlarmOne;
        private System.Windows.Forms.TabPage tabAlarmTwo;
        private System.Windows.Forms.TextBox txtAlarmTwoMins;
        private System.Windows.Forms.TextBox txtAlarmTwoHrs;
        private System.Windows.Forms.Label lblAlarmTwoMins;
        private System.Windows.Forms.Label lblAlarmTwoHrs;
        private System.Windows.Forms.Button btnSetAlarmTwo;
        private System.Windows.Forms.GroupBox GbIndicateLarm1;
        private System.Windows.Forms.GroupBox GbIndicateLarm2;
    }
}

