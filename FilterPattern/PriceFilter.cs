#region using directives
using System.Collections.Generic;
using System.Linq;
#endregion

namespace FilterPattern
{
	public class PriceFilter : IFilter
    {      
        public IEnumerable<Car> Filter(IEnumerable<Car> cars, FilterCriteria filterCriteria)
        {
			return cars.Where(x => x.Price >= filterCriteria.StartPrice && x.Price <= filterCriteria.EndPrice);
        }
    }
}
