using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Static Constructor has to be invoked only once in the class and has been invoked during the creation of the first reference to a
// static member of the class. A static constructor initialized the static field or data of the class and to be executed only once.
namespace CShrapProject
{
    internal class StaticCons
    {
        // It is invoked before the first
        // instance constructor is run.
        static StaticCons()
        {

            // The following statement produces
            // the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static Constructor");
        }

        public StaticCons(int i)
        {
            Console.WriteLine("Constructor Initialize: " + i);
        }

        public String Details(string name, int id)
        {
            return "name: " + name + " id: " + id;
        }

        public static void Static()
        {
            StaticCons obj = new StaticCons(1);
            Console.WriteLine(obj.Details("Piyush", 1));

            StaticCons obj1 = new StaticCons(2);
            Console.WriteLine(obj1.Details("Chauhan", 2));
        }

    }
}
