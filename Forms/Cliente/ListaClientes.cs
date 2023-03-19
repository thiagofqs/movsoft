using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft.Forms
{
    public partial class ListaClientes : Form
    {
        ClientesBLL bll = new();
        Funcoes funcoes = new();
        DataGridViewRow rowData = new();
        string? filtro = null;
        public ListaClientes()
        {
            InitializeComponent();
            CarregarClientes();
            funcoes.dataGridView_AplicarCellFormatting(dataGridView);
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void AbrirCadCliente(bool editarCliente)
        {
            CadCliente frm = new(editarCliente);
            funcoes.AbrirForms(frm, 1);
        }

        private void PesquisarClientes()
        {
            dataGridView.DataSource = bll.ProcurarClientes(inputPesquisarClientes.Text);
        }

        public void CarregarClientes()
        {
            dataGridView.DataSource = bll.MostrarClientes(filtro);
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarClientes();
        }

        private void inputPesquisarClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarClientes();
            }
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            AbrirCadCliente(false);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowData = dataGridView.Rows[e.RowIndex];
                Parametros.idCliente = int.Parse(rowData.Cells[0].Value.ToString());
                AbrirCadCliente(true);
            }
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFiltro.SelectedIndex == 0)
            {
                filtro = null;
            }
            else if(comboBoxFiltro.SelectedIndex == 1)
            {
                filtro = "S";
            }
            else
            {
                filtro = "N";
            }
            CarregarClientes();
        }
    }
}