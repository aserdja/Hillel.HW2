namespace HW2
{
	public struct Vector
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Vector(double x, double y, double x2, double y2)
		{
			this.X = x2 - x;
			this.Y = y2 - y;
		}

		public void CalculateLength()
		{
            double vectorLength = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
			Console.WriteLine($"Довжина вектора: {vectorLength}");
        }
	}
}
