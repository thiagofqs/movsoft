using System.Data;
using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;

namespace MovSoft.CODE.BLL
{
    class UsuariosBLL
    {
        AcessoBancoDados db = new();

        public bool Login(string usuarioDigitado)
        {
            try
            {
                db.Conectar();
                string comando = $"call login('{usuarioDigitado}')";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idUser = dr.GetInt32(0);
                Parametros.nomeUser = dr.GetString(1);
                Parametros.senhaUser = dr.GetString(2);
                Parametros.cargoUser = dr.GetString(3);
                Parametros.adminUser = char.Parse(dr.GetString(4));
                Parametros.idCargoUser = dr.GetInt32(5);
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void VerificarPermissao(int idCargo, int idPermissao)
        {
            try
            {
                db.Conectar();
                string comando = $"call verificarPermissoes({idCargo},{idPermissao})";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.permissaoUser = char.Parse(dr.GetString(3));
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void CadastrarUsuarios(UsuariosDTO dto)
        {
            try
            {
                db.Conectar();
                string comando = $"call cad_usuario('{dto.Nome}','{dto.Senha}',{dto.Id_cargo}, {dto.Id_colaborador},'S')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar usuário!");
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable MostrarUsuarios()
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable("call usuarios('S')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
        public DataTable ProcurarUsuarios(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable($"call procurarUsuarios('{pesquisa}')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public void EditarUsuario(UsuariosDTO dto)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_usuario({dto.Id_usuario}, {dto.Id_colaborador}, {dto.Id_cargo}, '{dto.Nome}','{dto.Senha}','S')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar Usuário!");
                MessageBox.Show(ex.Message);
            }
        }
    }
}