using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class FooBarRegistry : Registry
    {
        public FooBarRegistry()
        {
            // FOR().ADD()
            // 1. If you know the plugin type and its a closed type
            // you can use this syntax
            //For<IBar>().Add<Bar>();
            //For<IFoo>().Add<Foo>();

            // 2. By Lambda
            //For<IBar>().Add(() => new Bar());

            // 3.  Pre-existing object
            //For<IBar>().Add(new Bar());

                
        }
    }
}
