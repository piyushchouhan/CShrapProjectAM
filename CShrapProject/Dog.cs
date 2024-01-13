using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShrapProject
{
    public class Dog
    {
        string name;
        string breed;
        int age;
        string color;
            
        public Dog(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public String GetName()
        {
            return name;
        }
        public int GetAge()
        {
               return age;
        }

        public string GetColor() { 
            return color;
        }

        public string GetBreed()
        {
            return breed;
        }

         public string toString()
        {
            return ("Hi my name is " + this.GetName()
                    + ".\nMy Breed, Age and Color are " + this.GetBreed()
                    + ", " + this.GetAge() + ", " + this.GetColor());
         }
           
        public static void dog()
        {
            Dog tuffy = new Dog("tufy", "papillon", 5, "white");
            Console.WriteLine(tuffy.toString());
        }
    }
}
