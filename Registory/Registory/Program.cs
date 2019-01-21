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
            //var container = new Container();
            //var foo = container.TryGetInstance<IFoo>()
            //    ?? new Foo();

            //              CONTAINER
            //1. CHILD CONTAINERS
            // var parentContainer = new Container(x =>
            //      {
            //          x.For<IBar>().Use<Bar>();
            //          x.For<IFoo>().Use<Foo>();
            //      });
            // var childContainer = parentContainer.CreateChildContainer();
            // childContainer.Configure(x =>
            //{
            //    x.For<IBar>().Use<Bar2>();
            //});
            // var callingBar = childContainer.GetInstance<IBar>();
            // callingBar.bar();
            // 2. PROFILES
            //IContainer container = new Container(registry =>
            //  {
            //      registry.Profile("Something", p =>
            //      {
            //          p.For<IBar>().Use<Bar>();
            //          p.For<IFoo>().Use<Foo>();
            //      });

            //  });
            //var profile = container.GetProfile("Something");
            //var callingBar = profile.GetInstance<IBar>();
            //callingBar.bar();
            //3.CHILD CONTAINER AND SINGLETON

            //var parentContainer = new Container(_ =>
            //{
            //    _.For<IBar>().Use<Bar>();
            //    _.For<IFoo>().Use<Foo>();

            //});
            //var child1 = parentContainer.CreateChildContainer();
            //child1.Configure(x =>
            //{
            //    x.ForSingletonOf<IBar>().Use<Bar>();
            //});
            //var child2 = parentContainer.CreateChildContainer();
            //child2.Configure(x =>
            //{
            //    x.ForSingletonOf<IBar>().Use<Bar2>();
            //});
            //var callingViaChild1=child1.GetInstance<IBar>();
            //callingViaChild1.bar();

            //var callingViaChild2 = child2.GetInstance<IBar>();
            //callingViaChild2.bar();
            //4. CREATING A NESTED CONTAINER FROM A CHILD CONTAINER
            //var parentContainer = new Container(_ =>
            // {
            //     _.For<IBar>().Use<Bar>();
            //     _.For<IFoo>().Use<Foo>();

            // });
            //var childContainer1 = parentContainer.CreateChildContainer();
            //childContainer1.Configure(_ =>
            //{
            //    _.For<IBar>().Use<Bar2>();
            //});
            //using (var nested = childContainer1.GetNestedContainer())
            //{
            //    var callingBar = nested.GetInstance<IBar>();
            //    callingBar.bar();
            //}
            //      NESTED CONTAINERS (PER REQUEST/TRANSACTIONS)
            //1. CREATION
            var container = new Container(_ =>
              {
                  _.For<IBar>().Use<Bar>();
                  _.For<IFoo>().Use<Foo>();
              });
            using (var nested = container.GetNestedContainer())
            {
                var worker = nested.GetInstance<IBar>();
                worker.bar();
            }


                Console.ReadKey();

        }
    }
}
