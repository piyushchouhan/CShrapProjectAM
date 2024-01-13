using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrapProject
{
    internal class Geek
    {
        int num;
        string name;

        //Program for Default Constructor
        Geek()
        {
            Console.WriteLine("Constructor is Called! ");
        }

        public static void Geeks()
        {
             Geek geek1 = new Geek();

            Console.WriteLine(geek1.name);
            Console.WriteLine(geek1.num);
        }
    }
}
