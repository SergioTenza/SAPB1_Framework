// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------
namespace SAPB1_FrameWork.Core.Services.Connection
{
    public interface IConnectionService
    {
        
        SAPbouiCOM.Application Connect(string connection);
        SAPbouiCOM.Application GetCurrentApplication();
        SAPbobsCOM.Company GetCurrentCompany();
    }
}
