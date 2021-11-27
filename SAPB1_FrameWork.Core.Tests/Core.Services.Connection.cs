using NUnit.Framework;
using SAPB1_FrameWork.Core.Brokers.ConnectionBroker;
using SAPB1_FrameWork.Core.Brokers.Logging;
using SAPB1_FrameWork.Core.Services.Connection;

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

        [Test]
        public void CoreServicesConnectionRetrieveApplicationMustNotThrowException()
        {
            //Given
            string connectionString = "00000000000000000000";
            SAPbouiCOM.Application app = null;
            //That
            //Then
            Assert.DoesNotThrow(() => app = connectionService.RetrieveApplication(connectionString));
        }
    }
}