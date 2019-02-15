using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainUse1
{
    public class LoggerRegistry : Registry
    {
        public LoggerRegistry()
        {
            ////REGISTRATIONS TYPES FOR().USE()

            //// 1. If you know the plugin type and its a closed type
            //// you can use this syntax
            //For<ICallingLogger>().Use<CallingLogger>();
            //For<ILogger>().Use<Logger>();
            //For.Use()
            //For<ILogger>().Use<Logger>();
            //For<ICallingLogger>().Use<CallingLogger>();

            ////2. By Lambda expressions
            //For<ICallingLogger>().Use(() => new CallingLogger());
            ////3. Pre existing object
            //For<ICallingLogger>().Use(new CallingLogger());
            ////4. Use Default
            //For<ICallingLogger>().Add<CallingLogger>().Named("A");
            //For<ICallingLogger>().Add<CallingLogger2>().Named("B");
            //For<ICallingLogger>().Use("A");

            ////REGISTRATION TYPE FOR().ADD()


        }
    }
}
