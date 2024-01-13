using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrapProject
{
    internal class Pointers
    {
      public static void pointr()
        {
            unsafe
            {
                int n = 20;

                int* p = &n;
                Console.WriteLine("Value : " + n);
                Console.WriteLine("Address " + (int)p);
            }
        }
    }
}
