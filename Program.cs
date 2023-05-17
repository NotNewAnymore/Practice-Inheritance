namespace Practice_Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Vehicle> vehicles = new List<Vehicle>();
			Vehicle v1 = new Vehicle("Dark Cyan");
			vehicles.Add(v1);
			
			Land v2 = new Land(5,"Off White");
			
			vehicles.Add(v2);
			Sea v3 = new Sea("Submarine","Sky Gray");
			
			vehicles.Add(v3);
			Air v4 = new Air("Green");
			
			vehicles.Add(v4);
			Plane v5 = new Plane(12,"Metal");

			vehicles.Add(v5);
			Helicopter v6 = new Helicopter(2,"Red");
			vehicles.Add(v6);
			foreach(Vehicle v in vehicles)
			{
				Console.WriteLine(v);
			}

		}
	}
}