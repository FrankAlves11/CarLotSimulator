using Microsoft.VisualBasic;
using System;
using System.Numerics;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {          
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
          
            Car car1 = new Car
            {
                Year = 2023,
                Make = "BMW",
                Model = "M4",
                EngineNoise = "BOOM BOOM",
                HonkNoise = "Beep",
                IsDriveable = true
            };
            CarLotClass.IncerementCarValue();
            



            Car car2 = new Car
            {
                Year = 1967,
                Make = "Chevy",
                Model = "Impala",
                EngineNoise = "POP POP",
                HonkNoise = "Beep Boop",
                IsDriveable = true

            };
            CarLotClass.IncerementCarValue();

            Car car3 = new Car
            {
                Year = 2020,
                Make = "Mercedes",
                Model = "AMG",
                EngineNoise = "BRRRRR",
                HonkNoise = "Meep Meep",
                IsDriveable = true
                
            };
            CarLotClass.IncerementCarValue();
           
            Console.WriteLine($"There are {CarLotClass.GetNumCars()} Cars.");


            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            car3.MakeEngineNoise();
            car3.MakeHonkNoise();







        //Now that the Car class is created we can instanciate 3 new cars
        //Set the properties for each of the cars
        //Call each of the methods for each car

        //*************BONUS*************//

        // Set the properties utilizing the 3 different ways we learned about, one way for each car

        //*************BONUS X 2*************//

        //Create a CarLot class
        //It should have at least one property: a List of cars
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    }
    }
}
