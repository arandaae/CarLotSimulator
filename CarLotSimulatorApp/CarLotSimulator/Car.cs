﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public Car()
        {
            CarLot.numberOfCars++;
        }
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }
        
        public void MakeEngineNoise()
        {
            var engineNoise = EngineNoise;
            Console.WriteLine($"{engineNoise}");
        }

        public void MakeHonkNoise()
        {
            var honkNoise = HonkNoise;
            Console.WriteLine($"{honkNoise}");
        }

        public void NewCar()
        {
            Console.WriteLine(Year);
            Console.WriteLine(Make);
            Console.WriteLine(Model);
            Console.WriteLine(EngineNoise);
            Console.WriteLine(HonkNoise);
            Console.WriteLine(IsDriveable);
        }

        

    }
}
