// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------
using SAPB1_FrameWork.Core.Brokers.ConnectionBroker;
using SAPB1_FrameWork.Core.Models.Exceptions.ConnectionService;

namespace SAPB1_FrameWork.Core.Services.Connection
{
    public partial class ConnectionService : IConnectionService
    {
        private readonly IConnectionBroker connectionBroker;
        private SAPbouiCOM.Application? application;
        private SAPbobsCOM.Company? company;

        public ConnectionService(IConnectionBroker connectionBroker)
        {

            this.connectionBroker = connectionBroker;
        }
        public SAPbouiCOM.Application Connect(string connection) =>
        TryCatch(() =>
        {
            if (this.application is not null)
            {
                return this.application;
            }
            ValidateConnectionString(connection);
            this.application = this.connectionBroker.GetApplication(connection);
            company = (SAPbobsCOM.Company)application.Company.GetDICompany();
            return application;
        });
        public SAPbouiCOM.Application GetCurrentApplication()
        {
            if (this.application is null) throw new InvalidApplicationException();
            return this.application;
        }

        public SAPbobsCOM.Company GetCurrentCompany()
        {
            if (this.application is null) throw new InvalidApplicationException();
            return company is null ? (SAPbobsCOM.Company)application.Company.GetDICompany() : company;
        }

        
    }
}
