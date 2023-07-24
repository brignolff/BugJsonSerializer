using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugJsonSerializer
{
	public class Elem1 : Elem
	{
		public PropA propA;

		public Elem1()
		{
			propA = new(this);
		}
	}
}
