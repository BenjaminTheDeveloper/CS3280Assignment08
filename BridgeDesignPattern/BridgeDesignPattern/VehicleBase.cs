using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    /// <summary>
    /// This is the 'Abstraction' Class
    /// </summary>
    public class VehicleBase
    {
        private VehicleDataObject _vehicleDataObject;
        protected string selection;

        public VehicleBase(string selection)
        {
            this.selection = selection;
        }


        //Property
        public VehicleDataObject Data
        {
            set { _vehicleDataObject = value; }

            get { return _vehicleDataObject; }
        }

        public virtual void Next()
        {
            _vehicleDataObject.NextRecord();
        }

        public virtual void Previous()
        {
            _vehicleDataObject.PreviousRecord();
        }

        public virtual void Add(string vehicleName)
        {
            _vehicleDataObject.AddRecord(vehicleName);
        }

        public virtual void Delete(string vehicleName)
        {
            _vehicleDataObject.DeleteRecord(vehicleName);
        }

        public virtual void Show()
        {
            _vehicleDataObject.ShowRecord();
        }

        public virtual void ShowAll()
        {

            Console.WriteLine("Vehicle Selection: " + selection);
            _vehicleDataObject.ShowAllRecords();
        }

        public virtual string GetCount()
        {

                return _vehicleDataObject.VehicleCount(); 
            
        }

        public virtual string GetSelection()
        {
            return this.selection; 
        }
    }
}
