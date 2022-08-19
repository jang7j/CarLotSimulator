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

    
}


//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property

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
        public void MakeHonkNoise(string honk)
        {
            Console.WriteLine($"My car's honk sounds like {honk}");
        }

    }

}



