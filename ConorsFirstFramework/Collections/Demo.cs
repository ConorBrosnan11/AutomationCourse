using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Demo
    {
		static void Main(string[] args)
		{
			ArrayList a = new ArrayList();
			a.Add("Conor");
			a.Add("Brosnan");
			a.Add(34);
			a.Add(true);
			a.Add(34.5f);
			foreach (var i in a)
			{
				Console.WriteLine(i);
			}
		}
    }
}
