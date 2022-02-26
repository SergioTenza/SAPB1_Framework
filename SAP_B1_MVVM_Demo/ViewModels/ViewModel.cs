using SAP_B1_MVVM_Demo.Models;
using SAP_B1_MVVM_Demo.Views;

namespace SAP_B1_MVVM_Demo.ViewModels
{
    public class ViewModel
    {
        private readonly Vista _vista;
        private readonly Modelo _modelo;

        public ViewModel(SAPbouiCOM.Form form)
        {
            //VIEW INSTANTIATION
            _vista = new Vista();
            BuildComponents(form,_vista);

            //MODEL INSTANTIATION
            _modelo = new Modelo(form);
        }

        private void BuildComponents(SAPbouiCOM.Form form, Vista _vista)
        {
            //EDITTEXT
            try
            {
                _vista._editText = (SAPbouiCOM.EditText)form.Items.Add(
                    UID: "ET1",
                    Type: SAPbouiCOM.BoFormItemTypes.it_EDIT);
            }
            catch (Exception)
            {
                _vista._editText = (SAPbouiCOM.EditText)form.Items.Item(Index: "ET1");
            }
            try
            {
                form.DataSources.UserDataSources.Add(UID: "UDSET1", DataType: SAPbouiCOM.BoDataType.dt_LONG_TEXT);
            }
            catch (Exception){}
            _vista._editText.DataBind.SetBound(Bound:true,TableName:"",Alias:"UDSET1");


            //GRID
            try
            {
                _vista._grid = (SAPbouiCOM.Grid)form.Items.Add(
                        UID: "GRID1",
                        Type: SAPbouiCOM.BoFormItemTypes.it_GRID);
            }
            catch (Exception)
            {
                _vista._grid = (SAPbouiCOM.Grid)form.Items.Item(Index: "GRID1");
            }
        }
    }
}