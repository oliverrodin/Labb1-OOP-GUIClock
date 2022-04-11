using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes.Classes
{
    public class Alarm 
    {
        public int Hour { get; set; }
        public int Minute { get; set; }

        public Alarm(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        /// <summary>
        /// return the setted alarm time in a formatted string
        /// </summary>
        /// <returns></returns>
        public string GetAlarmTime()
        {
            return $"{Hour:00}:{Minute:00}";
        }


        
    }
}
