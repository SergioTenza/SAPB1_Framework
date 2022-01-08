using NUnit.Framework;
using SAPB1_FrameWork.Core.Brokers.ConnectionBroker;
using SAPB1_FrameWork.Core.Brokers.Logging;
using SAPB1_FrameWork.Core.Models.Exceptions;
using SAPB1_FrameWork.Core.Services.Connection;

namespace SAPB1_FrameWork.Core.Tests
{
    public class ConnectionServiceTests
    {
        private Logger logger;
        private ConnectionBroker connectionBroker;
        private ConnectionService connectionService;

        [SetUp]
        public void Setup()
        {
            logger = new Logger();
            connectionBroker = new ConnectionBroker();
            connectionService = new ConnectionService(logger, connectionBroker);
            //0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056
        }


        [TestCase("")]
        [TestCase(" ")]
        [TestCase("00000000000000000000")]
        [Test]
        public void CoreServicesConnectionServiceRetrieveApplicationMustThrowExceptionConnectionServiceValidationException(string data)
        {
            //Given
            string connectionString = data;
            SAPbouiCOM.Application app;
            //That
            //Then
            Assert.Throws<ConnectionServiceValidationException>(() => app = connectionService.RetrieveApplication(connectionString));
        }

        [TestCase("0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056")]
        [Test]
        public void CoreServicesConnectionServiceRetrieveApplicationMustThrowConnectionServiceInterOpComExceptionOnNoSAPCLientRunning(string data)
        {
            //Given
            string connectionString = data;
            SAPbouiCOM.Application app;
            //That
            //Then
            Assert.Throws<ConnectionServiceInterOpComException>(() => app = connectionService.RetrieveApplication(connectionString));
        }

        [Test]
        public void CoreServicesConnectionServiceRetrieveApplicationMustThrowConnectionServiceInvalidApplicationOnServiceNullApplication()
        {
            //Given
            SAPbouiCOM.Application app;
            //That
            //Then
            Assert.Throws<ConnectionServiceInvalidApplicationException>(() => app = connectionService.GetCurrentApplication());
        }

        [Test]
        public void CoreServicesConnectionServiceRetrieveCompanyMustThrowConnectionServiceInvalidApplicationOnServiceNullApplication()
        {
            //Given
            SAPbobsCOM.Company company;
            //That
            //Then
            Assert.Throws<ConnectionServiceInvalidApplicationException>(() => company = connectionService.GetCurrentCompany());
        }
    }
}