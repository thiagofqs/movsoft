using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft.Forms
{
    public partial class ListaFornecedores : Form
    {
        DataGridViewRow rowData = new();
        FornecedoresBLL bll = new();
        Funcoes funcoes = new();
        GeralBLL bllGeral = new();
        string filtro = null;
        public ListaFornecedores()
        {
            InitializeComponent();
            CarregarFornecedores();
            funcoes.dataGridViewFornecedores_AplicarCellFormatting(dataGridView);
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CriarColunaComCheckbox(dataGridView);
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
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
                if (comboBoxFiltro.SelectedIndex != 0 && column.Index == 6)
                {
                    column.Visible = false;
                }
                else if (column.Index == 6)
                {
                    column.Visible = true;
                }
            }
        }

        private void PesquisarFornecedores()
        {
            dataGridView.DataSource = bll.ProcurarFornecedores(inputPesquisarColaborador.Text, filtro);
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
            CarregarFornecedores();
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
                    bllGeral.AtivarDesativar("fornecedores", "id_fornecedor", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesativar("fornecedores", "id_fornecedor", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarFornecedores();
            }
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