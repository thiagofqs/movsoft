using MovSoft.CODE.BLL;

namespace MovSoft
{
    public partial class ListaUsuarios : Form
    {
        UsuariosBLL bll = new();
        Permissao permissoes = new();
        DataGridViewRow rowData = new();
        private struct Permissao
        {
            public int idCargo;
            public char admin;
            public string cargo;
        }

        public ListaUsuarios(Home.Usuario usuario)
        {
            InitializeComponent();
            permissoes.idCargo = usuario.idCargo;
            permissoes.admin = usuario.admin;
            permissoes.cargo = usuario.cargo;
            CarregarUsuarios();
        }
        
        private void AbrirCadUsuario(bool editarUsuario)
        {
            CadUsuario frm = new(permissoes.idCargo, permissoes.admin, rowData, editarUsuario);
            frm.ShowDialog();
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

        private void ProcurarUsuarios()
        {
            dataGridView.DataSource = bll.ProcurarUsuarios(inputPesquisarUsuarios.Text);
        }

        private void ListaUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ProcurarUsuarios();
            }
        }

        public bool VerificarPermissao(int permissao)
        {
            bool podeAcessar;
            char permitido = bll.VerificarPermissao(permissoes.idCargo, permissao);
            if (permitido == 'S' || permissoes.admin == 'S')
            {
                podeAcessar = true;
            }
            else
            {
                podeAcessar = false;
            }
            return podeAcessar;
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            bool permitido = VerificarPermissao(3);
            if(permitido)
            {
                AbrirCadUsuario(false);
            }
            else
            {
                MessageBox.Show($"O cargo {permissoes.cargo} não tem permissão para acessar a tela Cadastro de Usuário!");
            }
        }

        private void EditarUsuarios(object sender, DataGridViewCellEventArgs e)
        {
            rowData = dataGridView.Rows[e.RowIndex];
            AbrirCadUsuario(true);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
    }
}
