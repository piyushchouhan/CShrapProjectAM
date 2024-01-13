using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrapProject
{
    internal class ParaConstructor
    {
        string name;
        int id;

        ParaConstructor(string name, int id)
        {
            this.name = name;
            this.id = id;
        }   


        public static void Para()
        {
            ParaConstructor geek1 = new ParaConstructor("Piyush", 045);
            Console.WriteLine("GeekName is: " + geek1.name +
                               " and GeekId is: " + geek1.id
                );
        }
    }
}
