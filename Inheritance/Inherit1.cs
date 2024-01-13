using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Inherit1
    {
        public String name;
        public String subject;

        public void readers( string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("My Name is : " +  name);
            Console.WriteLine("My favourite subject is: " + subject);
        }

    }

    class SubClass : Inherit1
    {
        public SubClass()
        {
            Console.WriteLine("I am a sub class");
        }
    }

    class Solution
    {
        public static void Inherit()
        {
            SubClass obj = new SubClass();

            obj.readers("Piyush", "C#");
        }

    }

}
