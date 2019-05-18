#region using directives
using System.Collections.Generic;

using FilterPattern;
#endregion

namespace MainApp
{
    public static class CarFactory
    {
		public static List<Car> MakeSomeCars()
		{
			List<Car> cars = new List<Car>();

            Car car_1 = new Car()
            {
				Brand = Brand.Hyundai,
                Color = Color.Black,
                Price = 500000,
                ModelName = "i10",
				ModelNumber = 1234,
                Specification = new Specification()
                {
                    EngineDisplacement = 1000,
                    FuelCapacity = 20,
                    Mileage = 15
                }
            };

			cars.Add(car_1);         

            Car car_2 = new Car()
            {
				Brand = Brand.Hyundai,
				Color = Color.Blue,
                Price = 900000,
                ModelName = "Accent",
                ModelNumber = 2233,
                Specification = new Specification()
                {
                    EngineDisplacement = 1200,
                    FuelCapacity = 20,
                    Mileage = 12
                }
            };

            cars.Add(car_2);         

            Car car_3 = new Car()
            {
				Brand = Brand.Mercedez,
				Color = Color.Red,
                Price = 2500000,
                ModelName = "c-class",
                ModelNumber = 890,
                Specification = new Specification()
                {
                    EngineDisplacement = 2500,
                    FuelCapacity = 30,
                    Mileage = 8
                }
            };

            cars.Add(car_3);         

            Car car_4 = new Car()
            {
				Brand = Brand.Ford,
				Color = Color.White,
                Price = 800000,
                ModelName = "Figo",
                ModelNumber = 1212,
                Specification = new Specification()
                {
                    EngineDisplacement = 1350,
                    FuelCapacity = 22,
                    Mileage = 18
                }
            };

            cars.Add(car_4);

			return cars;
		}
    }
}
