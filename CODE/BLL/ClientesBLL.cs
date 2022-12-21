using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    class ClientesBLL
    {
        AcessoBancoDados db = new();
        private char permissao;

        public char VerificarPermissao(int idCargo, int idPermissao)
        {
            try
            {
                db.Conectar();
                string comando = $"call verificarPermissoes({idCargo},{idPermissao})";
                MySqlDataReader dr = db.RetDataReader(comando);
                permissao = char.Parse(dr.GetString(3));
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return permissao;
        }

        public void CadastrarClientes(UsuariosDTO dto)
        {
            try
            {
                db.Conectar();
                //string comando = $"call cad_usuarios('{dto.Nome}','{dto.Senha}',{dto.Id_cargo}, {dto.Id_colaborador})";
                //db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente!");
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable MostrarClientes()
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                //dataTable = db.RetDataTable("call usuarios()");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
        public DataTable ProcurarClientes(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                //dataTable = db.RetDataTable($"call procurarUsuarios('{pesquisa}')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public void EditarCliente(UsuariosDTO dto)
        {
            try
            {
                db.Conectar();
                //string comando = $"call edit_usuario({dto.Id_usuario}, {dto.Id_colaborador}, {dto.Id_cargo}, '{dto.Nome}','{dto.Senha}')";
                //db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar cliente!");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
