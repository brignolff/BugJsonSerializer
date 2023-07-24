using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugJsonSerializer
{
	public class Elem2 : Elem
	{
		public PropB propB;

		public Elem2()
		{
			propB = new(this);
		}
	}
}
