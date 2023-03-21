using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft.Forms
{
    public partial class ListaFornecedores : Form
    {
        DataGridViewRow rowData = new();
        FornecedoresBLL bll = new();
        Funcoes funcoes = new();

        string filtro = null;
        public ListaFornecedores()
        {
            InitializeComponent();
            CarregarFornecedores();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void AbrirCadFornecedor(bool editarFornecedor)
        {
            CadFornecedor frm = new(editarFornecedor);
            funcoes.AbrirForms(frm, 2);
        }

        public void CarregarFornecedores()
        {
            dataGridView.DataSource = bll.MostrarFornecedores(filtro);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else if (column.Index == 2)
                {
                    column.HeaderText = "Razão Social";
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void PesquisarFornecedores()
        {
            dataGridView.DataSource = bll.ProcurarFornecedores(inputPesquisarColaborador.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarFornecedores();
        }

        private void btnCadFornecedores_Click(object sender, EventArgs e)
        {
            AbrirCadFornecedor(false);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowData = dataGridView.Rows[e.RowIndex];
                Parametros.idFornecedor = int.Parse(rowData.Cells[0].Value.ToString());
                AbrirCadFornecedor(true);
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
            CarregarFornecedores();
        }

        private void inputPesquisarColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarFornecedores();
            }
        }
    }
}