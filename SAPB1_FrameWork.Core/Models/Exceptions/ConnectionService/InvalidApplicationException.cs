// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

namespace SAPB1_FrameWork.Core.Models.Exceptions.ConnectionService
{
    public class InvalidApplicationException : Exception
    {
        public InvalidApplicationException()
            : base("The SAP Application is null. Please use Connect() First.")
        { }
    }
}
