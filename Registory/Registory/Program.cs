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
            //    .AddSingleton<ICallingLogger, CallingLogger>()
            //    .AddSingleton<ILogger, Logger>()
            //    .BuildServiceProvider();
            //var callingBar = service.GetService<ICallingLogger>();
            //callingBar.toLog();

            //NORMAL USING STRUCTURE MAPS
            //var container = new Container(_ =>
            // {
            //     _.For<ICallingLogger>().Add<CallingLogger>();
            //     _.For<ILogger>().Add<Logger>();
            // });
            //var callingLogger = container.GetInstance<ICallingLogger>();
            //callingLogger.toLog();

            //////REGISTORY DSL
            //var registry = new Registry();
            //registry.IncludeRegistry<LoggingRegistry>();
            //var container = new Container(registry);

            //var callingLogger = container.GetInstance<ICallingLogger>();
            //callingLogger.toLog();

            //////INLINE DEPENDENCIES
            //var container = new Container(x =>
            //    {
            //        x.For<IWidget>().Use<ColorWidget>()
            //        .Ctor<string>().Is("RED");
            //    });
            //var callingColorWIdget = container.GetInstance<IWidget>();
            //callingColorWIdget.color();

            //RESOLVING SERVICES
            ////1.GETTING SERVICES BY PLUGING TYPE
            //var container = new Container(x =>
            //    {
            //        x.For<ILogger>().Use<Logger>();
            //        x.For<ICallingLogger>().Use<CallingLogger>();
            //    }
            //);
            //var callingBar = container.GetInstance<ICallingLogger>();// 1. resolving services
            //callingBar.toLog();


            ////2.GETTING A SERVICE BY PLUGIN TYPE AND NAME
            //var container = new Container(x =>
            // {
            //     x.For<ICallingLogger>().Add<CallingLogger>().Named("A");
            //     x.For<ICallingLogger>().Add<CallingLogger2>().Named("B");
            //     x.For<ILogger>().Add<Logger>();
            // });
            //var callingbar = container.GetInstance<ICallingLogger>("B");

            //callingbar.toLog();

            //GET ALL SERVICE BY PLUGIN TYPE
           // var container = new Container(x =>
           //      {
           //          x.For<ICallingLogger>().Add<CallingLogger>().Named("A");
           //          x.For<ICallingLogger>().Add<CallingLogger2>().Named("B");
           //      });
           // var callingBar = container.GetAllInstances<ICallingLogger>();
           //callingBar.

            ////TRY GETTING OPTIONAL SERVICE BY PLUGIN TYPE
            //var container = new Container();
            //var foo = container.TryGetInstance<ILogger>()
            //    ?? new Logger();



            Console.ReadKey();

        }
    }
}