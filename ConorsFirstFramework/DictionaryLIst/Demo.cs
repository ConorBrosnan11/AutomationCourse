using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLIst
{
    public class Demo
    {
		static void Main(string[] args)
		{
			Dictionary<string, object> d = new Dictionary<string, object>();
			d.Add("Employee Name", "Conor Brosnan");
			d.Add("Employee Number", 23423);
			d.Add("Employee Company", "TestZenLabs");
			d.Add("Employee Phone", "123456790");
			foreach (string key in d.Keys)
				Console.WriteLine(key + ":" + d[key]);
		}
    }
}
