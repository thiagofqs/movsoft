using MovSoft.Classes;
using MovSoft.CODE.BLL;
using System.Windows.Forms;

namespace MovSoft.Forms
{
    public partial class ListaUsuarios : Form
    {
        UsuariosBLL bll = new();
        DataGridViewRow rowData = new();
        Funcoes funcoes = new();
        GeralBLL bllGeral = new();

        string filtro = null;

        public ListaUsuarios()
        {
            InitializeComponent();
            CarregarUsuarios();
            funcoes.CriarColunaComCheckbox(dataGridViewUsuarios);
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void AbrirCadUsuario(bool editarUsuario)
        {
            if (editarUsuario)
            {
                Parametros.editarUser = true;
            }
            else
            {
                Parametros.editarUser = false;
            }
            CadUsuario frm = new();
            funcoes.AbrirForms(frm, 2);
        }

        public void CarregarUsuarios()
        {
            dataGridViewUsuarios.DataSource = bll.MostrarUsuarios(filtro);
            FormatarGridView();
        }

        private void FormatarGridView()
        {
            foreach (DataGridViewColumn column in dataGridViewUsuarios.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else if (column.Name == "AtivoCheckBox")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }
                else if(column.Name == "Ativo")
                {
                    column.Visible = false;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (comboBoxFiltro.SelectedIndex != 0 && column.Index == 5)
                {
                    column.Visible = false;
                }
                else if (column.Index == 5)
                {
                    column.Visible = true;
                }
            }
        }

        private void PesquisarUsuarios()
        {
            comboBoxFiltro.SelectedIndex = 0;
            dataGridViewUsuarios.DataSource = bll.ProcurarUsuarios(inputPesquisarUsuarios.Text);
            FormatarGridView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarUsuarios();
        }

        private void inputPesquisarUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarUsuarios();
            }
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            AbrirCadUsuario(false);
        }

        private void dataGridViewUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowData = dataGridViewUsuarios.Rows[e.RowIndex];
                Parametros.idUserEdit = int.Parse(rowData.Cells[0].Value.ToString());
                bll.PegarDados((int)Parametros.idUserEdit);
                AbrirCadUsuario(true);
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
            CarregarUsuarios();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewUsuarios.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                if(e.Value != null)
                {
                    string cellValue = dataGridViewUsuarios.Rows[e.RowIndex].Cells["AtivoCheckBox"].Value.ToString();

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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsuarios.Columns[e.ColumnIndex].Name == "AtivoCheckBox")
            {
                rowData = dataGridViewUsuarios.Rows[e.RowIndex];
                DataGridViewCheckBoxCell chk = dataGridViewUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                string valor = chk.Value.ToString();
                if (valor == "S")
                {
                    bllGeral.AtivarDesativar("usuarios", "id_usuario", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesativar("usuarios", "id_usuario", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarUsuarios();
            }
        }
    }
}