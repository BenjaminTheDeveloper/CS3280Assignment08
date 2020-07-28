using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Implementor Abstract Class 
    /// This will be implemented into the VehicleData Class 
    /// </summary>
   public abstract class VehicleDataObject
    {

        public abstract void NextRecord();
        public abstract void PreviousRecord();
        public abstract void AddRecord(string vehicleName);

        public abstract void DeleteRecord(string vehicleName);

        public abstract void ShowRecord();

        public abstract void ShowAllRecords();

        public abstract string VehicleCount(); 
    }

}
