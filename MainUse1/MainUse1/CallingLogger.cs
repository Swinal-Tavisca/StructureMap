using System;
using System.Collections.Generic;
using System.Text;

namespace MainUse1
{
    public class CallingLogger : ICallingLogger
    {
        private ILogger _logger;

        public CallingLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void toLog()
        {
            _logger.implimenting_logging();
            
        }
    }
}
