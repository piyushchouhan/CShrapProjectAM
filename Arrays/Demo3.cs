using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Demo3
    {
        public static void demo()
        {
            int[,] intArray = new int[,] {
                { 1, 2 },
                { 2, 3 },
                { 3, 4 }, 
                { 4, 5 },
            };

            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                for(int j = 0;  j < intArray.GetLength(1); j++)
                {
                    Console.Write(intArray[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            int[,,] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                                  { { 7, 8, 9 }, { 10, 11, 12 } } };

            for(int i = 0; i<intarray3Dd.GetLength(0); i++)
            {
                for(int j = 0; j< intarray3Dd.GetLength(1); j++)
                {
                    for(int k = 0; k < intarray3Dd.GetLength(2); k++)
                    {
                        Console.Write(intarray3Dd[i,j,k] + " ");
                    }
                    Console.WriteLine(" ");
                }
                
            }
        }
    }
}
