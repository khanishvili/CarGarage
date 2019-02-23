using System;

namespace CarGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            //asd


            Console.WriteLine("\t\t\t==== Wellcome ====");
            Garage mycars = new Garage();

            mycars.AddCar("Chevrolet", "Silverado");
            mycars.AddCar("Audi", "Q7");
            mycars.AddCar("Ford", "Fusion");
            Console.WriteLine(mycars.MyCars.Count.ToString());
            bool run = true;
            Header();
            do
            {
                var key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case (char)ConsoleKey.D1: //Print Cars
                        Console.WriteLine("press 0 to quit");
                        mycars.PrintCars();
                        break;
                    case (char)ConsoleKey.D2: //Select car
                        Console.WriteLine("Please Type ID (NUMBERS) only and Press Enter : ");
                         int selector = Convert.ToInt32(Console.ReadLine());
                        if (selector>mycars.MyCars.Count)
                        {
                            Console.WriteLine("We don't have a car with this ID number");
                        }
                        else
                        {
                            Test_Drive(mycars.SelectCar(selector));
                            
                        }
                        break;
                    case (char)ConsoleKey.D3: //Add car
                        Console.Write(" Make : "); string make = Console.ReadLine();
                        Console.Write(" Model : "); string model = Console.ReadLine();
                        mycars.AddCar(make, model);
                        Console.WriteLine("Car {0} {1} is parked in garage",make,model);

                        
                        break;
                    case (char)ConsoleKey.D4: //Remove Car
                        Console.WriteLine("Please Type ID   and Press Enter  to remove car from list ");
                        int index = Convert.ToInt32(Console.ReadLine());

                        mycars.RemoveCar(index); 
                        Console.WriteLine("Press 1 to Print list");
                        break;
                    case (char)ConsoleKey.D5: //Fuell All Cars
                        Console.WriteLine("You fueled all cars!");
                        mycars.FuelAllCars();
                        Console.WriteLine("press 0 to quit");
                        break;
                    case (char)ConsoleKey.D0: //Select car
                        run = false;
                        break;
                    default:
                        Console.WriteLine("\n\npress 0 to quit");
                        break;
                }
            }
            while (run);
       }

        private static void Test_Drive(Car selectedcar)
        {
          
         Console.WriteLine("You selected to drive {0} {1} press 5 for instrusctions!" ,selectedcar.Make,selectedcar.Model);
         string carisoffmessage = "Your car is off press 1 to start!!";
            bool run = true;
         do{
                
                var key = Console.ReadKey();
                switch (key.KeyChar)
                { 
                case (char)ConsoleKey.D1: //Start or Stop
                        selectedcar.ToggleMethod();
                    Console.WriteLine("");
                    
                    break;
                case (char)ConsoleKey.D2: // Accelerate
                        if (selectedcar.EngineStatus)
                        {
                            selectedcar.Accelerate();
                            Console.WriteLine("\t\t\t Speed {0}  {1}", selectedcar.Speed, selectedcar.GasLevel);
                        }
                        else
                        {
                            Console.WriteLine(carisoffmessage);
                        }
                        Console.WriteLine("press 0 to quit");
                    break;
                case (char)ConsoleKey.D3: // Brake
                        if (selectedcar.EngineStatus)
                        {
                            selectedcar.Brake ();
                            Console.WriteLine("You slowed down your car ");
                            Console.WriteLine("\t\t\t Speed {0}  {1}", selectedcar.Speed, selectedcar.GasLevel);
                        }
                        else
                        {
                            Console.WriteLine(carisoffmessage.ToString());
                            
                        }
                        Console.WriteLine("press 0 to quit");
                break;
                case (char)ConsoleKey.D4: // Add Fuel
                        if (selectedcar.GasLevel == 100)
                        {
                            Console.WriteLine("\t\t\t Don't need fuel!!!!");
                        }
                        else
                        {
                            selectedcar.AddFuel();
                            Console.WriteLine("\t\t\t You tank is full");
                        }
                break;
                    case (char)ConsoleKey.D5:
                        Console.WriteLine("\t\t\t\t Press 1 to Start/Stop Your car");
                        Console.WriteLine("\t\t\t\t Press 2 to Accelerate");
                        Console.WriteLine("\t\t\t\t Press 3 to slow down");
                        Console.WriteLine("\t\t\t\t Press 4 to Addfuel");
                        Console.WriteLine("\t\t\t\t Press 0 to quit");
                        break;

                case (char)ConsoleKey.D0: //Select car
                    run = false;
                break;
                default:
                        Console.WriteLine("Press 5 for instructions");
                    break;
            }
        }
            while(run);
        }

        static void Header()
        {
            Console.WriteLine("Press 1 print all your cars");
            Console.WriteLine("Press 2 to select a car from list");
            Console.WriteLine("Press 3 to Add Car");
            Console.WriteLine("Press 4 to remove a car from list");
            Console.WriteLine("Press 5 to fuel all cars from list");

        }
        static void Selector(int index)
        {

        }
    }
}
