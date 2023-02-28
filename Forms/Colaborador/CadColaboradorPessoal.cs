using MovSoft.Classes;
using MovSoft.CODE.BLL;
using System.Data;

namespace MovSoft
{
    public partial class CadColaboradorPessoal : Form
    {
        Funcoes funcoes = new();
        ColaboradoresBLL colaboradoresBLL = new();
        private bool primeiraAberturaColaborador = true;
        private bool editarColaborador = false;
        public CadColaboradorPessoal(bool primeiraAbertura, bool editar)
        {
            InitializeComponent();
            RemoverMascarasDeTexto();
         
            if(primeiraAbertura == false)
            {
                primeiraAberturaColaborador = false;
                AtribuirDadosAosInputs();
            }
            else if (primeiraAbertura == true && editar == false)
            {
                Parametros parametros = new();
            }
            if(editar == true && primeiraAbertura == true)
            {
                txtTitulo.Text = "Editar Colaborador 1/2";
                colaboradoresBLL.PegarDados((int)Parametros.idColab);
                colaboradoresBLL.PegarEndereco((int)Parametros.idColab);
                editarColaborador = true;
                AtribuirDadosAosInputs();
            }
            else if(editar == true && primeiraAbertura == false)
            {
                txtTitulo.Text = "Editar Colaborador 1/2";
                editarColaborador = true;
                AtribuirDadosAosInputs();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            funcoes.RemoverMascarasDeTexto(inputCpf);
            funcoes.RemoverMascarasDeTexto(inputNascimento);
            funcoes.RemoverMascarasDeTexto(inputCelular);
        }

        private string BdDataNascimento(string data)
        {
            data = funcoes.BdDataNascimento(data);
            return data;
        }

        private void AtribuirDadosDosInputs()
        {
            Parametros.nomeColab = inputNome.Text;
            Parametros.sobrenomeColab = inputSobrenome.Text;
            Parametros.idSexoColab = inputboxSexo.SelectedIndex + 1;
            Parametros.cpfColab = inputCpf.Text;
            if(primeiraAberturaColaborador == true)
            {
                Parametros.nascimentoColab = BdDataNascimento(inputNascimento.Text);
            }
            Parametros.nascimentoInputColab = inputNascimento.Text;
            Parametros.emailColab = inputEmail.Text;
            Parametros.dddColab = inputCelular.Text.Substring(0, 2);
            Parametros.celularColab = inputCelular.Text.Substring(2, 9);
        }

        private void AtribuirDadosAosInputs()
        {
            inputNome.Text = Parametros.nomeColab;
            inputSobrenome.Text = Parametros.sobrenomeColab;
            inputboxSexo.SelectedIndex = (int)Parametros.idSexoColab - 1;
            inputCpf.Text = Parametros.cpfColab;
            inputNascimento.Text = Parametros.nascimentoInputColab;
            inputEmail.Text = Parametros.emailColab;
            inputCelular.Text = Parametros.dddColab + Parametros.celularColab;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (funcoes.ValidacaoData(inputNascimento) && funcoes.ValidacaoEmail(inputEmail) && funcoes.ValidacaoTelefone(inputCelular) && funcoes.ValidacaoCPF(inputCpf))
            {
                ContinuarCadastro();
            }
        }

        private void ContinuarCadastro()
        {
            AtribuirDadosDosInputs();
                if (editarColaborador == true)
                {
                    var qrForm = from frm in Application.OpenForms.Cast<Form>()
                                 where frm is CadColaborador
                                 select frm;
                    if (qrForm != null && qrForm.Count() > 0)
                    {
                        ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorEndereco(primeiraAberturaColaborador, editarColaborador);
                    }
                }
                else
                {
                    var qrForm = from frm in Application.OpenForms.Cast<Form>()
                                 where frm is CadColaborador
                                 select frm;
                    if (qrForm != null && qrForm.Count() > 0)
                    {
                        ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorEndereco(primeiraAberturaColaborador, editarColaborador);
                    }
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