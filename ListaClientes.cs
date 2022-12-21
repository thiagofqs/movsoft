namespace MovSoft
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void AbrirCadCliente()
        {
            CadCliente frm = new();
            frm.ShowDialog();
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            AbrirCadCliente();
        }
    }
}
