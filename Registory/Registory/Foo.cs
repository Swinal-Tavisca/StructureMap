using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class Foo : IFoo
    {
        public void foo()
        {
            Console.WriteLine("INSIDE FOO");
        }
    }
}
