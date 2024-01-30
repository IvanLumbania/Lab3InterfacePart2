using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Interface
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }
        public Dog()
        {
        }

        public  void Eat()
        {
            Console.WriteLine("Dog eats meat");
        }
        public  string Cry()
        {
            return "Woof";
        }
    }
}
