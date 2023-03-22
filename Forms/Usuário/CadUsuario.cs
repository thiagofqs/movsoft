using Google.Protobuf.Collections;
using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft.Forms
{
    public partial class CadUsuario : Form
    {
        Funcoes funcoes = new();
        ColaboradoresBLL bllColaboradores = new();
        CargosBLL bllCargos = new();
        UsuariosBLL bllUsuarios = new();
        UsuariosDTO dtoUsuarios = new();
        Dados dados = new();

        List<string> colaboradores = new();
        private struct Dados
        {
            public string nomeUsuario;
            public string senhaUsuario;
            public string confirmarSenha;
            public int idCargo;
            public int idColaborador;
            public string ativo;
        }
        private bool editarUsuario = false;

        public CadUsuario()
        {
            InitializeComponent();
            ListarColaboradores();
            ListarCargos();
            inputboxColaborador.Focus();
            if (Parametros.editarUser == true)
            {
                editarUsuario = true;
                txtTitulo.Text = "Editar Usuário";
                btnCadastrar.Text = "Salvar";
                AtribuirValores();
            }
        }

        private void ListarColaboradores()
        {
            colaboradores = bllColaboradores.ColaboradoresSemUsuarioVinculado();
            foreach (string item in colaboradores)
            {
                inputboxColaborador.Items.Add(item);
                inputboxColaborador.AutoCompleteCustomSource.Add(item);
            }
            if (Parametros.editarUser == true)
            {
                inputboxColaborador.Items.Add(Parametros.colaboradorUserEdit);
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
            if(Parametros.UserAtivoEdit == "S")
            {
                toggleButton1.Checked = true;
            }
            else
            {
                toggleButton1.Checked = false;
            }
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
            if(toggleButton1.Checked)
            {
                dados.ativo = "S";
            }
            else
            {
                dados.ativo = "N";
            }
            PegarIdColaboradorPeloNome();
        }

        private void PegarIdColaboradorPeloNome()
        {
            dados.idColaborador = bllColaboradores.PegarIdPeloNome(inputboxColaborador.Text);
        }

        private void CadastrarUsuario()
        {
            AtribuirDadosDosInputs();
            {
                if (dados.senhaUsuario == dados.confirmarSenha)
                {
                    dtoUsuarios.Nome = dados.nomeUsuario;
                    dtoUsuarios.Senha = dados.senhaUsuario;
                    dtoUsuarios.Id_cargo = dados.idCargo;
                    dtoUsuarios.Id_colaborador = dados.idColaborador;
                    dtoUsuarios.Ativo = dados.ativo;
                    bllUsuarios.CadastrarUsuarios(dtoUsuarios);
                    funcoes.LimparInputsDeUmControl(pnlContent);
                    inputboxColaborador.Focus();
                    AtualizarUsuarios();
                }
                else
                {
                    MessageBox.Show("Senhas não idênticas!");
                }
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
                dtoUsuarios.Ativo = dados.ativo;
                bllUsuarios.EditarUsuario(dtoUsuarios);
                AtualizarUsuarios();
            }
            else
            {
                MessageBox.Show("Senhas não idênticas!");
            }
        }

        private void VerificarCampos()
        {
            if(!funcoes.VerificarSeInputEstaVazio(pnlContent))
            {
                CadastrarOuEditar();
            }
        }

        private void CadastrarOuEditar()
        {
            if (editarUsuario)
            {
                EditarUsuario();
                Close();
            }
            else if (!editarUsuario)
            {
                CadastrarUsuario();
            }
            GC.Collect();
        }

        private void inputConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCampos();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }
    }
}