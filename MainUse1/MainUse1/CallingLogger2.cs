using System;
using System.Collections.Generic;
using System.Text;

namespace MainUse1
{
    public class CallingLogger2 : ICallingLogger
    {
        private ILogger _logger;

        public CallingLogger2(ILogger logger)
        {
            _logger = logger;
        }

        public void toLog()
        {
            _logger.implimenting_logging();
        }
    }
}
