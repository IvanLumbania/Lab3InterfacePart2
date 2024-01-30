using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Interface
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        string Height { get; set; }
        string Age { get; set; }

    
        abstract void Eat();

        string Cry();
       
    }
}
