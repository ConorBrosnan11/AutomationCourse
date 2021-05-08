using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Demo
	{
		static void Main(string[] args)
		{
			List<string> a = new List<string>();
			a.Add("Conor");
			a.Add("Brosnan");
			a.Add("Sinead");
			a.Add("Test");
			a.Add("ZenLabs");
			foreach (var i in a)
			{
				Console.WriteLine(i);
			}
		}

    }
}
