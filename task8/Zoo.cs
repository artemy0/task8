using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Zoo
    {
        public string Name { get; set; }
        public string AnimalName { get; set; }

        public Zoo(string name, string animalName)
        {
            Name = name;
            AnimalName = animalName;
        }
    }
}
