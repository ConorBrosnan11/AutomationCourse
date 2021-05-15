using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
    public class Demo1
    {
        public Demo1(int i, string s)
        {
            Console.WriteLine("Employer ID=" + i);
            Console.WriteLine("Employer Name=" + s);
        }

        public void fun()
        {
            Console.WriteLine("This is the first function");
        }
    }
}
