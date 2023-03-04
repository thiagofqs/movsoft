using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft
{
    public partial class ListaFornecedores : Form
    {
        DataGridViewRow rowData = new();
        FornecedoresBLL bll = new();
        Funcoes funcoes = new();
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

        private void btnCadFornecedores_Click(object sender, EventArgs e)
        {
            AbrirCadFornecedor(false);
        }

        public void CarregarFornecedores()
        {
            dataGridView.DataSource = bll.MostrarFornecedores();
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

        private void PesquisarFornecedores()
        {
            dataGridView.DataSource = bll.ProcurarFornecedores(inputPesquisarColaborador.Text);
        }

        private void ListaFornecedores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarFornecedores();
            }
        }

        private void EditarFornecedores(object sender, DataGridViewCellEventArgs e)
        {
            rowData = dataGridView.Rows[e.RowIndex];
            Parametros.idFornecedor = int.Parse(rowData.Cells[0].Value.ToString());
            AbrirCadFornecedor(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PesquisarFornecedores();
        }
    }
}