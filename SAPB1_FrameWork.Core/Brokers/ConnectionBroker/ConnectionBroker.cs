// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------
namespace SAPB1_FrameWork.Core.Brokers.ConnectionBroker
{
    public class ConnectionBroker : IConnectionBroker
    {
        public SAPbouiCOM.Application GetApplication(string connectionString)
        {
            SAPbouiCOM.Application? SBO_Application;
            SAPbouiCOM.SboGuiApi? SboGuiApi;
            SboGuiApi = new SAPbouiCOM.SboGuiApi();
            SboGuiApi.Connect(connectionString);
            SBO_Application = SboGuiApi.GetApplication(-1);
            return SBO_Application;
        }
    }
}