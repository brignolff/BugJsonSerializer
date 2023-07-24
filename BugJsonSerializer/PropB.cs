using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BugJsonSerializer
{
	public class PropB
	{
		[DataMember]
		public PropA? PropertyA { get; set; }

		[DataMember]
		public Elem Parent { get; set; }

		public PropB(Elem parent)
		{
			Parent = parent;
		}
	}
}
