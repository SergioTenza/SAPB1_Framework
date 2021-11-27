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
        public Application SelectApplication(string connectionString)
        {
            SAPbouiCOM.Application SBO_Application = null;
            SAPbouiCOM.SboGuiApi SboGuiApi = null;
            string sConnectionString = null;

            SboGuiApi = new SAPbouiCOM.SboGuiApi();
            sConnectionString = connectionString;
            SboGuiApi.Connect(sConnectionString);

            SBO_Application = SboGuiApi.GetApplication(-1);

            return SBO_Application;
        }
    }
}
