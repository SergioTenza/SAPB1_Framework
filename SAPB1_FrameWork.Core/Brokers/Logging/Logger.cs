using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Brokers.Logging
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Debug.Write($"Evento del sistema {message}");
        }
    }
}
