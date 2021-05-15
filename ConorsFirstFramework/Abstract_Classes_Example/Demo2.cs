using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Example
{
	class Demo2:Demo1
	{
		public override void fun1()
		{
			Console.WriteLine("This is first Function");
		}

		public override void fun3()
		{
			Console.WriteLine("This is third Function");
		}
	}
}
