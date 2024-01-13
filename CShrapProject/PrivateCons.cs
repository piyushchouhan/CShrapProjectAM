using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// If a constructor is created with private specifier is known as private constructor.It is not possible for other classes 
// to derive from this class and also it's not possible to create the instance of this class
namespace CShrapProject
{
    internal class PrivateCons
    {
        //declare the private constructor
        private PrivateCons()
        {

        }

        //declare static variable field
        public static int count_geeks;

        public static int Geeks_count()
        {
            return ++count_geeks;
        }

        public static void Private()
        {
            PrivateCons.count_geeks = 100;
            PrivateCons.Geeks_count();

            Console.WriteLine(PrivateCons.count_geeks);

            PrivateCons.Geeks_count();

            Console.WriteLine(PrivateCons.count_geeks);
        }
    }

}
