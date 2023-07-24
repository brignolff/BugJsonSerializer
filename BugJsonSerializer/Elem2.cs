using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BugJsonSerializer
{
	[DataContract]
	public class Elem2 : Elem
	{
		[DataMember]
		public PropB propB;

		public Elem2()
		{
			propB = new(this);
		}
	}
}
