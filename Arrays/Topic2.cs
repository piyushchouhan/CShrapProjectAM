using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Topic2
    {
        public static void topic()
        {
            string[] topic;
            topic = new string[]
            {
                 "Array", "String", "stack", "queue", "Exception", "Operators"
            };

            Console.WriteLine("Topic of c# before the sorting: ");
            Console.WriteLine(" ");

            foreach(string ele in topic)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine(" ");

            Array.Sort(topic);

            for(int i = 0; i < topic.Length; i++)
            {
                Console.WriteLine(topic[i]+ " ");
            }
        }
    }
}
