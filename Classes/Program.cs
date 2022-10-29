using System.Collections.Generic;
using System;
namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var honda = new Car();
            honda.Make =  "HONDA";
            honda.Model = "Civic";
            honda.Year =    2023;

            var bwm = new Car();
            bwm.Make =     "BWM";
            bwm.Model =    "MP4";
            bwm.Year =      2022;
            


            var carList = new List<Car>();
            carList.Add(honda);
            carList.Add(bwm);

            Console.WriteLine("Cars Inventory");
            Console.WriteLine("******************************");
            Console.WriteLine("Make    Model       Year");



            foreach (var item in carList)
            {

              

                Console.WriteLine($"  { item.Make}   { item.Model}   { item.Year}");
            }
            
        }
    }
}
