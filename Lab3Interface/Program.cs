using System.Runtime.CompilerServices;

namespace Lab3Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog
            Console.WriteLine("Enter dog name");

            string dogName = Console.ReadLine();
            Dog dog = new Dog();
            dog.Name = dogName;

            Console.WriteLine("Enter dogs height");
            dog.Height = Console.ReadLine();

            Console.WriteLine("Enter dog colour");
            dog.Colour = Console.ReadLine();

            Console.WriteLine("Enter dog age");
            dog.Age = Console.ReadLine();

            Console.WriteLine($"Dog name is: {dog.Name}\n" +
                $"Dog height is: {dog.Height}'\n" +
                $"Dog colour is: {dog.Colour}\n" +
                $"Dog age is: {dog.Age}");
            dog.Eat();
            Console.WriteLine($"Dogs {dog.Cry()}\n");


            //Cat
            Console.WriteLine("Enter cat name");

            string catName = Console.ReadLine();
            Cat cat = new Cat();
            cat.Name = catName;

            Console.WriteLine("Enter cats height");
            cat.Height = Console.ReadLine();

            Console.WriteLine("Enter cats colour");
            cat.Colour = Console.ReadLine();

            Console.WriteLine("Enter cat age");
            cat.Age = Console.ReadLine();

            Console.WriteLine($"cat name is: {cat.Name}\n" +
                $"cat height is: {cat.Height}'\n" +
                $"cat colour is: {cat.Colour}\n" +
                $"cat age is: {cat.Age}");
            cat.Eat();
            Console.WriteLine($"Dogs {cat.Cry()}\n");

            //List of the animals
            List<IAnimal> Animals = new List<IAnimal>();
            Animals.Add(dog);
            Animals.Add(cat);

            for(int i = 0; i < Animals.Count; i++)
            {
                Console.WriteLine(Animals[i].Name);
            }

        }
    }

}
