using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    internal class OpcoesBLL
    {
        AcessoBancoDados db = new();
        public void CadastrarOpcoes(OpcoesDTO opcoesDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call cad_opcoes('{opcoesDTO.Opcao}',{opcoesDTO.Preco},'{opcoesDTO.UnidadeMedida}',{opcoesDTO.IdOpcional},'{opcoesDTO.Ativo}');";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarOpcoes(string? filtro, int? idOpcional)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                string comando = $@"call opcoes('{filtro}', {idOpcional});";
                dataTable = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public void PegarDados(int idOpcao)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_selec_opcoes({idOpcao});";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idOpcao = dr.GetInt32(0);
                Parametros.nomeOpcao = dr.GetString(1);
                Parametros.precoOpcao = dr.GetFloat(2);
                Parametros.unidadeMedidaOpcao = dr.GetString(3);
                Parametros.opcaoAtivo = dr.GetString(4);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarOpcao(OpcoesDTO opcoesDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_opcao(
                {opcoesDTO.IdOpcao}, '{opcoesDTO.Opcao}',
                {opcoesDTO.Preco},'{opcoesDTO.UnidadeMedida}','{opcoesDTO.Ativo}'
                );";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable PesquisarOpcao(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable(@$"call procurarOpcoes('{pesquisa}');");
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
