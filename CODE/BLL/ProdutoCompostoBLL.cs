using Google.Protobuf.Collections;
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
                for(int i = 0; i < produtoCompostoDTO.Componente.Count;  i++)
                {
                    string comando = $@"call vincular_componentes({produtoCompostoDTO.IdProduto},'{produtoCompostoDTO.Componente[i]}', 1);";
                    db.ExecutarComandoSQL(comando, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DesvincularComponentes(int idProduto,int idComponente, bool multiplaQuery = false)
        {
            db.Conectar();
            try
            {
                string comando = $@"call desvincular_componentes({idProduto},{idComponente});";
                db.ExecutarComandoSQL(comando,multiplaQuery);
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
                for(int i = 0; i < produtoCompostoDTO.Opcional.Count; i++)
                {
                    string comando = $@"call vincular_opcionais({produtoCompostoDTO.IdProduto},'{produtoCompostoDTO.Opcional[i]}');";
                    db.ExecutarComandoSQL(comando,true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DesvincularOpcionais(int idProduto,int idOpcional, bool mutilpasQuerys = false)
        {
            try
            {
                db.Conectar();
                string comando = $@"call desvincular_opcionais({idProduto},{idOpcional})";
                db.ExecutarComandoSQL(comando,mutilpasQuerys);
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
                dataTable = db.RetDataTable(comando);
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

        public MapField<string?,bool?> ComponentesDisponiveis(int idProduto)
        {
            MapField<string?, bool?> componentes = new();
            try
            {
                db.Conectar();
                string comando = $@"call componentes_disponiveis({idProduto})";
                MySqlDataReader dr = db.RetDataReader(comando);
                do
                {
                    componentes.Add(dr.GetString(0), dr.GetBoolean(1));
                }
                while (dr.Read());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return componentes;
        }

        public MapField<string?, bool?> OpcionaisDisponiveis(int idProduto)
        {
            MapField<string?, bool?> opcionais = new();
            try
            {
                db.Conectar();
                string comando = $@"call opcionais_disponiveis({idProduto})";
                MySqlDataReader dr = db.RetDataReader(comando);
                do
                {
                    opcionais.Add(dr.GetString(0), dr.GetBoolean(1));
                }
                while (dr.Read());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return opcionais;
        }
    }
}
