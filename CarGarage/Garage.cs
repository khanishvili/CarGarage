using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Garage
    {
        public List<Car> MyCars { get; set; }
        public Garage()
        {
            MyCars = new List<Car>();
        }
        public void AddCar(string make, string model)
        {
            if (make.Length > 0 && 0 < make.Length)
            {
                MyCars.Add(new Car(make, model));
            }
            else
            {

            }

        }
        public void AddCar()
        {
            MyCars.Add(new Car());
        }    // only for test
        public void AddCar(int set_Gas_for_Start)
        {
            MyCars.Add(new Car(set_Gas_for_Start));
        } // only for test
        public void PrintCars() //with status
        {
            Console.WriteLine("====Garage====");
            for(int i = 0; i < MyCars.Count; i++)
            {
                Console.WriteLine("\t\t\t ID : {0}   {1}  {2}  Tank level => {3} ",
                    i,
                    MyCars[i].Make.PadRight(8),
                    MyCars[i].Model.PadRight(5),
                    MyCars[i].GasLevel.ToString().PadRight(2));
            }
        }
        public void RemoveCar(int index)
        {
            if (index > MyCars.Count) //checks if Index exists in Mycars's List
            {
                Console.WriteLine("We dont have a car with this ID");
            }
            else
            {
                Console.Write(" {0} {1} is removed from List",
                    MyCars[index].Make,
                    MyCars[index].Model);
                MyCars.RemoveAt(index);
               
            }
        }
        public void FuelAllCars()
        {
            for(int i = 0; i < MyCars.Count; i++)
            {
                MyCars[i].AddFuel();
            }
        }
        public Car SelectCar(int id)
        {
           
            return MyCars[id];
        }
        
    }
}
