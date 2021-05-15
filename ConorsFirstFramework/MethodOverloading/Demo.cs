using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
	public class Demo
	{
		static void Main(string[] args)
		{
			Sample s = new Sample();

			s.function1(1);
			s.function1("Conor Brosnan");
			s.function1(4, "gititi");
		}

	}
}
