namespace FilterPattern
{
	public class Car
	{
		public Brand Brand { get; set; }

		public string ModelName { get; set; }

		public double Price { get; set; }

		public int ModelNumber { get; set; }

		public Color Color { get; set; }

		public Specification Specification { get; set; }

		public override string ToString()
		{
			return Brand.ToString() + " - " + ModelName + ", Color : " + Color.ToString() + ", Price : Rs." + Price;
		}
	}
}
