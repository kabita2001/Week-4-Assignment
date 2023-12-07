using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07
{
    internal class Calender
    {
        public enum DaysofWeek 
        { 
         Monday,
         Tuesday,
         Wednesday,
         Thursday,
         Friday,
         Saturday,
         Sunday
        }

        public void PrintWeekDays() 
        {
            Console.WriteLine("The weekdays are:");

            foreach (DaysofWeek day in Enum.GetValues(typeof(DaysofWeek))) 
            {
              if (day >= DaysofWeek.Monday && day<= DaysofWeek.Friday) 
                {
                    Console.WriteLine(day);
                }
            }
        }
    }
}
