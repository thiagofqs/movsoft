using System.Data;

namespace MovSoft
{
    public partial class CadColaboradorPessoal : Form
    {
        Dados dadosColaborador = new();
        public struct Dados
        {
            public int idColaborador;
            public string nome;
            public string sobrenome;
            public int idSexo;
            public string cpf;
            public string nascimento;
            public string nascimentoInput;
            public string email;
            public int idCelular;
            public string ddd;
            public string celular;
        }
        CadColaboradorEndereco.Endereco enderecoColaborador = new();
        private bool primeiraAberturaEndereco = true;
        private bool editarColaborador = false;
        public CadColaboradorPessoal(Dados dadosColaboradorRetornado, bool primeiraAbertura, bool editarColaboradorRetornado, CadColaboradorEndereco.Endereco enderecoColaboradorRetornado)
        {
            InitializeComponent();
            RemoverMascarasDeTexto();
            if(primeiraAbertura == false)
            {
                primeiraAberturaEndereco = false;
                dadosColaborador = dadosColaboradorRetornado;
                AtribuirDadosAosInputs();
            }
            if(editarColaboradorRetornado == true)
            {
                txtTitulo.Text = "Editar Colaborador 1/2";
                dadosColaborador = dadosColaboradorRetornado;
                enderecoColaborador = enderecoColaboradorRetornado;
                editarColaborador = true;
                AtribuirDadosAosInputs();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            inputCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            inputNascimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            inputCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private string BdDataNascimento(string data)
        {
            data = data.Substring(4, 4) + "-" + data.Substring(2, 2) + "-" + data.Substring(0, 2);
            return data;
        }

        private void AtribuirDadosDosInputs()
        {
            dadosColaborador.nome = inputNome.Text;
            dadosColaborador.sobrenome = inputSobrenome.Text;
            dadosColaborador.idSexo = inputboxSexo.SelectedIndex + 1;
            dadosColaborador.cpf = inputCpf.Text;
            if(primeiraAberturaEndereco == true)
            {
                dadosColaborador.nascimento = BdDataNascimento(inputNascimento.Text);
            }
            dadosColaborador.nascimentoInput = inputNascimento.Text;
            dadosColaborador.email = inputEmail.Text;
            dadosColaborador.ddd = inputCelular.Text.Substring(0, 2);
            dadosColaborador.celular = inputCelular.Text.Substring(2, 9);
        }

        private void AtribuirDadosAosInputs()
        {
            inputNome.Text = dadosColaborador.nome;
            inputSobrenome.Text = dadosColaborador.sobrenome;
            inputboxSexo.SelectedIndex = dadosColaborador.idSexo - 1;
            inputCpf.Text = dadosColaborador.cpf;
            inputNascimento.Text = dadosColaborador.nascimentoInput;
            inputEmail.Text = dadosColaborador.email;
            inputCelular.Text = dadosColaborador.ddd + dadosColaborador.celular;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            ContinuarCadastro();
        }

        private void ContinuarCadastro()
        {
            if (inputNome.Text == "" || inputSobrenome.Text == "" || inputboxSexo.Text == "" || inputCpf.Text == "" || inputNascimento.Text == "" || inputEmail.Text == "" || inputCelular.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else
            {
                AtribuirDadosDosInputs();
                if (editarColaborador == true)
                {
                    var qrForm = from frm in Application.OpenForms.Cast<Form>()
                                 where frm is CadColaborador
                                 select frm;
                    if (qrForm != null && qrForm.Count() > 0)
                    {
                        ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorEnderecoEditar(dadosColaborador, enderecoColaborador);
                    }
                }
                else
                {
                    var qrForm = from frm in Application.OpenForms.Cast<Form>()
                                 where frm is CadColaborador
                                 select frm;
                    if (qrForm != null && qrForm.Count() > 0)
                    {
                        ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorEndereco(dadosColaborador, primeiraAberturaEndereco);
                    }
                }
            }
        }

        private void inputCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            ContinuarCadastro();
        }
    }
}
