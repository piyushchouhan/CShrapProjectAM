using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class DemoEncap
    {
        private String StudentName;
        private int StudentAge;

        public string Name
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        public int Age
        {
            get { return StudentAge; }
            set { StudentAge = value; }
        }
    }

    class Encap
    {
        public static void Enacaps()
        {
            DemoEncap obj = new DemoEncap();
            obj.Name = "Piyush";
            obj.Age = 22;

            Console.WriteLine("Name is : " + obj.Name);
            Console.WriteLine("Age is: " + obj.Age);
        }         
    }
}
