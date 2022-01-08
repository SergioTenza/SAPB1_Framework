using NUnit.Framework;
using SAPB1_FrameWork.Core.Brokers.ConnectionBroker;
using SAPB1_FrameWork.Core.Brokers.Logging;
using SAPB1_FrameWork.Core.Models.Exceptions;
using SAPB1_FrameWork.Core.Services.Connection;
using Xunit;

namespace SAPB1_FrameWork.Core.Tests
{
    public class Service_Connection_Tests
    {
        private Logger logger;
        private ConnectionBroker connectionBroker;
        private ConnectionService connectionService;

        [SetUp]
        public void Setup()
        {
            logger = new Logger();
            connectionBroker = new ConnectionBroker();
            connectionService = new ConnectionService(logger,connectionBroker);
        }

        
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("00000000000000000000")]
        [Test]
        public void CoreServicesConnectionRetrieveApplicationMustThrowExceptionConnectionServiceValidationException(string data)
        {
            //Given
            string connectionString = data;
            SAPbouiCOM.Application app = null;
            //That
            //Then
            Assert.Throws<ConnectionServiceValidationException>(() => app = connectionService.RetrieveApplication(connectionString));
        }
    }
}