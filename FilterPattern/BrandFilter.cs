#region using directives
using System.Collections.Generic;
using System.Linq;
#endregion

namespace FilterPattern
{
	public class BrandFilter : IFilter
    {
		public IEnumerable<Car> Filter(IEnumerable<Car> cars, FilterCriteria filterCriteria)
		{         
			if(filterCriteria.Brands.Any())
				return cars.Where(x => filterCriteria.Brands.Contains(x.Brand));

			return cars;
		}
    }
}
