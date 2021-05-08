using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Static_Method_with_Return_Type
{
	class Demo
	{
		public static void Main(string[] args)
		{
			Sample s = new Sample();
			int f = s.fun1();
			Console.WriteLine("ID of the person..." + f);
			string h = s.fun2();
			Console.WriteLine("Name of the person..." + h);
		}
	}
}
