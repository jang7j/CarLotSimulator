using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public List<Car> CarList { get; set; } = new List<Car>(); //OR var CarList {get;set;} = new List<Car>();  

        public static int numberOfCars = 0;

    }



}