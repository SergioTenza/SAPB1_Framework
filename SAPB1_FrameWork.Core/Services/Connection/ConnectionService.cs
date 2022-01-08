using SAPB1_FrameWork.Core.Brokers.ConnectionBroker;
using SAPB1_FrameWork.Core.Brokers.Logging;
using SAPB1_FrameWork.Core.Models.Exceptions;
using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Services.Connection
{
    public partial class ConnectionService : IConnectionService
    {
        private readonly ILogger logger;
        private readonly IConnectionBroker connectionBroker;
        private SAPbouiCOM.Application? application { get; set; }

        public ConnectionService(ILogger logger, IConnectionBroker connectionBroker)
        {
            this.logger = logger;
            this.connectionBroker = connectionBroker;
        }
        public Application RetrieveApplication(string connection) =>
        TryCatch(() =>
        {
            ValidateConnectionString(connection);
            application ??= this.connectionBroker.GetApplication(connection);            
            return this.application;
        });

        public SAPbobsCOM.Company GetCurrentCompany()
        {
            if (this.application is null)
            {
                throw new ConnectionServiceInvalidApplicationException();
            }
            return (SAPbobsCOM.Company)this.application.Company.GetDICompany();
        }

        public Application GetCurrentApplication()
        {
            application ??= 
    }
}
