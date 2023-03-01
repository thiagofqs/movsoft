using MovSoft.Classes;

namespace MovSoft
{
    public partial class CadGrupos : Form
    {
        Funcoes funcoes = new();

        public CadGrupos()
        {
            InitializeComponent();
            funcoes.PrimeiroInputEmFoco(inputNomeGrupo);
        }

        private void ContinuarCadastro()
        {
            if (inputNomeGrupo.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ContinuarCadastro();
        }
    }
}