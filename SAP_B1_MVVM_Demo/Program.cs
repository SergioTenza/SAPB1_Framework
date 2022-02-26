
using SAPB1_FrameWork.Core.Brokers.ConnectionBroker;
using SAPB1_FrameWork.Core.Services.Connection;

namespace SAP_B1_MVVM_Demo
{
    public partial class Program
    {
        // IDEALMENTE INYECTADO POR DI CONTAINER
        private static IConnectionBroker? _connectionBroker;
        private static IConnectionService? _connectionService;
        
        public static Container? baseContainer;
        static void Main(string[] args)
        {
            _connectionBroker = new ConnectionBroker();
            _connectionService = new ConnectionService(_connectionBroker);
            baseContainer =  new Container(_connectionService, args);
        }
    }
}



