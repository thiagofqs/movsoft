namespace MovSoft
{
    public partial class ListaFornecedores : Form
    {
        public ListaFornecedores()
        {
            InitializeComponent();
        }

        private void AbrirCadFornecedor()
        {
            CadFornecedor frm = new();
            frm.ShowDialog();
        }

        private void btnCadFornecedores_Click(object sender, EventArgs e)
        {
            AbrirCadFornecedor();
        }
    }
}
