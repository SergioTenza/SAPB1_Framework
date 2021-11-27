using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Brokers.ConnectionBroker
{
    public interface IConnectionBroker
    {
        SAPbouiCOM.Application SelectApplication(string connectionString);
    }
}
