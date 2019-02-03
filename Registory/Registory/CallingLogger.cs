using System;
using System.Collections.Generic;
using System.Text;

namespace Registory
{
    public class CallingLogger : ICallingLogger
    {
        private readonly ILogger _logger;

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
