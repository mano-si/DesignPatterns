using System.Collections.Generic;

namespace FilterPattern
{
    public class FilterCriteria
    {
		public List<Brand> Brands { get; set; }

		public double StartPrice { get; set; }
        
		public double EndPrice { get; set; }
        
		public List<Color> Colors { get; set; }
    }
}
