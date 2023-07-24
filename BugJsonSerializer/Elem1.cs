using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BugJsonSerializer
{
	[DataContract]
	public class Elem1 : Elem
	{
		[DataMember]
		public PropA propA;

		public Elem1()
		{
			propA = new(this);
		}
	}
}
