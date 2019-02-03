using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class LoggingRegistry : Registry
    {
        public LoggingRegistry()
        {
            //// FOR().ADD()
            //// 1. If you know the plugin type and its a closed type
            //// you can use this syntax
            For<ICallingLogger>().Add<CallingLogger>();
            For<ILogger>().Add<Logger>();

            //// 2. By Lambda
            //For<ICallingLogger>().Add(() => new CallingLogger());
            //For<ILogger>().Add(() => new Logger());

            //// 3.  Pre-existing object
            //For<ICallingLogger>().Add(new CallingLogger());
            //For<ILogger>().Add(new Logger());

        }
    }
}
