using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Services.Connection
{
    public interface IConnectionService
    {
        
        SAPbouiCOM.Application RetrieveApplication(string connection);
        SAPbouiCOM.Application GetCurrentApplication();
        SAPbobsCOM.Company GetCurrentCompany();
    }
}
