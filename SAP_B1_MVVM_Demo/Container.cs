using SAP_B1_MVVM_Demo.ViewModels;
using SAPB1_FrameWork.Core.Services.Connection;

namespace SAP_B1_MVVM_Demo
{
    public class Container
    {
        public SAPbouiCOM.Form? _form { get; set; }

        private readonly ViewModel _viewModel;
        private readonly IConnectionService _connectionService;

        public Container(IConnectionService connectionService, string[] args)
        {
            //NECESITAMOS INICIALIZAR EL FORMULARIO REGISTRANDOLO EN LA APLICACION Business One
            _connectionService = connectionService;
            var connectionString = args.Length == 0 ?
                       "" : args[0];
            _connectionService.Connect("");
            try
            {
                _form = this._connectionService.GetCurrentApplication().Forms.Add("MYFORM1");
            }
            catch (Exception)
            {
                _form = this._connectionService.GetCurrentApplication().Forms.GetForm("MYFORM1",-1);
            }
            _viewModel = new ViewModel(_form);
            
        }
    }
}
