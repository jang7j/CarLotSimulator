
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot Carlot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var car1 = new Car(); //same as Car car1 = new Car(); 
            
            //Set Properties by:
            //1) Dot notation
            car1.Make = "Honda"; 
            car1.Model = "Accord";
            car1.Year = 2009; "
            car1.EngineNoise = true;
            car1.HonkNoise = true;
            car1.isDriveable = true;

            //name of collection, dot add, pass in the car
            carlot.CarList.Add(car1);
            car1.Make
                 
            //2) Object initializer syntax
                    
            var car2 = new Car() { 
                Make = "VW", 
                Model = "Beetle", 
                EngineNoise = "Beep", 
                HonkNoise = "Honk", 
                isDriveable = true };
            //SAME AS: var instance2 = new Car() { Make = "VW", Model = "Beetle", EngineNoise = "Beep", HonkNoise = "Honk", isDriveable = true };
            carlot.CarList.Add(instance2);

            //3) Custom constructor - First, go back to the class Car & set the parameters & assign properties with those parameters: Make = make; Model = model; Year = year;
            var car3 = new Car("Jeep", "Wrangler", 2022);
            carlot.CarList.Add(car3);


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
                item.MakeHonkNoise("honk");
            }

           
        }
    }
}
