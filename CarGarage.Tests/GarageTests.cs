using System;
using Xunit;

namespace CarGarage.Tests
{
    public class GarageTests
    {
        [Fact]
        public void ShouldAddCarToGarage()
        {
            // Tests AddCar() method

            // Arrange
            var mygarage = new Garage();
            var mycar = new Car("BMW","745i");
            // Act
            mygarage.MyCars.Add(mycar);
            // Assert
            Assert.Equal(mycar,mygarage.MyCars[0]);
        }

        [Fact]
        public void ShouldRemoveCarFromGarage()
        {
            // Tests RemoveCar() method

            // Arrange
            var MyGarage = new Garage();
            var Mycar = new Car();
          //  var extra = new Car(); 
            // Act
            MyGarage.MyCars.Add(Mycar);
          //MyGarage.Cars.Add(extra);   <-- //Fails
            MyGarage.MyCars.RemoveAt(0);
            // Assert
            Assert.Empty(MyGarage.MyCars);
        }

        [Fact]
        public void ShouldFuelAllCars()  
        {
            // Tests FuelAllCars() method
            // Arrange
            var Mycars = new Garage();
            // Act
            Mycars.MyCars.Add(new Car());//0
            Mycars.MyCars.Add(new Car());//1
            Mycars.MyCars.Add(new Car());//2
            Mycars.MyCars[0].Accelerate();
            Mycars.MyCars[1].Accelerate();
            Mycars.MyCars[2].Accelerate();
            Mycars.FuelAllCars();
            // Assert
            Assert.Equal(100, Mycars.MyCars[2].GasLevel);
            Assert.Equal(100, Mycars.MyCars[1].GasLevel);
            Assert.Equal(100, Mycars.MyCars[0].GasLevel);
        }

        [Fact]
        public void TestifCarisSelected()
        {
            //ARRANGE
            Garage mygarage = new Garage();
            //ACT
            mygarage.AddCar("Ford", "Focus");
            mygarage.SelectCar(0); //SELECTING CAR RETURN type is Car
            mygarage.MyCars[0].ToggleMethod();

            //ASSERT
            Assert.True(mygarage.MyCars[0].EngineStatus);
        }
        [Fact]
        public void ShouldTestDriveOneCar()
        {
            // Use the Program class to let you select a single car
            // Program class should then let you choose what you want to do with that car
            // You do not need to test user input in the Program class

        }

        [Fact]
        public void YuShouldNameThisTest()
        {
            // Should be able to list stats of all cars
            // Create necessary method(s)
            // Garage class should provide cars
            // Program class should list all stats
        }
    }
}
