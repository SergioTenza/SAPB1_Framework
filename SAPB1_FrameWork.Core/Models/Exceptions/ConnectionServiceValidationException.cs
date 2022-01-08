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
                : base("Ha ocurrido un problema al crear la conexion con SAP Business One")
        { }
    }
}
