using CRUD.CODE.BLL;
using CRUD.CODE.DTO;

namespace MovSoft
{
    public partial class CadUsuario : Form
    {
        ColaboradoresBLL bllColaboradores = new();
        CargosBLL bllCargos = new();
        UsuariosBLL bllUsuarios = new();
        UsuariosDTO dtoUsuarios = new();
        DataGridViewRow rowData;
        Permissao permissao = new();
        Dados dados = new();

        private struct Dados
        {
            public string nomeUsuario;
            public string senhaUsuario;
            public string confirmarSenha;
            public int idCargo;
            public int idColaborador;
        }

        private struct Permissao
        {
            public int idCargo;
            public char admin;
        }
        private bool editarUsuario = false;

        public CadUsuario(int idCargo, char admin, DataGridViewRow rowDataRetornado, bool editarUsuarioRetornado)
        {
            InitializeComponent();
            ListarColaboradores();
            ListarCargos();
            permissao.idCargo = idCargo;
            permissao.admin = admin;
            if(editarUsuarioRetornado == true)
            {
                editarUsuario = true;
                txtTitulo.Text = "Editar Usuário";
                btnCadastrar.Text = "Salvar";
                rowData = rowDataRetornado;
                AtribuirValores();
            }
        }

        private void ListarColaboradores()
        {
            List<string> lista = new();
            lista = bllColaboradores.Colaboradores();
            foreach (string item in lista)
            {
                inputboxColaborador.Items.Add(item);
            }
        }

        private void ListarCargos()
        {
            List<string> lista = new();
            lista = bllCargos.Cargos();
            foreach (string item in lista)
            {
                inputboxCargo.Items.Add(item);
            }
        }

        private void AtribuirValores()
        {
            inputUsuario.Text = rowData.Cells[1].Value.ToString();
            inputboxCargo.Text = rowData.Cells[2].Value.ToString();
            inputboxColaborador.Text = rowData.Cells[3].Value.ToString();
            inputSenha.Text = "";
            inputConfirmarSenha.Text = "";
        }

        private void AtualizarUsuarios()
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaUsuarios
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaUsuarios)qrForm.First()).CarregarUsuarios();
            }
        }

        private void AtribuirDadosDosInputs()
        {
            dados.nomeUsuario = inputUsuario.Text;
            dados.senhaUsuario = inputSenha.Text;
            dados.confirmarSenha = inputConfirmarSenha.Text;
            dados.idCargo = inputboxCargo.SelectedIndex + 1;
            dados.idColaborador = inputboxColaborador.SelectedIndex + 1;
        }

        private void CadastrarUsuario()
        {
            AtribuirDadosDosInputs();
            if (dados.senhaUsuario == dados.confirmarSenha)
            {
                dtoUsuarios.Nome = dados.nomeUsuario;
                dtoUsuarios.Senha = dados.senhaUsuario;
                dtoUsuarios.Id_cargo = dados.idCargo;
                dtoUsuarios.Id_colaborador = dados.idColaborador;
                bllUsuarios.CadastrarUsuarios(dtoUsuarios);
            }
            else
            {
                MessageBox.Show("Senhas não idênticas!");
            }
        }

        private void EditarUsuario()
        {
            AtribuirDadosDosInputs();
            if (dados.senhaUsuario == dados.confirmarSenha)
            {
                dtoUsuarios.Id_usuario = int.Parse(rowData.Cells[0].Value.ToString());
                dtoUsuarios.Nome = dados.nomeUsuario;
                dtoUsuarios.Senha = dados.senhaUsuario;
                dtoUsuarios.Id_cargo = dados.idCargo;
                dtoUsuarios.Id_colaborador = dados.idColaborador;
                bllUsuarios.EditarUsuario(dtoUsuarios);
            }
            else
            {
                MessageBox.Show("Senhas não idênticas!");
            }
        }

        private void VerificacaoCadastro()
        {
            if (inputboxColaborador.Text == "" || inputUsuario.Text == "" || inputboxCargo.Text == "" || inputSenha.Text == "" || inputConfirmarSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else if (editarUsuario == false)
            {
                CadastrarUsuario();
                Close();
                AtualizarUsuarios();
            }
            else if (editarUsuario == true)
            {
                EditarUsuario();
                Close();
                AtualizarUsuarios();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            VerificacaoCadastro();
        }

        private void inputConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificacaoCadastro();
            }
        }
    }   
}