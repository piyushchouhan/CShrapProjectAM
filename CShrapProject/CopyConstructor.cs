using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrapProject
{
    internal class CopyConstructor
    {
        private String month;
        private int year;

        //declaring copy constructor
        public CopyConstructor(CopyConstructor s)
        {
            month = s.month;
            year = s.year;
        }
        //Instance Constructor
        public CopyConstructor(String month, int year)
        {
            this.month = month; 
            this.year = year;   
        }

        public string getDetails
        {
            get{
                return ("Month" + month.ToString() +
                    "\nYear" +  year.ToString());
            }
        }

        public static void Copy()
        {
            CopyConstructor copy1 = new CopyConstructor("July", 1999);
            CopyConstructor copy2 = new CopyConstructor(copy1);
            Console.WriteLine(copy2.getDetails);

        }


    }
    
}
