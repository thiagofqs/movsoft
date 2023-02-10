using CRUD.CODE.BLL;

namespace MovSoft
{
    public partial class ListaColaboradores : Form
    {
        private int idColaborador;
        DataGridViewRow rowData = new();
        ColaboradoresBLL bll = new();

        public ListaColaboradores()
        {
            InitializeComponent();
            CarregarColaboradores();
        }

        private void btnCadColaboradores_Click(object sender, EventArgs e)
        {
            AbrirCadColaborador(false);
        }

        private void AbrirCadColaborador(bool editarColaborador)
        {
            CadColaborador frm = new(editarColaborador, idColaborador);
            frm.ShowDialog();
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

        private void ProcurarColaboradores()
        {
            dataGridView.DataSource = bll.ProcurarColaboradores(inputPesquisarColaborador.Text);
        }

        private void ListaColaboradores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ProcurarColaboradores();
            }
        }

        private void EditarColaboradores(object sender, DataGridViewCellEventArgs e)
        {
            rowData = dataGridView.Rows[e.RowIndex];
            idColaborador = int.Parse(rowData.Cells[0].Value.ToString());
            AbrirCadColaborador(true);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarColaboradores();
        }
    }
}
