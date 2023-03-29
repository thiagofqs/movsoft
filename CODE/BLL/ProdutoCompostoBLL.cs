using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    internal class ProdutoCompostoBLL
    {
        AcessoBancoDados db = new();

        public void VincularComponentes(ProdutoCompostoDTO produtoCompostoDTO)
        {
            db.Conectar();
            try
            {
                for(int i = 0; i < produtoCompostoDTO.IdComponente.Count;  i++)
                {
                    string comando = $@"call vincular_componentes({produtoCompostoDTO.IdProduto[i]},{produtoCompostoDTO.IdComponente[i]},{produtoCompostoDTO.QtdComponente[i]});";
                    db.ExecutarComandoSQL(comando,true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DesvincularComponentes(int idProduto,int idComponente)
        {
            db.Conectar();
            try
            {
                string comando = $@"call desvincular_componentes({idProduto},{idComponente});";
                db.ExecutarComandoSQL(comando);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditarQuantidadeComponenteNoProduto(int idProduto,int idComponente,float qtdComponente)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_componente_produtoComposto({idProduto},{idComponente},{qtdComponente});";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void VincularOpcionais(ProdutoCompostoDTO produtoCompostoDTO)
        {
            try
            {
                db.Conectar();
                for(int i = 0; i < produtoCompostoDTO.IdOpcional.Count; i++)
                {
                    string comando = $@"call vincular_opcionais({produtoCompostoDTO.IdProduto[i]},{produtoCompostoDTO.IdOpcional[i]});";
                    db.ExecutarComandoSQL(comando,true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DesvincularOpcionais(int idProduto,int idOpcional)
        {
            try
            {
                db.Conectar();
                string comando = $@"call desvincular_opcionais({idProduto},{idOpcional})";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable MostrarComponentesDoProdutoGridView(int idProduto)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                string comando = $@"call componentesDoProduto({idProduto});";
                dataTable = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
        public DataTable MostrarOpcionaisDoProdutoGridView(int idProduto)
        {
            DataTable dataTable = new DataTable();
            try
            {
                db.Conectar();
                string comando = $@"call opcionaisDoProduto({idProduto});";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public void MostrarComponentesDoProduto(int idProduto)
        {
            try
            {
                db.Conectar();
                string comando = $@"call componentesDoProduto({idProduto});";
                MySqlDataReader dr = db.RetDataReader(comando);
                do
                {
                    Parametros.idComponenteProdutoComposto.Add(dr.GetInt32(0));
                    Parametros.componenteProdutoComposto.Add(dr.GetString(1));
                    Parametros.qtdComponenteProdutoComposto.Add(dr.GetFloat(2));
                    Parametros.unidadeMedidaComponenteProdutoComposto.Add(dr.GetString(3));
                }
                while (dr.Read());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarOpcionaisDoProduto(int idProduto)
        {
            try
            {
                db.Conectar();
                string comando = $@"call opcionaisDoProduto({idProduto});";
                MySqlDataReader dr = db.RetDataReader(comando);
                do
                {
                    Parametros.idOpcionalProdutoComposto.Add(dr.GetInt32(0));
                    Parametros.opcionalProdutoComposto.Add(dr.GetString(1));
                    Parametros.qtdMarcacoesOpcionalProdutoComposto.Add(dr.GetInt32(2));
                    Parametros.opcaoProdutoComposto.Add(dr.GetString(3));
                    Parametros.precoOpcaoProdutoComposto.Add(dr.GetFloat(4));
                }
                while(dr.Read());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
