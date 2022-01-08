using SAPB1_FrameWork.Core.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPB1_FrameWork.Core.Services.Connection
{
    public partial class ConnectionService
    {
		private delegate SAPbouiCOM.Application ReturningApplicationFunction();
		private SAPbouiCOM.Application TryCatch(ReturningApplicationFunction returningApplicationFunction)
		{
			try
			{
				return returningApplicationFunction();
			}
			catch (ApplicationValidationServiceException applicationValidationException)
			{
				throw CreateAndLogValidationException(applicationValidationException);
			}
			catch (System.Runtime.InteropServices.COMException systemInterOpException)
            {
				throw CreateAndLogComException(systemInterOpException);
			}
		}

		private ApplicationValidationServiceException CreateAndLogValidationException(Exception exception)
		{
			var applicationValidationException = new ApplicationValidationServiceException(exception);
			this.logger.Log(applicationValidationException.Message);

			return applicationValidationException;
		}

		private ConnectionServiceInterOpComException CreateAndLogComException(System.Runtime.InteropServices.COMException exception)
		{
			var connectionServiceInterOpComException = new ConnectionServiceInterOpComException(exception);
			this.logger.Log(connectionServiceInterOpComException.Message);

			return connectionServiceInterOpComException;
		}
	}
}
