using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class LoggerRegistry : Registry
    {
        public LoggerRegistry()
        {
            //// FOR().ADD()
            //// 1. If you know the plugin type and its a closed type
            //// you can use this syntax
            //For<ICallingLogger>().Add<CallingLogger>();
            //For<ILogger>().Add<Logger>();

            ////FOR().USE()
            //For<ILogger>().Use<Logger>();
            //For<ICallingLogger>().Use<CallingLogger>();

            //// 2. By Lambda
            //For<ICallingLogger>().Add(() => new Bar());
            //// 3.  Pre-existing object
            //For<ICallingLogger>().Add(new Bar());
           
        }
    }
}
