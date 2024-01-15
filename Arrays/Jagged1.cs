using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Jagged1
    {
        public static void Jaggad()
        {
            int[][, ] jagged_arr = new int[4][, ] {
                        new int[, ] { {1,3 },{5,7} },
                        new int[, ] { {0,2 }, {4,6 },{8,10 } },
                        new int[, ] { {7,8 }, { 3,1,},{0,6 } },
                        new int[, ] { {11,22 }, {99,88 },{0,9 } }
            };

        for(int i = 0; i < jagged_arr.Length; i++)
            {
                int x = 0;
                for(int j = 0; j< jagged_arr[i].GetLength(0); j++)
                {
                    for(int k = 0; k < jagged_arr[i].GetLength(1); k++)
                    {
                        Console.Write(jagged_arr[i][j, k] + " ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
