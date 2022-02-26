namespace SAP_B1_MVVM_Demo.Models
{
    public class Modelo
    {
        private readonly SAPbouiCOM.Form _form;
        public string Name
        {
            get
            {
                return this._form.DataSources.UserDataSources.Item("UDSET1").ValueEx;
            }
            set
            {
                this._form.DataSources.UserDataSources.Item("UDSET1").ValueEx = value;
            }
        }

        public List<string> Names
        {
            get => GetListFromGrid(this._form, "GRID1", "almacen");
        }

        public Modelo(SAPbouiCOM.Form form)
        {
            this._form = form;
        }

        private List<string> GetListFromGrid(SAPbouiCOM.Form _form, string gridUID, string columnName)
        {
            SAPbouiCOM.Grid gridNames = (SAPbouiCOM.Grid)_form.Items.Item(gridUID).Specific;
            if (gridNames is null)
            {
                return Enumerable.Empty<string>().ToList();
            }

            var names = new List<string>();
            if (gridNames.Rows?.SelectedRows?.Count > 0)
            {
                for (int i = 0; i < gridNames?.Rows?.Count; i++)
                {
                    if (gridNames.Rows.IsSelected(i))
                    {
                        var value = gridNames.DataTable.GetValue(columnName, gridNames.GetDataTableRowIndex(i)).ToString();
                        if (value is not null) names.Add(value);
                    }
                }
            }
            return names;
        }
    }
}
