// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------
namespace SAPB1_FrameWork.Core.Brokers.ConnectionBroker
{
    public interface IConnectionBroker
    {
        SAPbouiCOM.Application GetApplication(string connectionString);
    }
}
