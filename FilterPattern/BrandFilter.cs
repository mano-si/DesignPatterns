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
			return cars.Where(x => x.Brand == filterCriteria.Brand);
		}
    }
}
