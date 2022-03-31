using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    static class Extension 
    {
        public static int Power(this int a)
        {
            return a*a;
        }
    }
}
