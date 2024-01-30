using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Interface
{
    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public string Height { get; set; }
        public string Age { get; set; }
        public Cat() 
        {
        }
        public void Eat()
        {
            Console.WriteLine("Cats eats mice");
        }
        public string Cry()
        {
            return "Meowf";
        }
    }
}
