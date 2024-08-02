namespace HW2
{
	public class Rectangle : Shape
	{
		public override void Move(int deltaX, int deltaY)
		{
            Console.WriteLine($"Перемiщення прямокутника на X+{deltaX}, Y+{deltaY}");
        }

		public void Resize(Vector newEndpoint)
		{
            Console.WriteLine($"Довижну прямокутника зміщено на {newEndpoint.X}, висоту прямокутника зміщено на {newEndpoint.Y}");
        }
	}
}
