using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Car : Vehicle
    {
        public Car(string make, string model, int year, decimal price, string engineSize, int averageMpg) : 
            base(make, model, year, price, engineSize, averageMpg, 0, 0) { }
    }
}
