using CRUD.CODE.BLL;

namespace MovSoft
{
    public partial class CadColaborador : Form
    {
        ColaboradoresBLL colaboradoresBLL = new();
        CadColaboradorEndereco.Endereco enderecoColaborador = new();
        CadColaboradorPessoal.Dados dadosColaborador = new();
        public Form activeForm;

        public CadColaborador(bool editarColaboradorRetornado, int idColaborador)
        {
            InitializeComponent();
            bool primeiraAbertura = true;
            bool editarColaborador = false;
            CadColaboradorPessoal cadColaboradorPessoal = new(dadosColaborador, primeiraAbertura, editarColaborador, enderecoColaborador);
            OpenChildForm(cadColaboradorPessoal);
            if(editarColaboradorRetornado == true)
            {
                dadosColaborador = colaboradoresBLL.PegarDados(idColaborador);
                enderecoColaborador = colaboradoresBLL.PegarEndereco(idColaborador);
                AbrirTelaCadColaboradorPessoalEditar(dadosColaborador);
            }
        }

        public void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void AbrirTelaCadColaboradorPessoal(CadColaboradorEndereco.Endereco endereco)
        {
            enderecoColaborador = endereco;
            CadColaboradorPessoal cadColaboradorPessoal = new(dadosColaborador, false, false,enderecoColaborador);
            OpenChildForm(cadColaboradorPessoal);
        }

        public void AbrirTelaCadColaboradorEndereco(CadColaboradorPessoal.Dados dados, bool primeiraAbertura)
        {
            dadosColaborador = dados;
            CadColaboradorEndereco cadColaboradorEndereco = new(dadosColaborador, primeiraAbertura, enderecoColaborador, false);
            OpenChildForm(cadColaboradorEndereco);
        }

        public void AbrirTelaCadColaboradorPessoalEditar(CadColaboradorPessoal.Dados dados)
        {
            dadosColaborador = dados;
            CadColaboradorPessoal cadColaboradorPessoal = new(dados, true, true, enderecoColaborador);
            OpenChildForm(cadColaboradorPessoal);
        }
        public void AbrirTelaCadColaboradorEnderecoEditar(CadColaboradorPessoal.Dados dados, CadColaboradorEndereco.Endereco endereco)
        {
            CadColaboradorEndereco cadColaboradorEndereco = new(dados, true, endereco, true);
            OpenChildForm(cadColaboradorEndereco);
        }
    }
}