using System;
using System.Collections.Generic;

namespace BridgeDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Design Pattern with Vehicles");

            //Creating a RefinedAbstraction
            Vehicles vehicles = new Vehicles("Salt Lake City");

            //Set ConcreteImplementor
            vehicles.Data = new VehicleData();

            //Practice with the bridge
            vehicles.Show();
            vehicles.Next();
            vehicles.Show();
            vehicles.Next();
            vehicles.Show();
            vehicles.ShowAll();
            Console.WriteLine("Vehicle Count: " +vehicles.GetCount());
            Console.WriteLine("After adding vehicle");

            vehicles.Add("Ford F150");
            Console.WriteLine("Vehicle Count: " + vehicles.GetCount());
            vehicles.ShowAll(); 


        }
    }

  


   
   

    

}
