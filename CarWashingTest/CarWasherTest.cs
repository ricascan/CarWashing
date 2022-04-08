using CarWashing;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;


namespace CarWashingTest
{
    public class CarWasherTest
    {
        [Fact]
        public void Automatic_washing_is_correct()
        {
            ICarWasher carWasher = CarWasherFactory.GetCarWasher(WashingTypes.Automatic);
            carWasher.AddCar(new Car() { Model = "Ford Mondeo", RegistrationDate = new DateTime(2022, 1, 1, 15, 30, 0) });
            carWasher.AddCar(new Car() { Model = "Audi R8", RegistrationDate = new DateTime(2022, 1, 1, 15, 0, 0) });
            carWasher.AddCar(new Car() { Model = "Citroen C4", RegistrationDate = new DateTime(2022, 1, 1, 16, 0, 0) });
            carWasher.MakeWashingService().Should().Be("Automatic washing of car Audi R8 has been performed with cold water and soap.\r\n" +
                                                            "Automatic washing of car Ford Mondeo has been performed with cold water and soap.\r\n" +
                                                            "Automatic washing of car Citroen C4 has been performed with cold water and soap.\r\n");
        }

        [Fact]
        public void Manual_washing_is_correct()
        {
            ICarWasher carWasher = CarWasherFactory.GetCarWasher(WashingTypes.Manual);
            var car = new Car() { Model = "Toyota Corolla", RegistrationDate = new DateTime(2022, 1, 1, 15, 30, 0) };
            var car2 = new Car() { Model = "Ford Mustang", RegistrationDate = new DateTime(2022, 1, 1, 15, 0, 0) };
            var car3 = new Car() { Model = "Dacia Sandero", RegistrationDate = new DateTime(2022, 1, 1, 16, 0, 0) };
            carWasher.AddCars(new List<ICar>() { car, car2, car3 });
            carWasher.MakeWashingService().Should().Be("Manual washing of car Ford Mustang has been performed with hot water and soap.\r\n" +
                                                            "Manual washing of car Toyota Corolla has been performed with hot water and soap.\r\n" +
                                                            "Manual washing of car Dacia Sandero has been performed with hot water and soap.\r\n");
        }
    }
}