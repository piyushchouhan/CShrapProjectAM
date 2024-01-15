using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Topic
    {
        public static void topics()
        {
            string[] topic;
            topic = new string[]
            {
                "Array", "String", "stack", "queue", "Exception", "Operators"
            };

            Console.WriteLine("Length of the array: " + topic.Length);

            foreach (var item in topic)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
