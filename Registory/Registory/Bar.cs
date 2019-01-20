using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class Bar : IBar
    {
        private readonly IFoo _foo;

        public Bar(IFoo foo)
        {
            _foo = foo;
        }

        public void bar()
        {
            _foo.foo();
        }
    }
}
