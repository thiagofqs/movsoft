using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft.Forms
{
    public partial class CadClientePessoal : Form
    {
        ClientesBLL clientesBLL = new();
        Funcoes funcoes = new();
        private bool primeiraAberturaCliente = true;
        private bool editarCliente = false;
        public CadClientePessoal(bool primeiraAbertura, bool editar)
        {
            InitializeComponent();
            RemoverMascarasDeTexto();
            funcoes.PrimeiroInputEmFoco(inputNome);
            funcoes.AjustarSelectorDosMaskedTextBox(this);
            if (!primeiraAbertura)
            {
                primeiraAberturaCliente = false;
                AtribuirDadosAosInputs();
            }
            if (editar && primeiraAbertura)
            {
                txtTitulo.Text = "Editar Cliente 1/2";
                clientesBLL.PegarDados((int)Parametros.idCliente);
                clientesBLL.PegarEndereco((int)Parametros.idCliente);
                editarCliente = true;
                AtribuirDadosAosInputs();
            }
            else if (editar && !primeiraAbertura)
            {
                txtTitulo.Text = "Editar Cliente 1/2";
                editarCliente = true;
                AtribuirDadosAosInputs();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            funcoes.RemoverMascarasDeTexto(inputCpf);
            funcoes.RemoverMascarasDeTexto(inputNascimento);
            funcoes.RemoverMascarasDeTexto(inputCelular);
        }

        private void AtribuirDadosDosInputs()
        {
            Parametros.nomeCliente = inputNome.Text;
            Parametros.sobrenomeCliente = inputSobrenome.Text;
            Parametros.idSexoCliente = inputboxSexo.SelectedIndex + 1;
            Parametros.cpfCliente = inputCpf.Text;
            if (primeiraAberturaCliente == true)
            {
                Parametros.nascimentoCliente = funcoes.BdDataNascimento(inputNascimento.Text);
            }
            Parametros.nascimentoInputCliente = inputNascimento.Text;
            Parametros.emailCliente = inputEmail.Text;
            Parametros.dddCliente = inputCelular.Text.Substring(0, 2);
            Parametros.celularCliente = inputCelular.Text.Substring(2, 9);
        }

        private void AtribuirDadosAosInputs()
        {
            inputNome.Text = Parametros.nomeCliente;
            inputSobrenome.Text = Parametros.sobrenomeCliente;
            inputboxSexo.SelectedIndex = (int)Parametros.idSexoCliente - 1;
            inputCpf.Text = Parametros.cpfCliente;
            inputNascimento.Text = Parametros.nascimentoInputCliente;
            inputEmail.Text = Parametros.emailCliente;
            inputCelular.Text = Parametros.dddCliente + Parametros.celularCliente;
        }

        private void ContinuarCadastro()
        {
            AtribuirDadosDosInputs();
            Close();
            GC.Collect();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is CadCliente
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((CadCliente)qrForm.First()).AbrirTelaCadClienteEndereco(primeiraAberturaCliente, editarCliente);
            }
        }

        private void VerificarCampos()
        {
            if (inputNome.Text == "" || inputSobrenome.Text == "" || inputboxSexo.Text == "" || inputCpf.Text == "" || inputNascimento.Text == "" || inputEmail.Text == "" || inputCelular.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else
            {
                bool[] validacaoCorreta = new bool[4];
                validacaoCorreta[0] = funcoes.ValidacaoCPF(inputCpf);
                validacaoCorreta[1] = funcoes.ValidacaoDataNascimento(inputNascimento);
                validacaoCorreta[2] = funcoes.ValidacaoEmail(inputEmail);
                validacaoCorreta[3] = funcoes.ValidacaoTelefone(inputCelular);
                if (validacaoCorreta[0] && validacaoCorreta[1] && validacaoCorreta[2] && validacaoCorreta[3])
                {
                    ContinuarCadastro();
                }
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void toggleButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCampos();
            }
        }

        private void inputCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCampos();
            }
        }
    }
}