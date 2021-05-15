using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameterExample
{
	class Demo
	{
		public static void Main(string[] args)
		{
			Sample s = new Sample();
			s.fun1(out float d, out float e, out float f);
			Console.WriteLine("Addition value =" + d);
			Console.WriteLine("Subtraction value =" + e);
			Console.WriteLine($"Multiplication value ={f}");
		}
	}
}
