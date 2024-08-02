namespace HW2
{
	public class Circle : Shape
	{
		public override void Move(int deltaX, int deltaY)
		{
			Console.WriteLine($"Перемiщення кола на X+{deltaX}, Y+{deltaY}");
		}
	}
}
