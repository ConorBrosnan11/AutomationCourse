using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseARelationship
{
	class Sample
	{
		static void Main(string[] args)
		{
			Demo1 s1 = new Demo1();
			Demo2 c = new Demo2();

			c.fun3(s1);
		}
	}
}
