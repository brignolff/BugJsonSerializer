using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BugJsonSerializer
{
	[DataContract]
	public class PropA
	{
		[DataMember]
		PropB? propertyB;

		
		public PropB? PropertyB
		{
			get => propertyB;
			set {
				propertyB = value;

				if (PropertyB != null)
				{
					PropertyB.PropertyA = this;
				}
			}
		}

		[DataMember]
		public Elem Parent { get; set; }

		public PropA(Elem parent) 
		{
			Parent = parent;
		}
	}
}
