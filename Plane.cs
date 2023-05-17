using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
	internal class Plane : Air
	{
		int numJets;

		public Plane(int numJets,string color) : base(color)
		{
			this.numJets = numJets;
		}

		public override string ToString()
		{
			return base.ToString() + $" {numJets} engines";
		}
	}
}
