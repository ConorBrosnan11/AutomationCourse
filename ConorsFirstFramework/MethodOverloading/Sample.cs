using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Sample
    {
        public void function1(int i)
        {
            Console.WriteLine("ID of ther person==" + i);
        }

        public void function1(string s)
        {
            Console.WriteLine("Name of the person==" + s);
        }

        public void function1(int i, string s)
        {
            Console.WriteLine("ID of ther person==" + i);

            Console.WriteLine("Name of the person==" + s);
        }
    }
}
