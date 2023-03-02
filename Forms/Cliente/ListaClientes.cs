using MovSoft.Classes;
using MovSoft.CODE.BLL;
using Mysqlx.Crud;
using Mysqlx.Resultset;

namespace MovSoft
{
    public partial class ListaClientes : Form
    {
        ClientesBLL bll = new();
        Funcoes funcoes = new();
        DataGridViewRow rowData = new();
        public ListaClientes()
        {
            InitializeComponent();
            CarregarClientes();
            funcoes.dataGridView_AplicarCellFormatting(dataGridView);
        }

        private void AbrirCadCliente(bool editarCliente)
        {
            CadCliente frm = new(editarCliente);
            funcoes.AbrirForms(frm, 1);
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            AbrirCadCliente(false);
        }

        private void PesquisarClientes()
        {
            dataGridView.DataSource = bll.ProcurarClientes(inputPesquisarClientes.Text);
        }

        public void CarregarClientes()
        {
            dataGridView.DataSource = bll.MostrarClientes();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        private void EditarClientes(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowData = dataGridView.Rows[e.RowIndex];
                Parametros.idCliente = int.Parse(rowData.Cells[0].Value.ToString());
                AbrirCadCliente(true);
            }
        }

        private void ListaColaboradores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarClientes();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PesquisarClientes();
        }
    }
}