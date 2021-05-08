using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method_with_Return_Type
{
    public class Sample
    {
        static int i = 10;
        static int j = 20;
        static string s = "Conor";
        public static int function1()
        {
            return i;
        }
        public static string function2()
        {
            return s;
        }
        public static int function3()
        {
            int p = i + j;
            return p;
        }
    }
}
