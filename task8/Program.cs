using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zoo> zoos = new List<Zoo>
            {
                new Zoo("Chinese zoo", "tiger"),
                new Zoo("Gomel zoo", "stork"),
                new Zoo("International zoo", "bear")
            };

            List<Animal> animals = new List<Animal>
            {
                new Animal("tiger", "orange", 2.3, 275),
                new Animal("toad","gray",0.1,0.022),
                new Animal("octopus", "orange", 1, 275),
                new Animal("bear", "black", 2.5, 700),
                new Animal("stork", "white", 1.25, 4 ),
                new Animal { Name = "hyena", Color = "gray" }
            };



            //Method syntax
            var result1 = animals.Where(animal => animal.Weight != default(double) && animal.Size != default(double))
                                 .OrderBy(animal => animal.Weight).ThenBy(animal => animal.Size);

            Console.WriteLine("Output information about animals sorted by weight:\n");
            foreach (var animal in result1)
            {
                animal.ShowInfo();
            }
            Console.Write("\n\n");



            //Query syntax
            var result2 = from animal in animals
                          group animal by animal.Color into a
                          select new
                          {
                              Color = a.Key,
                              Count = a.Count()
                          };

            Console.WriteLine("Display information about the number of animals on a certain color:\n");
            foreach (var item in result2)
            {
                if (item.Count>1)
                    Console.WriteLine($"{item.Count} {item.Color} animals");
                else
                    Console.WriteLine($"{item.Count} {item.Color} animal");
            }
            Console.Write("\n\n");




            var result3 = from animal in animals.Take(5) //without hyena
                          join zoo in zoos on animal.Name equals zoo.AnimalName
                          orderby animal.Name
                          select new
                          {
                              Name = animal.Name,
                              Zoo = zoo.Name
                          };

            Console.WriteLine("Name of animals and where do they live?\n");
            foreach (var item in result3)
            {
                Console.WriteLine($"The {item.Name} lives in the {item.Zoo}");
            }
            Console.Write("\n\n");


            Console.ReadKey();
        }

    }
}
