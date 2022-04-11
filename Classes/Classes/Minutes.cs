using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Classes.Classes
{
    public class Minutes
    {
        public static int MinuteStart { get; set; }
        public static int MinuteValue { get; set; }

        
        public Minutes(int minute)
        {
            MinuteValue = minute;
            MinuteStart = minute;
        }

        /// <summary>
        /// Returns the value of field MinuteValue
        /// </summary>
        /// <returns></returns>
        public static int GetMinute()
        {
            return MinuteValue;
        }

        /// <summary>
        /// Handle the tick-statement for Minutes
        /// </summary>
        /// <param name="minute"></param>
        /// <returns></returns>
        public static int Tick(int minute)
        {

            if (minute < 59)
            {
                minute++;
            }
            else
            {
                minute = 00;
            }

            return MinuteValue = minute;
        }
    }
}
