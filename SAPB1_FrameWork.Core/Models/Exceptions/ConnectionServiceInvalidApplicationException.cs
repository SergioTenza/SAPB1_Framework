using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Models.Exceptions
{
    public class ConnectionServiceInvalidApplicationException:Exception
    {
        public ConnectionServiceInvalidApplicationException()
            :base("The SAP Application is null. Please use Retrieve Application Method First.")
        { }
    }
}
