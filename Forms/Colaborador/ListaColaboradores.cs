using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft.Forms
{
    public partial class ListaColaboradores : Form
    {
        DataGridViewRow rowData = new();
        ColaboradoresBLL bll = new();
        Funcoes funcoes = new();
        GeralBLL bllGeral = new();

        string filtro = null;

        public ListaColaboradores()
        {
            InitializeComponent();
            CarregarColaboradores();
            funcoes.dataGridViewColaboradoresClientes_AplicarCellFormatting(dataGridView);
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CriarColunaComCheckbox(dataGridView);
        }

        private void AbrirCadColaborador(bool editarColaborador)
        {
            CadColaborador frm = new(editarColaborador);
            funcoes.AbrirForms(frm, 2);
        }

        public void CarregarColaboradores()
        {
            dataGridView.DataSource = bll.MostrarColaboradores(filtro);
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else if (column.Name == "AtivoCheckBox")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }
                else if (column.Name == "Ativo")
                {
                    column.Visible = false;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (comboBoxFiltro.SelectedIndex != 0 && column.Index == 8)
                {
                    column.Visible = false;
                }
                else if (column.Index == 8)
                {
                    column.Visible = true;
                }
            }
        }

        private void PesquisarColaboradores()
        {
            dataGridView.DataSource = bll.ProcurarColaboradores(inputPesquisarColaborador.Text, filtro);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarColaboradores();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                string cellValue = dataGridView.Rows[e.RowIndex].Cells["AtivoCheckBox"].Value.ToString();

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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "AtivoCheckBox")
            {
                rowData = dataGridView.Rows[e.RowIndex];

                DataGridViewCheckBoxCell chk = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                string valor = chk.Value.ToString();
                if (valor == "S")
                {
                    bllGeral.AtivarDesativar("colaboradores", "id_colaborador", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesativar("colaboradores", "id_colaborador", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarColaboradores();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarColaboradores();
        }

        private void inputPesquisarColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarColaboradores();
            }
        }

        private void btnCadColaboradores_Click(object sender, EventArgs e)
        {
            AbrirCadColaborador(false);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowData = dataGridView.Rows[e.RowIndex];
                Parametros.idColab = int.Parse(rowData.Cells[0].Value.ToString());
                AbrirCadColaborador(true);
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
            CarregarColaboradores();
        }


    }
}