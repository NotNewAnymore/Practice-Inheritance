using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
	internal class Land : Vehicle
	{
		int wheels;
		public Land(int Wheels, string color) : base(color)
		{
			wheels = Wheels;
		}

		public override string ToString()
		{
			return base.ToString() + $" With {wheels} wheels";
		}
	}
}
