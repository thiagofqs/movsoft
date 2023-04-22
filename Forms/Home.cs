using MovSoft.Classes;
using MovSoft.Forms;
using MovSoft.Forms.Estoque;

namespace MovSoft
{
    public partial class Home : Form
    {
        Funcoes funcoes = new();
        private Form activeForm;
        private EventHandler CursorHandChanger, CursorDefaultChanger;
        public Panel PnlMain { get { return pnlMain; } }

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

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 0x00A3;
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                // Impede que o double click na borda do Form maximize a janela
                return;
            }
            base.WndProc(ref m);
        }

        public Home()
        {
            InitializeComponent();
            menu.Renderer = new ToolStripProfessionalRenderer(new ownColorTable());
            menuSaida.Renderer = new ToolStripProfessionalRenderer(new ownColorTable());
            MudarCursorDoMenu();
            AdicionarNomeDoUsuarioECargo();
            AjustarCentralizarMenu();
            AjustarTamanhoInformacaoDoUsuario();
        }

        private void AjustarCentralizarMenu()
        {
            Size larguraMenu = menu.GetPreferredSize(Size.Empty);
            menu.Width = larguraMenu.Width;
            menu.Height = pnlHeader.Height;
            menu.Left = (pnlHeader.Width - menu.Width) / 2;
            menu.Top = (pnlHeader.Height - menu.Height) / 2;
            menuSaida.Left = pnlHeader.Width - menuSaida.Width;
            menuSaida.Height = pnlHeader.Height;
        }

        private void AdicionarNomeDoUsuarioECargo()
        {
            kryptonTextBoxUsuario.Text += " " + Parametros.nomeUser;
            kryptonTextBoxCargo.Text += " " + Parametros.cargoUser;
        }

        private void AjustarTamanhoInformacaoDoUsuario()
        {
            Size preferredSizeUsuario = kryptonTextBoxUsuario.GetPreferredSize(Size.Empty);
            Size preferredSizeCargo = kryptonTextBoxCargo.GetPreferredSize(Size.Empty);
            Size maiorTamanho = new Size(Math.Max(preferredSizeUsuario.Width, preferredSizeCargo.Width), Math.Max(preferredSizeUsuario.Height, preferredSizeCargo.Height));
            kryptonTextBoxUsuario.Size = maiorTamanho;
            kryptonTextBoxCargo.Size = maiorTamanho;
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
            MessageBox.Show("Essa op��o est� indispon�vel no momento!", "Op��o indispon�vel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void financasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa op��o est� indispon�vel no momento!", "Op��o indispon�vel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void painelDeControleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa op��o est� indispon�vel no momento!", "Op��o indispon�vel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa op��o est� indispon�vel no momento!", "Op��o indispon�vel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void produtosFinaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosFinais frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }

        private void analiseDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa op��o est� indispon�vel no momento!", "Op��o indispon�vel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void processosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa op��o est� indispon�vel no momento!", "Op��o indispon�vel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void opcionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opcionais frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque frm = new();
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }

        private void entradaSa�daToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricoEstoque frm = new(true);
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }

        public void abrirHistoricoEstoque(bool novoLancamentoEstoque)
        {
            HistoricoEstoque frm = new(novoLancamentoEstoque);
            funcoes.OpenChildForm(frm, activeForm, pnlMain, 4);
        }
    }
}