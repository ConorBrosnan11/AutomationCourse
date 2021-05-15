using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimePolymorphism
{
    public class Parent
    {
        public virtual void fun1()
        {
            Console.WriteLine("This is the first function of Parent Class");
        }

        public virtual void fun2()
        {
            Console.WriteLine("This is the second function of the Parent Class");
        }
    }
}
