using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
 public   class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; private set; }
        public int GasLevel { get; private set; }
        public  bool EngineStatus { get; private set; }
        
        public Car() //Empty
        {
            Speed = 0;
            GasLevel = 100;
            EngineStatus = false;
        }
        public Car(int gas) //Set gas level
        {
            GasLevel = gas;
            EngineStatus = false;
        }
        public Car(string make,string model) //Passes make and model  set other atributes by default 
        {
            Make = make;
            Model = model;
            EngineStatus = false;
            GasLevel = 100;
        }
        public void AddFuel()
        {
            GasLevel = 100;
        }
        public void Accelerate()
        {
            Speed += 10;
            GasLevel -= 10;
        }
        public void Brake()
        {
            Speed -= 5;
        }
        public void ToggleMethod()
        {
            Speed = 0;
            if (EngineStatus)//if engine is on
            {
                Console.WriteLine(" Your {0}   is OFFF ", Make);
                EngineStatus = false;//turn off
            }
            else //If Engine is off
            {
                Console.WriteLine(" {0} ready to roll", Make);
                EngineStatus = true; //StartCar
            }
        }
    }
    
}
