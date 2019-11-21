#region using directives
using System.Collections.Generic;

using FilterPattern;
using StrategyPattern;
#endregion

namespace MainApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //DemoFilterPattern();
            //DemoStrategyPattern();
        }

        #region FilterPattern
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
        #endregion

        #region StrategyPattern
        private static void DemoStrategyPattern()
        {
            // Create a generic character with basic moves
            Character character = new Character();
            character.Attack();
            character.SpecialMove();

            // Change moves strategy to superman
            character.SetCharacterMoveStrategy(new SupermanMoves());
            character.Attack();
            character.SpecialMove();

            // Change moves strategy to batman
            character.SetCharacterMoveStrategy(new BatmanMoves());
            character.Attack();
            character.Defend();

            // Change moves strategy to antman
            character.SetCharacterMoveStrategy(new BatmanMoves());
            character.Attack();
            character.Defend();
            character.SpecialMove();
        }
        #endregion
    }
}
