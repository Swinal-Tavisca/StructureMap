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
            //Using DI
            // var service = new ServiceCollection()
            //     .AddSingleton<ICallingLogger, CallingLogger>()
            //     .AddSingleton<ILogger, Logger>()
            //     .BuildServiceProvider();
            // var callingLogger = service.GetService<ICallingLogger>();
            // callingLogger.bar();

            // //REGISTORY DSL
            //var registry = new Registry();
            //registry.IncludeRegistry<LoggerRegistry>();
            //var container = new Container(registry);

            //var callingLogger = container.GetInstance<ICallingLogger>();
            //callingLogger.toLog();

            // //INLINE DEPENDENCIES
            // var container = new Container(x =>
            //     {
            //         x.For<IWidget>().Use<ColorWidget>()
            //         .Ctor<string>().Is("RED");
            //     });
            // var callingColorWIdget = container.GetInstance<IWidget>();
            // callingColorWIdget.color();

            
            // //RESOLVING SERVICES
            // //1.GETTING SERVICES BY PLUGING TYPE
            // var container = new Container(x =>
            //     {
            //         x.For<ICallingLogger>().Use<CallingLogger>();
            //         x.For<ILogger>().Use<Logger>();
            //     }
            // );
            // var callingLogger = container.GetInstance<ICallingLogger>();// 1. resolving services
            // callingLogger.bar();


            // //2.GETTING A SERVICE BY PLUGIN TYPE AND NAME
            // var container = new Container(x =>
            //  {
            //      x.For<ICallingLogger>().Add<CallingLogger>().Named("A");
            //      x.For<ICallingLogger>().Add<CallingLogger2>().Named("B");
            //  });
            // var callingLogger = container.GetInstance<ICallingLogger>("B");

            // callingLogger.bar();

            // //GET ALL SERVICE BY PLUGIN TYPE
            // var container = new Container(x =>
            //      {
            //          x.For<ICallingLogger>().Add<CallingLogger>().Named("A");
            //          x.For<ICallingLogger>().Add<CallingLogger2>().Named("B");
            //      });
            // var callingLogger = container.GetAllInstances<ICallingLogger>();
            // callingLogger.bar();

            // //TRY GETTING OPTIONAL SERVICE BY PLUGIN TYPE
            // var container = new Container();
            // var callingLogger = container.TryGetInstance<ILogger>()
            //     ?? new Logger();


            //********//CONTAINER\\***********\\
            // //1.CHILD CONTAINERS
            // var parentContainer = new Container(x =>
            //      {
            //          x.For<ICallingLogger>().Use<CallingLogger>();
            //          x.For<ILogger>().Use<Logger>();
            //      });
            // var childContainer = parentContainer.CreateChildContainer();
            // childContainer.Configure(x =>
            //{
            //    x.For<ICallingLogger>().Use<CallingLogger2>();
            //});
            // var callingLogger = childContainer.GetInstance<ICallingLogger>();
            // callingLogger.bar();
            // //2.PROFILES
            // IContainer container = new Container(registry =>
            //   {
            //       registry.Profile("Something", p =>
            //       {
            //           p.For<ICallingLogger>().Use<CallingLogger>();
            //           p.For<ILogger>().Use<Logger>();
            //       });

            //   });
            // var profile = container.GetProfile("Something");
            // var callingLogger = profile.GetInstance<ICallingLogger>();
            // callingLogger.bar();
            // //3.CHILD CONTAINER AND SINGLETON

            // var parentContainer = new Container(_ =>
            // {
            //     _.For<ICallingLogger>().Use<CallingLogger>();
            //     _.For<ILogger>().Use<Logger>();

            // });
            // var child1 = parentContainer.CreateChildContainer();
            // child1.Configure(x =>
            // {
            //     x.ForSingletonOf<ICallingLogger>().Use<CallingLogger>();
            // });
            // var child2 = parentContainer.CreateChildContainer();
            // child2.Configure(x =>
            // {
            //     x.ForSingletonOf<ICallingLogger>().Use<CallingLogger2>();
            // });
            // var callingViaChild1 = child1.GetInstance<ICallingLogger>();
            // callingViaChild1.bar();

            // var callingViaChild2 = child2.GetInstance<ICallingLogger>();
            // callingViaChild2.bar();
            // //4.CREATING A NESTED CONTAINER FROM A CHILD CONTAINER
            //var parentContainer = new Container(_ =>
            // {
            //     _.For<ICallingLogger>().Use<CallingLogger>();
            //     _.For<ILogger>().Use<Logger>();

            // });
            // var childContainer1 = parentContainer.CreateChildContainer();
            // childContainer1.Configure(_ =>
            // {
            //     _.For<ICallingLogger>().Use<CallingLogger2>();
            // });
            // using (var nested = childContainer1.GetNestedContainer())
            // {
            //     var callingLogger = nested.GetInstance<ICallingLogger>();
            //     callingLogger.bar();
            // }
            // //NESTED CONTAINERS(PER REQUEST/ TRANSACTIONS)
            // //1.CREATION
            // var container = new Container(_ =>
            //   {
            //       _.For<ICallingLogger>().Use<CallingLogger>();
            //       _.For<ILogger>().Use<Logger>();
            //   });
            // using (var nested = container.GetNestedContainer())
            // {
            //     var worker = nested.GetInstance<ICallingLogger>();
            //     worker.bar();
            // };
            // //USING TRANSIENT AND NESTED CONTAINERS
            // var container = new Container(_ =>
            // {
            //     _.For<ICallingLogger>().Use<CallingLogger>();
            //     _.For<ILogger>().Use<Logger>();
            // });
            // //var callingLogger = container.GetInstance<IBar>();//instance is build on every request
            // //callingLogger.bar();
            // //^ Same container {using nested containers so trainsient lifecycle is created using nested containers}
            // using (var nested = container.GetNestedContainer())
            // {
            //     var callingLogger = nested.GetInstance<ICallingLogger>();
            //     callingLogger.bar();
            // }

            // //USING SINGLETON
            // var container = new Container(_ =>
            //   {
            //       _.ForSingletonOf<ICallingLogger>().Use<CallingLogger>();
            //       _.ForSingletonOf<ILogger>().Use<Logger>();

            //   });
            // //var singletoncallingLogger = container.GetInstance<IBar>();
            // //singletoncallingLogger.bar();
            // ///^ same container for nested singleton lifecycle
            // using (var nested = container.GetNestedContainer())
            // {
            //     var singletoncallingLogger = container.GetInstance<ICallingLogger>();
            //     singletoncallingLogger.bar();
            // }


            // //OBJECT LIFECYCLE
            // //1.TRANSIENT
            // var container = new Container(_ =>
            //   {
            //       _.For<ICallingLogger>().Use<CallingLogger>().Transient();
            //       _.For<ILogger>().Use<Logger>().Transient();
            //   });
            // var callingLogger = container.GetInstance<ICallingLogger>();
            // callingLogger.bar();

            //// 2.ALWAYS UNIQUE
            //var container = new Container(_ =>
            //  {
            //      _.For<ICallingLogger>().Use<CallingLogger>().AlwaysUnique();
            //      _.For<ILogger>().Use<Logger>().AlwaysUnique();
            //  });
            // var callingLogger = container.GetInstance<ICallingLogger>();
            // callingLogger.bar();

            // //3.SINGLETON
            // var conatiner = new Container(_ =>
            //   {
            //       _.ForSingletonOf<>

            //   })

            Console.ReadKey();

        }
    }
}
