using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrapProject
{
    internal class TypeConversion
    {
        public static void Conversion()
        {
            int intValue = 42;
            long longValue = intValue; // Implicit conversion from int to long
            Console.WriteLine($"Implicit Conversion: int to long : {longValue}");

            long anotherLongValue = 987456321459;
            int anotherIntValue = (int)anotherLongValue; // Explicit conversion (casting) from long to int
            Console.WriteLine($"Explicit Casting: long to int : {anotherIntValue}");

            // Explicit Casting (Using Convert class)
            double doubleValue = 3.14;
            int intFromDouble = Convert.ToInt32(doubleValue);
            Console.WriteLine($"Convert.ToInt32: double to int : {intFromDouble}");

            int num = 10;
            object boxedValue = num; //boxing
            int unboxedValue = (int)boxedValue; //unboxing
            Console.WriteLine($"Boxing and Unboxing: {unboxedValue}");

        }

    }
}
