// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

namespace SAPB1_FrameWork.Core.Models.Exceptions.ConnectionService
{
    public class ConnectionServiceException : Exception
    {
        public ConnectionServiceException(Exception innerException)
            : base("ConnectionService Error. Make sure SAP Business One is working and try again", innerException)
        { }
    }
}
