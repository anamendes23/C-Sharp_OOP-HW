using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Truck : Vehicle
    {
        public Truck(string make, string model, int year, decimal price, string engineSize, int averageMpg, int maxTowing) : 
            base(make, model, year, price, engineSize, averageMpg, 0, maxTowing) { }
    }
}
