#region using directives
using System.Collections.Generic;

using FilterPattern;
#endregion

namespace MainApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			DemoFilterPattern();
        }

		private static void DemoFilterPattern()
		{
			IEnumerable<Car> cars = CarFactory.MakeSomeCars();

			DisplayCars(cars);
            
			FilterCriteria filterCriteria = new FilterCriteria()
			{
				Brands = new List<Brand>(){ Brand.Hyundai, Brand.Ford},
				Colors = new List<Color>(){ Color.Black },
				StartPrice = 500000,
				EndPrice = 1000000
              
			};

			IFilter filter;

			filter = new BrandFilter();         
			System.Console.WriteLine("Applying brand filter...");
			cars = filter.Filter(cars, filterCriteria);                  
			DisplayCars(cars);
            
			filter = new ColorFilter();         
            System.Console.WriteLine("Applying color filter...");
            cars = filter.Filter(cars, filterCriteria);
            DisplayCars(cars);

			filter = new PriceFilter();
            System.Console.WriteLine("Applying price filter...");
            cars = filter.Filter(cars, filterCriteria);
            DisplayCars(cars);         
		}

		private static void DisplayCars(IEnumerable<Car> cars)
		{
			foreach (Car car in cars)
			{
				System.Console.WriteLine(car.ToString());
			}
		}
    }
}
