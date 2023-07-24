using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugJsonSerializer
{
	public class Config
	{
		public Elem1 elem1 { get; set; }
		public Elem2 elem2 { get; set; }
		public Elem2 elem3 { get; set; }
		public Elem1 elem4 { get; set; }

		public Config() 
		{
			elem1 = new Elem1();
			elem2 = new Elem2();
			elem3 = new();
			elem4 = new();
		}
	}
}
