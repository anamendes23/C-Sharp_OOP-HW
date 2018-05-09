using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Vehicle
    {
        private string _make;
        private string _model;
        private int _mileage;
        private int _year;
        private decimal _price;
        private string _engineSize; //like 2.4L V4, 3.8L V8        
        private int _averageMpg;
        private int _customerID;
        private double _zeroToSixty;
        private int _maxTowing;
        /*-----Constructor-----*/
        public Vehicle(string make, string model, int year, decimal price, string engineSize, int averageMpg, double zeroToSixty, int maxTowing)
        {
            _make = make;
            _model = model;
            _year = year;
            _price = price;
            _engineSize = engineSize;
            _averageMpg = averageMpg;
            _zeroToSixty = zeroToSixty;
            _maxTowing = maxTowing;
        }
        /*-----Properties-----*/
        public virtual string Make { get { return _make; } }
        public virtual string Model { get { return _model; } }
        public virtual int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }
        public virtual int Year { get { return _year; } }
        public virtual decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public virtual string EngineSize { get { return _engineSize; } }
        public virtual int AverageMpg { get { return _averageMpg; } }
        public virtual int CustomerID { get { return _customerID; } }
        public virtual double ZeroToSixty { get { return _zeroToSixty; } }
        public virtual int MaxTowing { get { return _maxTowing; } }
        /*-----Methods-----*/
        public virtual void LowerPriceBy(decimal percent)
        {
            _price -= percent * Price / 100;
        }
        public virtual void ChangePrice(decimal newPrice)
        {
            _price = newPrice;
        }
        public virtual void AddCustomer(int customerID)
        {
            _customerID = customerID;
        }
    }
}
