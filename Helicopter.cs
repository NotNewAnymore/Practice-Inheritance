using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
	internal class Helicopter : Air
	{
		int _numProps;

		public Helicopter(int numProps,string color) : base(color)
		{
			_numProps = numProps;
		}
		public override string ToString()
		{
			return base.ToString() + $" {_numProps} propellers";
		}
	}
}
