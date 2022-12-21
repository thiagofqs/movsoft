using MovSoft.CODE.BLL;

namespace MovSoft
{
    public partial class Home : Form
    {
        UsuariosBLL bll = new();
        Thread tr;
        Usuario usuario = new();
        private Form activeForm;
        public struct Usuario
        {
            public int idCargo;
            public int idUsuario;
            public char admin;
            public string cargo;
        }

        public class ownColorTable : ProfessionalColorTable
        {
            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.FromArgb(176, 155, 113);
                }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.FromArgb(176, 155, 113);
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get 
                {
                    return Color.FromArgb(176, 155, 113); 
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get 
                {
                    return Color.FromArgb(176, 155, 113); 
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.Transparent;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Transparent;
                }
            }
        }

        public Home(Login.Usuario retornoUsuario)
        {
            InitializeComponent();
            menu.Renderer = new ToolStripProfessionalRenderer(new ownColorTable());
            MudarCursorDoMenu();
            txtUsuario.Text += retornoUsuario.usuario;
            txtCargo.Text += retornoUsuario.cargo;
            usuario.idCargo = retornoUsuario.idCargo;
            usuario.idUsuario = retornoUsuario.idUsuario;
            usuario.admin = retornoUsuario.admin;
            usuario.cargo = retornoUsuario.cargo;
        }

        public bool VerificarPermissao(int permissao)
        {
            bool podeAcessar;
            char permitido = bll.VerificarPermissao(usuario.idCargo, permissao);
            if (permitido == 'S' || usuario.admin == 'S')
            {
                podeAcessar = true;
            }
            else
            {
                podeAcessar = false;
            }
            return podeAcessar;
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarJanela_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            tr = new(AbrirJanelaLogin);
            tr.SetApartmentState(ApartmentState.STA);
            tr.Start();
        }

        private void AbrirJanelaLogin(object obj)
        {
            Application.Run(new Login());
        }

        private void OpenChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool permitido = VerificarPermissao(1);
            if(permitido == false)
            {
                MessageBox.Show($"O cargo {usuario.cargo} não tem permissão para acessar a tela Usuários");
            }
            else
            {
                ListaUsuarios frm = new(usuario); 
                OpenChildForm(frm);
            }
        }

        private void colaboradoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool permitido = VerificarPermissao(2);
            if(permitido == false)
            {
                MessageBox.Show($"O cargo {usuario.cargo} não tem permissão para acessar a tela Colaboradores");
            }
            else
            {
                ListaColaboradores frm = new();
                OpenChildForm(frm);
            }
        }

        private void CursorHandChanger(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void CursorDefaultChanger(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void MudarCursorDoMenu()
        {
            foreach(ToolStripMenuItem item in menu.Items)
            {
                item.MouseEnter += CursorHandChanger;
                item.MouseLeave += CursorDefaultChanger;
                foreach(ToolStripMenuItem dropItens in item.DropDownItems) {
                    dropItens.MouseEnter += CursorHandChanger;
                    dropItens.MouseLeave += CursorDefaultChanger;
                }
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool permitido = VerificarPermissao(1);
            if (permitido == false)
            {
                MessageBox.Show($"O cargo {usuario.cargo} não tem permissão para acessar a tela Clientes");
            }
            else
            {
                ListaClientes frm = new();
                OpenChildForm(frm);
            }
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool permitido = VerificarPermissao(1);
            if (permitido == false)
            {
                MessageBox.Show($"O cargo {usuario.cargo} não tem permissão para acessar a tela Fornecedores");
            }
            else
            {
                ListaFornecedores frm = new();
                OpenChildForm(frm);
            }
        }
    }
}