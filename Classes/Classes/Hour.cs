using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes
{
    public class Hour
    {
        public static int HourStart { get; set; }
        public static int HourValue { get; set; }
        

        public Hour()
            : this(0)
        {
            
        }
        public Hour(int hour)
        {
            HourValue = hour;
            HourStart = hour;
        }


        
        /// <summary>
        /// Returns the value of field HourValue
        /// </summary>
        /// <returns></returns>
        public static int GetHour()
        {
            return HourValue;
        }

        /// <summary>
        /// Handle the tick-statements for hours
        /// </summary>
        /// <param name="hour"></param>
        /// <returns></returns>
        public static int Tick(int hour)
        {
            if(hour < 23)
            {
                hour++;
            }
            else
            {
                hour = 00;
            }

            return HourValue = hour;
        }
    }
}
