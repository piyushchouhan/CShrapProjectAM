using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Topic1
    {
        public static void topic()
        {
            string[] topic;

            topic = new string[]
            {
                 "Array", "String", "stack", "queue", "Exception", "Operators"
            };

            Console.WriteLine("Topic of the c# before the reverse: ");
            Console.WriteLine(" ");
            foreach(string ele in topic)
            {
                Console.WriteLine(ele + " ");
            }

            Array.Reverse(topic);

            Console.WriteLine("Topic of c# after reverse: ");
            Console.WriteLine(" ");

            foreach(string ele in topic)
            {
                Console.WriteLine(ele + " ");   
            }
        }
    }
}
