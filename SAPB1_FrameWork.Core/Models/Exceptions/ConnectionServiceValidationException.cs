using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Models.Exceptions
{
    public class ConnectionServiceValidationException : Exception
    {
        public ConnectionServiceValidationException()
                : base("There was a problem trying to connect to SAP Business One CLient.")
        { }
    }
}
