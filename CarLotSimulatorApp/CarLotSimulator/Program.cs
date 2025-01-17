﻿using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            #region
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            #endregion

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //var car1 = new Car();
            //Car car1 = new Car();

            CarLot carLot = new CarLot();
            
            Car car1 = new Car() { Year = 2022, Make = "Toyota", Model = "Camry", EngineNoise = "Quiet", HonkNoise = "Loud", IsDriveable = "Yes" };
            car1.NewCar();      
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            carLot.ParkingLot.Add(car1);
            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");
           
            Console.WriteLine();
            Console.WriteLine("----------------------------");

            var car2 = new Car();
            {
                car2.Year = 2021;
                car2.Make = "Honda";
                car2.Model = "Civic";
                car2.EngineNoise = "Loud";
                car2.HonkNoise = "Loud";
                car2.IsDriveable = "No";

                car2.NewCar();
                car2.MakeEngineNoise();
                car2.MakeHonkNoise();
                carLot.ParkingLot.Add(car2);
                Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------");

            var car3 = new Car();
            {
                car3.Year = 2020;
                car3.Make = "Chevy";
                car3.Model = "Traverse";
                car3.EngineNoise = "Quiet";
                car3.HonkNoise = "Loud";
                car3.IsDriveable = "Yes";

                car3.NewCar();
                car3.MakeEngineNoise();
                car3.MakeHonkNoise();
                carLot.ParkingLot.Add(car3);
                Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");
            };


            



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
