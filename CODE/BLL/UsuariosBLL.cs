using System.Data;
using CRUD.CODE.DAL;
using CRUD.CODE.DTO;
using MySql.Data.MySqlClient;

namespace CRUD.CODE.BLL
{
    class UsuariosBLL
    {
        AcessoBancoDados db = new();
        public struct Usuario
        {
            public int idUsuario;
            public string nome;
            public string senha;
            public string cargo;
            public char admin;
            public int idCargo;
        }
        private char permissao;

        public Usuario Login(string usuarioDigitado)
        {
            Usuario usuario = new();
            try
            {
                db.Conectar();
                string comando = $"call login('{usuarioDigitado}')";
                MySqlDataReader dr = db.RetDataReader(comando);
                usuario.idUsuario = dr.GetInt32(0);
                usuario.nome = dr.GetString(1);
                usuario.senha = dr.GetString(2);
                usuario.cargo = dr.GetString(3);
                usuario.admin = char.Parse(dr.GetString(4));
                usuario.idCargo = dr.GetInt32(5);
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return usuario;
        }

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

        public void CadastrarUsuarios(UsuariosDTO dto)
        {
            try
            {
                db.Conectar();
                string comando = $"call cad_usuarios('{dto.Nome}','{dto.Senha}',{dto.Id_cargo}, {dto.Id_colaborador})";
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
                dataTable = db.RetDataTable("call usuarios()");
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
                string comando = $"call edit_usuario({dto.Id_usuario}, {dto.Id_colaborador}, {dto.Id_cargo}, '{dto.Nome}','{dto.Senha}')";
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
