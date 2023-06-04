using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class ConsoleLogger : ILogger
    {
        void ILogger.LogError(string message)
        {
            throw new NotImplementedException();
        }

        void ILogger.LogInfo(string message)
        {
            throw new NotImplementedException();
        }
    }
}
