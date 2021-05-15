using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimePolymorphism
{
	class Child:Parent
	{
        public void fun3()
        {
            Console.WriteLine("This is third function of the Child Class");
        }

        public void fun4()
        {
            Console.WriteLine("This is forth function of Child Class");
        }
    }
}
