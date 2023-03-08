using MovSoft.Classes;
using MovSoft.CODE.BLL;

namespace MovSoft
{
    public partial class ListaUsuarios : Form
    {
        UsuariosBLL bll = new();
        DataGridViewRow rowData = new();
        Funcoes funcoes = new();

        public ListaUsuarios()
        {
            InitializeComponent();
            CarregarUsuarios();
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
            dataGridViewUsuarios.DataSource = bll.MostrarUsuarios();
            foreach (DataGridViewColumn column in dataGridViewUsuarios.Columns)
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

        private void PesquisarUsuarios()
        {
            dataGridViewUsuarios.DataSource = bll.ProcurarUsuarios(inputPesquisarUsuarios.Text);
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
                Parametros.nomeUserEdit = rowData.Cells[1].Value.ToString();
                Parametros.cargoUserEdit = rowData.Cells[2].Value.ToString();
                Parametros.colaboradorUserEdit = rowData.Cells[3].Value.ToString();
                AbrirCadUsuario(true);
            }
        }
    }
}