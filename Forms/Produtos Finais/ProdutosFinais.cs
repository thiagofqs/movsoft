namespace MovSoft.Forms
{
    public partial class ProdutosFinais : Form
    {
        public ProdutosFinais()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
            tabControlProdutos.Left = (Width - tabControlProdutos.Width) / 2;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponível!");
        }
    }
}
