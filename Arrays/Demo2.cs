using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Demo2
    {
        public static void demo()
        {
            String[] weekdays;

            weekdays = new String[] {"Sun", "Mon", "Tue", "Wed",
                                       "Thu", "Fri", "Sat"};
            // Displaying Elements of array
            foreach (string day in weekdays)
                Console.Write(day + " ");
        }
    }
}
