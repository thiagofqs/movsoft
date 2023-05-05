using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    internal class ProdutosBLL
    {
        AcessoBancoDados db = new();
        public void CadastrarProdutos(ProdutosDTO produtosDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call cad_produtos(
                '{produtosDTO.Produto}',{produtosDTO.Preco},'{produtosDTO.Grupo}',{produtosDTO.ControlaEstoque},'{produtosDTO.Ativo}'
                );";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarProdutos(string? filtro, string? grupo)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                string comando = $@"call produtos(
                '{filtro}', '{grupo}'
                );";
                dataTable = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public void PegarDados(int idProduto)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_selec_produtos({idProduto});";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idProduto = dr.GetInt32(0);
                Parametros.nomeProduto = dr.GetString(1);
                Parametros.grupoProduto = dr.GetString(2);
                Parametros.precoProduto = dr.GetFloat(3);
                Parametros.controlaEstoqueProduto = dr.GetBoolean(4);
                Parametros.produtoAtivo = dr.GetString(5);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarProduto(ProdutosDTO produtosDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_produto(
                {produtosDTO.Id_produto},'{produtosDTO.Produto}',
                {produtosDTO.Preco},'{produtosDTO.Grupo}',{produtosDTO.ControlaEstoque},'{produtosDTO.Ativo}'
                );";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable PesquisarProdutos(string pesquisa, string grupo,string filtro)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable(@$"call procurarProdutos('{pesquisa}','{grupo}','{filtro}');");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
    }
}
