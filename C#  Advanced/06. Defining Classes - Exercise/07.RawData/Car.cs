using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Car
    {
  

        public Car(string model, int engineSpeed, int enginePower, Cargo cargo, Tire[] tires)
        {
            Model = model;
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
            Cargo = cargo;
            Tires= tires;
        }

        public string Model { get; set; }

        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }

        public  Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }

    }
}
