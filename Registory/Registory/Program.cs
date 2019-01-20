using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Registory
{
    class Program
    {
        static void Main(string[] args)
        {
            //var service = new ServiceCollection()
            //    .AddSingleton<IBar, Bar>()
            //    .AddSingleton<IFoo, Foo>()
            //    .BuildServiceProvider();
            //var callingBar = service.GetService<IBar>();
            //callingBar.bar();

            // REGISTORY DSL
            //var registry=new Registry();
            //registry.IncludeRegistry<FooBarRegistry>();
            //var container = new Container(registry);

            //var callingBar = container.GetInstance<IBar>();

            //INLINE DEPENDENCIES
            //var container = new Container(x =>
            //    {
            //        x.For<IWidget>().Use<ColorWidget>()
            //        .Ctor<string>().Is("RED");
            //    });
            //var callingColorWIdget = container.GetInstance<IWidget>();
            //callingColorWIdget.color();

            //RESOLVING SERVICES
            //1. GETTING SERVICES BY PLUGING TYPE
            //var container = new Container(x =>
            //    {
            //        x.For<IBar>().Use<Bar>();
            //        x.For<IFoo>().Use<Foo>();
            //    }
            //);
            //var callingBar = container.GetInstance<IBar>();// 1. resolving services
            //callingBar.bar();


            //2.GETTING A SERVICE BY PLUGIN TYPE AND NAME
            //var container = new Container(x =>
            // {
            //     x.For<IBar>().Add<Bar>().Named("A");
            //     x.For<IBar>().Add<Bar2>().Named("B");
            // });
            //var callingbar=container.GetInstance<IBar>("B");

            //callingbar.bar();

            //GET ALL SERVICE BY PLUGIN TYPE
            //var container = new Container(x =>
            //     {
            //         x.For<IBar>().Add<Bar>().Named("A");
            //         x.For<IBar>().Add<Bar2>().Named("B");
            //     });
            //var callingBar=container.GetAllInstances<IBar>();
            //callingBar.bar();

            //TRY GETTING OPTIONAL SERVICE BY PLUGIN TYPE
            var container = new Container();
            var foo = container.TryGetInstance<IFoo>()
                ?? new Foo();
                
        
        
            Console.ReadKey();

        }
    }
}
