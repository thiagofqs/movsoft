using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    internal class ComponentesBLL
    {
        AcessoBancoDados db = new();

        public void CadastrarComponentes(ComponentesDTO componentesDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call cad_componentes(
                '{componentesDTO.NomeComponente}', '{componentesDTO.UnidadeMedida}', '{componentesDTO.Ativo}'
                );";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarComponentes(string? filtro)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                string comando = $@"call componentes(
                '{filtro}'
                );";
                dataTable = db.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public void PegarDados(int idComponente)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_selec_componentes({idComponente});";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idComponente = dr.GetInt32(0);
                Parametros.nomeComponente = dr.GetString(1);
                Parametros.unidadeMedidaComponente = dr.GetString(2);
                Parametros.componenteAtivo = dr.GetString(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarComponente(ComponentesDTO componentesDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_componente(
                {componentesDTO.IdComponente}, '{componentesDTO.NomeComponente}',
                '{componentesDTO.UnidadeMedida}', '{componentesDTO.Ativo}'
                );";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable PesquisarComponente(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable(@$"call procurarComponentes('{pesquisa}');");
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
