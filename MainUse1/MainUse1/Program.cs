
using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using System;

namespace MainUse1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // //1.EXAMPLE USING DI
            // var service = new ServiceCollection()
            //     .AddSingleton<ILogger, Logger>()
            //     .AddSingleton<ICallingLogger, CallingLogger>()
            //     .BuildServiceProvider();

            // var callingLogger = service.GetService<ICallingLogger>();
            // callingLogger.toLog();

            // //2.EXAMPLE USING STRUCTURE MAP CONTAINERS
            var container = new Container(x =>
              {
                  x.For<ICallingLogger>().Use<CallingLogger>();
                  x.For<ILogger>().Use<Logger>();
              });
            var callingLogger = container.GetInstance<ICallingLogger>();
            callingLogger.toLog();

            //// 3.EXAMPLE USING CONTAINERS REGISTORY
            //var container = new Container(x =>
            //          {
            //              x.AddRegistry<FooBarRegistry>();
            //          }
            //    );
            // var callingLogger = container.GetInstance<ICallingLogger>();
            // callingLogger.toLog();

            // //OR
            // var container = new Container(new FooBarRegistry());
            // var callingLogger = container.GetInstance<ICallingLogger>();
            // callingLogger.toLog();

            //// OR
            // var conatiner = Container.For<FooBarRegistry>();
            // var callingLogger = conatiner.GetInstance<ICallingLogger>();
            // callingLogger.toLog();

            // //4.USING SCANNER(CONVENCTIONS)
            // var container = new Container(x =>
            //       x.Scan(scanner =>
            //       {
            //           scanner.TheCallingAssembly();
            //           scanner.WithDefaultConventions();
            //       }));

            // var callingLogger = container.GetInstance<ICallingLogger>();
            // callingLogger.toLog();

            // //OR

            // var container = new Container();
            // container.Configure(x =>
            //         x.Scan(scanner =>
            //             {
            //                 scanner.TheCallingAssembly();
            //                 scanner.WithDefaultConventions();
            //             }


            //         ));
            // var callingLogger = container.GetInstance<ICallingLogger>();
            // callingLogger.toLog();


            // //INCLUDING REGISTRIES
            // var registry = new Registry();
            // registry.IncludeRegistry<FooBarRegistry>();
            // var container = new Container(registry);
            // var callingLogger = container.GetInstance<ICallingLogger>();
            // callingLogger.toLog();


            Console.ReadKey();
        }
    }
}
