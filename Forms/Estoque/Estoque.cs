using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft.Forms.Estoque
{
    public partial class Estoque : Form
    {
        DataGridViewRow rowData = new();
        EstoqueBLL bll = new();
        Funcoes funcoes = new();

        string filtro = null;

        public Estoque()
        {
            InitializeComponent();
            VerSaldoEstoque();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void abrirHistoricoEstoque(bool lancarEstoqueNovo)
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is Home
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((Home)qrForm.First()).abrirHistoricoEstoque(lancarEstoqueNovo);
            }
        }

        public void VerSaldoEstoque()
        {
            dataGridView.DataSource = bll.mostrarSaldo(filtro);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else if (column.Name == "Opcao")
                {
                    column.HeaderText = "Opção";
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void PesquisarEstoque()
        {
            dataGridView.DataSource = bll.pesquisarSaldo(comboBoxFiltro.Text.Substring(0, 1), inputPesquisarColaborador.Text);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            VerSaldoEstoque();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarEstoque();
        }

        private void inputPesquisarColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarEstoque();
            }
        }

        private void btnCadColaboradores_Click(object sender, EventArgs e)
        {
            abrirHistoricoEstoque(true);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowData = dataGridView.Rows[e.RowIndex];
                Parametros.nomeProduto = rowData.Cells[1].Value.ToString();
                Parametros.tipoItem = comboBoxFiltro.Text;
                abrirHistoricoEstoque(false);
            }
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtro = comboBoxFiltro.Text.Substring(0, 1);
            VerSaldoEstoque();
        }


    }
}