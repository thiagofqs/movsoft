namespace MovSoft
{
    public partial class CadGrupos : Form
    {
        public CadGrupos()
        {
            InitializeComponent();
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