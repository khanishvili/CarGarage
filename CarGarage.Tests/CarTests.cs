using System;
using Xunit;
using CarGarage;

namespace CarGarage.Tests
{
    public class CarTests
    {
        [Fact]
        public void ShouldAccelerate()
        {
            // Tests Accelerate() method in Car increases Speed
            // Arrange
            var Mycar = new Car();

            // Act
            Mycar.Accelerate();
            // Assert
            Assert.Equal(10,Mycar.Speed);
        }

        [Fact]
        public void ShouldConsumeFuel()
        {
            // Tests Accelerate() method reduces Fuel amount

            // Arrange
            var temp = new Car();
            // Act
            temp.Accelerate();

            // Assert
            Assert.Equal(90, temp.GasLevel);
        }

        [Fact]
        public void ShouldRefuel()
        {
            // Tests AddFuel() method increases Fuel amount
            // Arrange
            var Mycar = new Car(43);
            // Act
            Mycar.AddFuel();
            // Assert
            Assert.Equal(100, Mycar.GasLevel);
        }
    
        [Fact]
        public void ShouldSlowDown()
        {
            // Tests Brake() method in Car reduces Speed amount
            // Arrange
            var mycar = new Car();
            // Act
            mycar.Accelerate();
            mycar.Brake();
            // Assert
            Assert.Equal(5,mycar.Speed);
        }
    
        [Fact]
        public void ShouldStart()
        {
            // Tests ToggleEngine() method starts car when its off
            var car = new Car(20);
            // Arrange
            car.ToggleMethod();
            // Act

            // Assert 
            Assert.True(car.EngineStatus);
          }
      
        [Fact]
        public void ShouldTurnOff()
        {
            // Tests ToggleEngine() method turns car off when its on
            var car = new Car(); 
            // Arrange
            car.ToggleMethod();
            car.ToggleMethod();
           
            // Act
            Assert.False(car.EngineStatus);
            // Assert
        }
    }
}
