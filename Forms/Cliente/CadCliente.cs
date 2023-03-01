using MovSoft.Classes;

namespace MovSoft
{
    public partial class CadCliente : Form
    {
        Funcoes funcoes = new();
        public Form activeForm;

        public CadCliente(bool editar)
        {
            InitializeComponent();
            bool primeiraAbertura = true;
            CadClientePessoal cadClientePessoal = new(primeiraAbertura, editar);
            funcoes.OpenChildForm(cadClientePessoal, activeForm, pnlMain, 1);
            if (editar == true)
            {
                AbrirTelaCadClientePessoal(primeiraAbertura, editar);
            }
        }

        public void AbrirTelaCadClientePessoal(bool primeiraAbertura, bool editar)
        {
            CadClientePessoal cadClientesPessoal = new(primeiraAbertura, editar);
            funcoes.OpenChildForm(cadClientesPessoal, activeForm, pnlMain, 1);
        }

        public void AbrirTelaCadClienteEndereco(bool primeiraAbertura, bool editar)
        {
            CadClienteEndereco cadClientesEndereco = new(primeiraAbertura,editar);
            funcoes.OpenChildForm(cadClientesEndereco, activeForm, pnlMain, 1);
        }
    }
}