using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method_with_Return_Type
{
	class Demo
	{
		static void Main(string[] args)
		{
			int i = Sample.function1();
			Console.WriteLine("ID of the person " + i);
			string s = Sample.function2();
			Console.WriteLine("Name of the person " + s);
			int p = Sample.function3();
			Console.WriteLine(p);
		}
	}
}
