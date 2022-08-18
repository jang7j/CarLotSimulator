
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot carlot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var instance1 = new Car(); //same as Car instance1 = new Car();
            var instance2 = new Car();
            var instance3 = new Car();
           
            //Set Properties by:
            //1) Dot notation
            instance1.Make = "Honda"; 
            instance1.Model = "Accord";
            instance1.Year = 2009; "
            instance1.EngineNoise = true;
            instance1.HonkNoise = true;
            instance1.isDriveable = true;

            //name of collection, dot add, pass in the car
            carlot.CarList.Add(instance1);
            instance1.Make
                 
            //2) Object initializer syntax
            var instance2 = new Car() { 
                Make = "VW", 
                Model = "Beetle", 
                EngineNoise = "Beep", 
                HonkNoise = "Honk", 
                isDriveable = true };
            //var instance2 = new Car() { Make = "VW", Model = "Beetle", EngineNoise = "Beep", HonkNoise = "Honk", isDriveable = true };
            carlot.CarList.Add(instance2);

            //3) Custom constructor - go back to the class Car & set the parameters & asign properties with those parameters:Make = make; Model = model; Year = year;
            var instance3 = new Car("Jeep", "Wrangler", 2022);
            carlot.CarList.Add(instance3);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var item in carlot.CarList)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                item.MakeEngineNoise("Vroom");
                item.MakeHonkNoise(item.HonkNoise);
            }
        }
    }
}
