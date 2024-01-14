using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Demo1
    {
        public static void demo()
        {
            int[] intArray;

            intArray = new int[5];

            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;
            intArray[4] = 5;

            int n = intArray.Length;

            Console.Write("Print Using For loop: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(" "+ intArray[i]);
            }

            Console.WriteLine(" ");
            Console.Write("Print Using foreach: ");
            foreach(int i in intArray)
            {
                Console.Write(" " +i);
            }

            Console.WriteLine(" "); 
            Console.Write("Print Using While Loop: ");
            int j = 0;
            while( j < n)
            {
                Console.Write(" "+ intArray[j]);
                j++;
            }
        }
    }
}
