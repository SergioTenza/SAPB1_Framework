// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------
using NUnit.Framework;
using SAPB1_FrameWork.Core.Brokers.ConnectionBroker;
using SAPB1_FrameWork.Core.Brokers.LoggingBroker;
using SAPB1_FrameWork.Core.Models.Exceptions.ConnectionService;
using SAPB1_FrameWork.Core.Services.Connection;

namespace SAPB1_FrameWork.Core.Tests.Services.Connection
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
            connectionService = new ConnectionService(connectionBroker);
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
            Assert.Throws<ConnectionServiceException>(() => app = connectionService.Connect(connectionString));
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
            Assert.Throws<ConnectionServiceException>(() => app = connectionService.Connect(connectionString));
        }

        [Test]
        public void CoreServicesConnectionServiceRetrieveApplicationMustThrowConnectionServiceInvalidApplicationOnServiceNullApplication()
        {
            //Given
            SAPbouiCOM.Application app;
            //That
            //Then
            Assert.Throws<InvalidApplicationException>(() => app = connectionService.GetCurrentApplication());
        }

        [Test]
        public void CoreServicesConnectionServiceRetrieveCompanyMustThrowConnectionServiceInvalidApplicationOnServiceNullApplication()
        {
            //Given
            SAPbobsCOM.Company company;
            //That
            //Then
            Assert.Throws<InvalidApplicationException>(() => company = connectionService.GetCurrentCompany());
        }
    }
}