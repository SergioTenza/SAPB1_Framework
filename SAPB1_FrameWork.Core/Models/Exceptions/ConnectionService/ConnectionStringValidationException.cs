// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

namespace SAPB1_FrameWork.Core.Models.Exceptions.ConnectionService
{
    public class ConnectionStringValidationException : Exception
    {
        public ConnectionStringValidationException()
            : base("The Connection string is not valid.")
        { }
    }
}
