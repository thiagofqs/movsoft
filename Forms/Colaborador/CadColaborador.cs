using MovSoft.Classes;

namespace MovSoft
{
    public partial class CadColaborador : Form
    {
        Funcoes funcoes = new();
        public Form activeForm;

        public CadColaborador(bool editar)
        {
            InitializeComponent();
            bool primeiraAbertura = true;
            CadColaboradorPessoal cadColaboradorPessoal = new(primeiraAbertura, editar);
            funcoes.OpenChildForm(cadColaboradorPessoal, activeForm, pnlMain, 1);
            if(editar == true)
            {
                AbrirTelaCadColaboradorPessoal(primeiraAbertura,editar);
            }
        }

        public void AbrirTelaCadColaboradorPessoal(bool primeiraAbertura, bool editar)
        {
            CadColaboradorPessoal cadColaboradorPessoal = new(primeiraAbertura,editar);
            funcoes.OpenChildForm(cadColaboradorPessoal, activeForm, pnlMain, 2);
        }

        public void AbrirTelaCadColaboradorEndereco(bool primeiraAbertura, bool editar)
        {
            CadColaboradorEndereco cadColaboradorEndereco = new(primeiraAbertura, editar);
            funcoes.OpenChildForm(cadColaboradorEndereco, activeForm, pnlMain, 2);
        }
    }
}