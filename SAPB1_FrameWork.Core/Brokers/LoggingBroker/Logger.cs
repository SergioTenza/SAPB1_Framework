// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------
using System.Diagnostics;

namespace SAPB1_FrameWork.Core.Brokers.LoggingBroker
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Debug.Write($"Evento del sistema {message}");
        }
    }
}
