using SAPB1_FrameWork.Core.Brokers.ConnectionBroker;
using SAPB1_FrameWork.Core.Brokers.Logging;
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

        public ConnectionService(ILogger logger, IConnectionBroker connectionBroker)
        {
            this.logger = logger;
            this.connectionBroker = connectionBroker;
        }
        public Application RetrieveApplication(string connection) =>
        TryCatch(() =>
        {
            ValidateConnectionString(connection);
            return this.connectionBroker.GetApplication(connection);
        });
    }
}
