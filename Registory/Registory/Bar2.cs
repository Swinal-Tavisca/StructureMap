using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class Bar2 : IBar
    {
        private readonly IFoo _foo;

        public Bar2(IFoo foo)
        {
            _foo = foo;
        }

        public void bar()
        {
            _foo.foo();
        }
    }
}
