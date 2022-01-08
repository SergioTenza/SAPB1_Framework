using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Models.Exceptions
{
    public class ConnectionServiceInterOpComException : Exception
    {
        public ConnectionServiceInterOpComException(System.Runtime.InteropServices.COMException innerException)
            : base("COM Operation error. Check the SAP Business One CLient is working and try again.")
        { }
    }
}
