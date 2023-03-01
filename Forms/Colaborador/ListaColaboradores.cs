using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft
{
    public partial class ListaColaboradores : Form
    {
        DataGridViewRow rowData = new();
        ColaboradoresBLL bll = new();
        Funcoes funcoes = new();

        public ListaColaboradores()
        {
            InitializeComponent();
            CarregarColaboradores();
            funcoes.dataGridView_AplicarCellFormatting(dataGridView);
        }

        private void btnCadColaboradores_Click(object sender, EventArgs e)
        {
            AbrirCadColaborador(false);
        }

        private void AbrirCadColaborador(bool editarColaborador)
        {
            CadColaborador frm = new(editarColaborador);
            funcoes.AbrirForms(frm, 2);
        }

        public void CarregarColaboradores()
        {
            dataGridView.DataSource = bll.MostrarColaboradores();
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

        private void PesquisarColaboradores()
        {
            dataGridView.DataSource = bll.ProcurarColaboradores(inputPesquisarColaborador.Text);
        }

        private void ListaColaboradores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarColaboradores();
            }
        }

        private void EditarColaboradores(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                rowData = dataGridView.Rows[e.RowIndex];
                Parametros.idColab = int.Parse(rowData.Cells[0].Value.ToString());
                AbrirCadColaborador(true);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarColaboradores();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = funcoes.GridViewMascaraCPF(e.Value.ToString());
                e.FormattingApplied = true;
            }
            if(e.ColumnIndex == 2)
            {
                e.Value = funcoes.GridViewMascaraCelular(e.Value.ToString());
                e.FormattingApplied = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PesquisarColaboradores();
        }
    }
}