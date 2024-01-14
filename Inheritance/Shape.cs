using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//prpgram to demonstrate abstration 
namespace Inheritance
{
    //abstract class 
    abstract class Shape
    {
        //abstract method
        public abstract int area();
    }

    class Square : Shape
    {
        private int side;

        public Square(int x = 0)
        {
            side = x;
        }
        public override int area()
        {
            Console.WriteLine("Area of the Square is: ");
            return (side * side);
        }
            
    }

    class Solutions
    {
        public static void solution()
        {
            Shape sh = new Square(4);

            double area = sh.area();
            Console.WriteLine(area);
        }
    } 
}
