namespace Models
{
	public class Circle : object
	{
		//public Circle() : base()
		//{
		//}

		public Circle(int x, int y, int radius) : base()
		{
			X = x;
			Y = y;
			Radius = radius;
		}

		public int X { get; set; }

		public int Y { get; set; }

		public int Radius { get; set; }

		public int BorderWidth { get; set; }

		public string BorderColor { get; set; }
	}
}
