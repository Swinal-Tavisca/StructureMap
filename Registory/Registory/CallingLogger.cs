using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class CallingLogger : ICallingLogger
    {
        private readonly ILogger _callingLogger;

        public CallingLogger(ILogger callingLogger)
        {
            _callingLogger = callingLogger;
        }

        public void toLog()
        {
            _callingLogger.implimenting_logging();
        }
    }
}
