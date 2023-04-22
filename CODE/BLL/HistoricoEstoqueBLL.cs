using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    internal class HistoricoEstoqueBLL
    {
        AcessoBancoDados db = new();

        public void lancarEstoque(HistoricoEstoqueDTO historicoEstoqueDTO,string tabela)
        {
            string procedure;
            string tipoItem;
            if(tabela == "P")
            {
                procedure = "lancarEstoqueProduto";
                tipoItem = historicoEstoqueDTO.Produto;
            }
            else if(tabela == "C")
            {
                procedure = "lancarEstoqueComponente";
                tipoItem = historicoEstoqueDTO.Componente;
            }
            else
            {
                procedure = "lancarEstoqueItem";
                tipoItem = historicoEstoqueDTO.Item;
            }
            string comando = @$"call {procedure}('{tipoItem}',{historicoEstoqueDTO.Qtd},{historicoEstoqueDTO.TipoMovimento},'{historicoEstoqueDTO.Fornecedor}');";
            try
            {
                db.Conectar();
                db.ExecutarComandoSQL(comando);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable verHistoricoProduto(string item, string tabela)
        {
            DataTable dataTable = new();
            string procedure;
            if (tabela == "P")
            {
                procedure = "verHistoricoProduto";

            }
            else if (tabela == "C")
            {
                procedure = "verHistoricoComponente";
            }
            else
            {
                procedure = "verHistoricoItem";
            }
            string comando = @$"call {procedure}('{item}');";
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
