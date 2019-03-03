using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Animal : IAnimal
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }

        public Animal(string name, string color, double size, double weight)
        {
            Name = name;
            Color = color;
            Size = size;
            Weight = weight;
        }

        public Animal()
        {
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Color} {Name} is {Size} meters and {Weight} kilogram.");
        }
    }
}
