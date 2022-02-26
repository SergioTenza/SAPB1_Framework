// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

namespace SAPB1_FrameWork.Core.Models.Exceptions.ConnectionService
{
    public class InterOpComException : Exception
    {
        public InterOpComException()
            : base("COM Operation error. Check the SAP Business One CLient is working and try again.")
        { }
    }
}
