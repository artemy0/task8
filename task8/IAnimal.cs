using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    interface IAnimal
    {
        string Name { get; }
        double Size { get; set; }
        double Weight { get; set; }
        string Color { get; set; }

        void ShowInfo();
    }
}
