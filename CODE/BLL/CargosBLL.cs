using System.Data;
using CRUD.CODE.DAL;

namespace CRUD.CODE.BLL
{

    class CargosBLL
    {
        AcessoBancoDados db = new();
        List<string> listaCargos = new List<string>();

        public List<string> Cargos()
        {
            try
            {
                DataTable dataTable = new DataTable();
                db.Conectar();
                string comando = $"call cargos()";
                dataTable = db.RetDataTable(comando);
                foreach(DataRow dataRow in dataTable.Rows )
                {
                    string content = dataRow["cargo"].ToString();
                    listaCargos.Add(content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar cargos!");
                MessageBox.Show(ex.Message);
            }
            return listaCargos;
        }
    }
}
