using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public interface ILogger
    {
        public void LogInfo(string message);
        public void LogError(string message);
    }
}
