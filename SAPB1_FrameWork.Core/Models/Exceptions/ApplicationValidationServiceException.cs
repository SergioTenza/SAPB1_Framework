using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Models.Exceptions
{
    public class ApplicationValidationServiceException : Exception
    {
        public ApplicationValidationServiceException(Exception innerException)
            : base("Error de validacion de la cadena de conexion con SAP Business One",innerException)
        { }
    }
}
