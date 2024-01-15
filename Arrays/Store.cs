using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Store
    {
        public static void stores()
        {
            string[] store;

            store = new string[]
            {
                "Americano", "Cafe au Lalit", "Epresso", "Cappucino", "Long Back"
            };

            foreach(string s in store)
            {
                Console.WriteLine(s + " ");
            }
        }
    }
}
