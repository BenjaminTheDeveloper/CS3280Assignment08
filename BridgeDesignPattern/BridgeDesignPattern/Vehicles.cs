using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    /// <summary>
    /// This is the 'RefinedAbstraction' class
    /// </summary>
       public class Vehicles : VehicleBase
    {

        //Constructor
        public Vehicles(string selection) : base(selection)
        { }


        public override void ShowAll()
        {
            //Add separator lines 
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            base.ShowAll();
            Console.WriteLine("-------------------------------");

        }
    }




}
