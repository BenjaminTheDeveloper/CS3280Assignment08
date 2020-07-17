using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{

    /// <summary>
    /// This is the 'ConcreteImplementor' Class
    /// </summary>
    class VehicleData : VehicleDataObject
    {
        private List<string> _vehicles = new List<string>();
        private int _current = 0;

        public VehicleData()
        {

            // In reality this would be loaded from a DB
            _vehicles.Add("Honda Civic");
            _vehicles.Add("Ford Taurus");
            _vehicles.Add("Lamborghini Aventador");
            _vehicles.Add("Chevrolet Silverado");
            _vehicles.Add("Honda Accord");
        }

        public override void NextRecord()
        {
            if (_current <= _vehicles.Count - 1)
            {
                _current++;
            }
            else
            {
                Console.WriteLine("End of list");
            }
        }

        public override void PreviousRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
            else
            {
                Console.WriteLine("There is nothing before this");
            }
        }

        public override void AddRecord(string vehicleName)
        {
            _vehicles.Add(vehicleName);
        }

        public override void DeleteRecord(string vehicleName)
        {
            _vehicles.Remove("vehicleName");
        }

        public override void ShowRecord()
        {
            Console.WriteLine(_vehicles[_current]);
        }

        public override void ShowAllRecords()
        {
            foreach (string vehicleName in _vehicles)
            {
                Console.WriteLine("Vehicle Make and Model: " + vehicleName);
            }
        }
    }
}
