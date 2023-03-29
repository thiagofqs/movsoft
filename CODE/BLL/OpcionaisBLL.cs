using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    internal class OpcionaisBLL
    {
        AcessoBancoDados db = new();

        public void CadastrarOpcionais(OpcionaisDTO opcionaisDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call cad_opcionais(
                '{opcionaisDTO.Opcional}', {opcionaisDTO.QuantidadeMarcacoes}, '{opcionaisDTO.Ativo}'
                );";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarOpcionais(string? filtro)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                string comando = $@"call opcionais(
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

        public void PegarDados(int idOpcional)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_selec_opcionais({idOpcional});";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idOpcional = dr.GetInt32(0);
                Parametros.opcional = dr.GetString(1);
                Parametros.quantidadeMarcacoes = dr.GetInt32(2);
                Parametros.opcionalAtivo = dr.GetString(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void EditarOpcional(OpcionaisDTO opcionaisDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call edit_opcional(
                {opcionaisDTO.IdOpcional},'{opcionaisDTO.Opcional}',{opcionaisDTO.QuantidadeMarcacoes},'{opcionaisDTO.Ativo}');";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable PesquisarOpcional(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable(@$"call procurarOpcionais('{pesquisa}');");
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
