using NUnit.Framework;
using SAPB1_FrameWork.Core.Brokers.Logging;
using System;

namespace SAPB1_FrameWork.Core.Tests
{
    public class Core_Brokers_Logging
    {
        private Logger logger;

        [SetUp]
        public void Setup()
        {
            logger = new Logger();
        }

        [Test]
        public void Test1()
        {
            Assert.DoesNotThrow(()=>logger.Log("Probando el debugger"));
        }
    }
}