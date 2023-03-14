using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.Forms;

namespace MovSoft
{
    public partial class Home : Form
    {
        UsuariosBLL bll = new();
        Funcoes funcoes = new();
        private Form activeForm;
        private EventHandler CursorHandChanger, CursorDefaultChanger;

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

        public Home()
        {
            InitializeComponent();
            menu.Renderer = new ToolStripProfessionalRenderer(new ownColorTable());
            menuSaida.Renderer = new ToolStripProfessionalRenderer(new ownColorTable());
            pnlUsuario.Controls.Add(txtUsuario);
            pnlCargo.Controls.Add(txtCargo);
            pnlHeader.Controls.Add(pnlUsuario);
            pnlHeader.Controls.Add(pnlCargo);
            pnlHeader.Controls.Add(menu);
            pnlHeader.Controls.Add(menuSaida);
            MudarCursorDoMenu();
            txtUsuario.Text += Parametros.nomeUser;
            txtCargo.Text += Parametros.cargoUser;
        }

        public bool VerificarPermissao(int permissao, Form forms, Form activeForm, Panel pnlMain)
        {
            bool podeAcessar;
            bll.VerificarPermissao((int)Parametros.idCargoUser, permissao);
            if (Parametros.permissaoUser == 'S' || Parametros.adminUser == 'S')
            {
                podeAcessar = true;
            }
            else
            {
                podeAcessar = false;
            }
            return podeAcessar;
        }

        private void MudarCursorDoMenu()
        {
            foreach (ToolStripMenuItem item in menu.Items)
            {
                item.MouseEnter += CursorHandChanger;
                item.MouseLeave += CursorDefaultChanger;
                foreach (ToolStripMenuItem dropItens in item.DropDownItems)
                {
                    dropItens.MouseEnter += CursorHandChanger;
                    dropItens.MouseLeave += CursorDefaultChanger;
                }
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaUsuarios frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 1);
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaColaboradores frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 2);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientes frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 1);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaFornecedores frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            funcoes.ThreadVoltarAoLogin();
        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Componentes frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }

        private void ensaiosProvisaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponível!");
        }

        private void financasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponível!");
        }

        private void painelDeControleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponível!");
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponível!");
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponível!");
        }

        private void produtosFinaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosFinais frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }

        private void analiseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponível!");
        }

        private void processosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção indisponível!");
        }

        private void opcionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcionais frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }
    }
}