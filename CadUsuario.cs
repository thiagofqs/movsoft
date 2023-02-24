using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft
{
    public partial class CadUsuario : Form
    {
        Funcoes funcoes = new();
        ColaboradoresBLL bllColaboradores = new();
        CargosBLL bllCargos = new();
        UsuariosBLL bllUsuarios = new();
        UsuariosDTO dtoUsuarios = new();
        Dados dados = new();

        private struct Dados
        {
            public string nomeUsuario;
            public string senhaUsuario;
            public string confirmarSenha;
            public int idCargo;
            public int idColaborador;
        }
        private bool editarUsuario = false;

        public CadUsuario()
        {
            InitializeComponent();
            centralizarElementos();
            ListarColaboradores();
            ListarCargos();
            if(Parametros.editarUser == true)
            {
                editarUsuario = true;
                txtTitulo.Text = "Editar Usuário";
                btnCadastrar.Text = "Salvar";
                AtribuirValores();
                centralizarElementos();
            }
        }

        private void ListarColaboradores()
        {
            List<string> lista = bllColaboradores.Colaboradores();
            foreach (string item in lista)
            {
                inputboxColaborador.Items.Add(item);
            }
        }

        private void ListarCargos()
        {
            List<string> lista = bllCargos.Cargos();
            foreach (string item in lista)
            {
                inputboxCargo.Items.Add(item);
            }
        }

        private void AtribuirValores()
        {
            inputUsuario.Text = Parametros.nomeUserEdit;
            inputboxCargo.Text = Parametros.cargoUserEdit;
            inputboxColaborador.Text = Parametros.colaboradorUserEdit;
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
                dtoUsuarios.Id_usuario = (int)Parametros.idUserEdit;
                dtoUsuarios.Nome = dados.nomeUsuario;
                dtoUsuarios.Senha = dados.senhaUsuario;
                dtoUsuarios.Id_cargo = dados.idCargo;
                dtoUsuarios.Id_colaborador = dados.idColaborador;
                bllUsuarios.EditarUsuario(dtoUsuarios);
                if(dtoUsuarios.Id_usuario == Parametros.idUser)
                {
                    MessageBox.Show("Você Será Redirecionado Para a Tela de Login");
                    funcoes.ThreadVoltarAoLogin();
                }
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
                Parametros parametros = new();
                AtualizarUsuarios();
            }
            else if (editarUsuario == true)
            {
                EditarUsuario();
                Close();
                Parametros parametros = new();
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

        private void centralizarElementos()
        {
            funcoes.centralizarElementos(txtTitulo, pnlContent);
            funcoes.centralizarElementos(pnlContent, this);
            funcoes.centralizarElementosVerticalmente(pnlContent, this);
            funcoes.centralizarElementos(btnCadastrar, pnlContent);
            funcoes.centralizarElementos(inputboxColaborador, pnlContent);
            txtColaborador.Left = inputboxColaborador.Left;
        }
    }   
}