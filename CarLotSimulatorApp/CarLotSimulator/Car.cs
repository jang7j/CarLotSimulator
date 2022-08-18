using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public Car() //default constructor
    
    internal class Car(string make, string model, int year) //parameterized constructor
    {
        Make = make;
        Model = model;
        Year = year;
    }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public int isDriveable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"My car's engine sounds like {noise}");
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"My car's honk sounds like {HonkNoise}");
        }


    }

}
