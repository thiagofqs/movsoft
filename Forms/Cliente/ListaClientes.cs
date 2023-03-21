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
        GeralBLL bllGeral = new();
        public ListaClientes()
        {
            InitializeComponent();
            CarregarClientes();
            funcoes.dataGridView_AplicarCellFormatting(dataGridView);
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CriarColunaComCheckbox(dataGridView);
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
                else if(column.Index == 8)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if(comboBoxFiltro.SelectedIndex != 0 && column.Index == 9)
                {
                    column.Visible = false;
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
            if (comboBoxFiltro.SelectedIndex == 0)
            {
                filtro = null;
            }
            else if (comboBoxFiltro.SelectedIndex == 1)
            {
                filtro = "S";
            }
            else
            {
                filtro = "N";
            }
            CarregarClientes();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                rowData = dataGridView.Rows[e.RowIndex];

                DataGridViewCheckBoxCell chk = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                string valor = chk.Value.ToString();
                if (valor == "S")
                {
                    bllGeral.AtivarDesetivar("clientes", "id_cliente", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesetivar("clientes", "id_cliente", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarClientes();
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView.Columns[7].Visible = false;
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                string cellValue = dataGridView.Rows[e.RowIndex].Cells["Ativo"].Value.ToString();

                if (cellValue == "S")
                {
                    e.Value = true;
                }
                else
                {
                    e.Value = false;
                }
            }
        }
    }
}