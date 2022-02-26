// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------
using SAPB1_FrameWork.Core.Models.Exceptions.ConnectionService;

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
            catch (ConnectionStringValidationException applicationValidationException)
            {
                throw CreateAndLogValidationException(applicationValidationException);
            }
            catch (System.Runtime.InteropServices.COMException systemInterOpException)
            {
                throw CreateAndLogException(systemInterOpException);
            }
            catch (InvalidApplicationException invalidApplicationException)
            {
                throw CreateAndLogException(invalidApplicationException);
            }
            catch (Exception exception)
            {
                throw CreateAndLogException(exception);
            }
        }
        private ConnectionServiceException CreateAndLogValidationException(Exception exception)
        {
            var applicationValidationException = new ConnectionServiceException(exception);
            return applicationValidationException;
        }
        private ConnectionServiceException CreateAndLogException(Exception exception)
        {
            var applicationValidationException = new ConnectionServiceException(exception);
            return applicationValidationException;
        }
    }
}
