using MovSoft.CODE.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.BLL
{
    internal class EstoqueBLL
    {
        AcessoBancoDados db = new();

        public DataTable mostrarSaldo(string tabela)
        {
            DataTable dataTable = new();
            string procedure;
            if(tabela == "P")
            {
                procedure = "verSaldoProduto";
            }
            else if (tabela == "C")
            {
                procedure = "verSaldoComponente";
            }
            else
            {
                procedure = "verSaldoItem";
            }
            string comando = $@"call {procedure}();";
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public DataTable pesquisarSaldo(string tabela,string pesquisa)
        {
            DataTable dataTable = new();
            string procedure;
            if (tabela == "P")
            {
                procedure = "pesquisarSaldoProduto";
            }
            else if (tabela == "C")
            {
                procedure = "pesquisarSaldoComponente";
            }
            else
            {
                procedure = "pesquisarSaldoItem";
            }
            string comando = $@"call {procedure}('{pesquisa}');";
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
    }
}
