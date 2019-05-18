#region using directives
using System.Collections.Generic;
using System.Linq;
#endregion

namespace FilterPattern
{
	public class ColorFilter : IFilter
	{
		public IEnumerable<Car> Filter(IEnumerable<Car> Cars, FilterCriteria filterCriteria)
		{
			return Cars.Where(x => x.Color == filterCriteria.Color);
		}
	}
}