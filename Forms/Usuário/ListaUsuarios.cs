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
            dataGridView.DataSource = bll.MostrarUsuarios();
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

        private void PesquisarUsuarios()
        {
            dataGridView.DataSource = bll.ProcurarUsuarios(inputPesquisarUsuarios.Text);
        }

        private void ListaUsuarios_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EditarUsuarios(object sender, DataGridViewCellEventArgs e)
        {
            rowData = dataGridView.Rows[e.RowIndex];
            Parametros.idUserEdit = int.Parse(rowData.Cells[0].Value.ToString());
            Parametros.nomeUserEdit = rowData.Cells[1].Value.ToString();
            Parametros.cargoUserEdit = rowData.Cells[2].Value.ToString();
            Parametros.colaboradorUserEdit = rowData.Cells[3].Value.ToString();
            AbrirCadUsuario(true);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PesquisarUsuarios();
        }
    }
}