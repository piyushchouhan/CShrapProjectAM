using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrapProject
{
    internal class Example
    {
        // Static variable
        private static int staticVariable;

        // Static constructor
        static Example()
        {
            Console.WriteLine("Static constructor called.");
            staticVariable = 42;
        }

        // Static method
        public static void DisplayStaticVariable()
        {
            Console.WriteLine($"Static variable value: {staticVariable}");
        }

        // Instance constructor
        public Example()
        {
            Console.WriteLine("Instance constructor called.");
        }

        public static void Exmpl()
        {
            // Accessing the static constructor
            Example.DisplayStaticVariable();

            // Creating an instance (instance constructor is called)
            Example instance = new Example();

            // Accessing the static variable again
            Example.DisplayStaticVariable();
        }
    }
}
