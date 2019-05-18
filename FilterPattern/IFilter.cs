using System.Collections.Generic;

namespace FilterPattern
{
    public interface IFilter
    {
		IEnumerable<Car> Filter(IEnumerable<Car> Cars, FilterCriteria filterCriteria);
    }
}