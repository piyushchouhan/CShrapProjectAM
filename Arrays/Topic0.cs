using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Topic0
    {
        public static void topic()
        {
            string[] topic;
            topic = new string[]
            {
                 "Array", "String", "stack", "queue", "Exception", "Operators"
            };

            Console.WriteLine("Rank of the array: " + topic.Rank);

            foreach (string ele in topic) {
                Console.WriteLine($"{ele}");
            }
        }
    }
}
