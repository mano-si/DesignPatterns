#region using directives
using System.Collections.Generic;
using System.Linq;
#endregion

namespace FilterPattern
{
	public class ColorFilter : IFilter
	{
		public IEnumerable<Car> Filter(IEnumerable<Car> cars, FilterCriteria filterCriteria)
		{
			if (filterCriteria.Colors.Any())
				return cars.Where(x => filterCriteria.Colors.Contains(x.Color));

            return cars;
		}
	}
}