using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrapProject
{
    internal class ObjectCon
    {
        public static void RefObject()
        {
            string a = "Geeks";
            a = a + "Geeks";
            Console.WriteLine(a);

            object obj;
            obj = 20;
            Console.WriteLine(obj);

            Console.WriteLine(obj.GetType());
        }
    }
}
