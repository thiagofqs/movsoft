using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft
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
            if (primeiraAbertura == false)
            {
                primeiraAberturaCliente = false;
                AtribuirDadosAosInputs();
            }
            else if (primeiraAbertura == true && editar == false)
            {
                Parametros parametros = new Parametros();
            }
            if (editar == true && primeiraAbertura == true)
            {
                txtTitulo.Text = "Editar Colaborador 1/2";
                clientesBLL.PegarDados((int)Parametros.idCliente);
                clientesBLL.PegarEndereco((int)Parametros.idCliente);
                editarCliente = true;
                AtribuirDadosAosInputs();
                CentralizarElementos();
            }
            else if (editar == true && primeiraAbertura == false)
            {
                txtTitulo.Text = "Editar Colaborador 1/2";
                editarCliente = true;
                AtribuirDadosAosInputs();
                CentralizarElementos();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            funcoes.RemoverMascarasDeTexto(inputCpf);
            funcoes.RemoverMascarasDeTexto(inputNascimento);
            funcoes.RemoverMascarasDeTexto(inputCelular);
        }

        private void CentralizarElementos()
        {
            funcoes.centralizarElementos(btnProximo, this);
            funcoes.centralizarElementos(txtTitulo, this);
        }

        private string BdDataNascimento(string data)
        {
            data = funcoes.BdDataNascimento(data);
            return data;
        }

        private void AtribuirDadosDosInputs()
        {
            Parametros.nomeCliente = inputNome.Text;
            Parametros.sobrenomeCliente = inputSobrenome.Text;
            Parametros.idSexoCliente = inputboxSexo.SelectedIndex + 1;
            Parametros.cpfCliente = inputCpf.Text;
            if (primeiraAberturaCliente == true)
            {
                Parametros.nascimentoCliente = BdDataNascimento(inputNascimento.Text);
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

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (funcoes.ValidacaoData(inputNascimento) && funcoes.ValidacaoEmail(inputEmail) && funcoes.ValidacaoTelefone(inputCelular)/* && funcoes.ValidacaoCPF(inputCpf)*/)
            {
                ContinuarCadastro();
            }
        }

        private void ContinuarCadastro()
        {
                AtribuirDadosDosInputs();
                    var qrForm = from frm in Application.OpenForms.Cast<Form>()
                                 where frm is CadCliente
                                 select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((CadCliente)qrForm.First()).AbrirTelaCadClienteEndereco(primeiraAberturaCliente, editarCliente);
            }
        }

        private void inputCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ContinuarCadastro();
            }
        }
    }
}