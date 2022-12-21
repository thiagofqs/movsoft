using MovSoft.CODE.BLL;

namespace MovSoft
{
    public partial class ListaClientes : Form
    {
        private int idCliente;
        DataGridViewRow rowData = new();
        ColaboradoresBLL bll = new();
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void AbrirCadClientes()
        {
            CadCliente frm = new();
            frm.ShowDialog();
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            AbrirCadClientes();
        }
    }
}
