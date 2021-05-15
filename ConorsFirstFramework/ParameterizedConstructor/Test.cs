using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
	class Test
	{
		static void Main(string[] args)
		{
			Demo1 d = new Demo1(45, "conor");
			d.fun();
		}
	}
}
