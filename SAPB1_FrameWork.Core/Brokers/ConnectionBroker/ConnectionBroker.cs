using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Brokers.ConnectionBroker
{
    public class ConnectionBroker : IConnectionBroker
    {
        public Application GetApplication(string connectionString)
        {
            SAPbouiCOM.Application? SBO_Application = null;
            SAPbouiCOM.SboGuiApi? SboGuiApi = null;

            SboGuiApi = new SAPbouiCOM.SboGuiApi();
            SboGuiApi.Connect(connectionString);
            SBO_Application = SboGuiApi.GetApplication(-1);

            return SBO_Application;
        }
    }
}
