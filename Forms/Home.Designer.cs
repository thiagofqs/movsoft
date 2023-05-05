namespace MovSoft
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pnlHome = new Panel();
            pnlMain = new Panel();
            txtMovSoft = new Label();
            pnlHeader = new Panel();
            kryptonTextBoxCargo = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxUsuario = new Krypton.Toolkit.KryptonTextBox();
            menu = new MenuStrip();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            colaboradoresToolStripMenuItem = new ToolStripMenuItem();
            clientesFornecedoresToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            produçãoToolStripMenuItem = new ToolStripMenuItem();
            gruposToolStripMenuItem = new ToolStripMenuItem();
            insumosToolStripMenuItem = new ToolStripMenuItem();
            componentesToolStripMenuItem = new ToolStripMenuItem();
            opcionaisToolStripMenuItem = new ToolStripMenuItem();
            produtosFinaisToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem1 = new ToolStripMenuItem();
            entradaSaídaToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            menuSaida = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            pnlHome.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            menu.SuspendLayout();
            menuSaida.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHome
            // 
            pnlHome.Controls.Add(pnlMain);
            pnlHome.Controls.Add(pnlHeader);
            pnlHome.Dock = DockStyle.Fill;
            pnlHome.Location = new Point(0, 0);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(930, 600);
            pnlHome.TabIndex = 2;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(txtMovSoft);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.ForeColor = Color.WhiteSmoke;
            pnlMain.Location = new Point(0, 97);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(930, 503);
            pnlMain.TabIndex = 2;
            // 
            // txtMovSoft
            // 
            txtMovSoft.Anchor = AnchorStyles.None;
            txtMovSoft.AutoSize = true;
            txtMovSoft.BackColor = Color.Transparent;
            txtMovSoft.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            txtMovSoft.ForeColor = Color.WhiteSmoke;
            txtMovSoft.Location = new Point(309, 194);
            txtMovSoft.Name = "txtMovSoft";
            txtMovSoft.Size = new Size(297, 86);
            txtMovSoft.TabIndex = 0;
            txtMovSoft.Text = "MovSoft";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(114, 101, 75);
            pnlHeader.Controls.Add(kryptonTextBoxCargo);
            pnlHeader.Controls.Add(kryptonTextBoxUsuario);
            pnlHeader.Controls.Add(menu);
            pnlHeader.Controls.Add(menuSaida);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = Color.FromArgb(56, 56, 56);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.MaximumSize = new Size(0, 97);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(930, 97);
            pnlHeader.TabIndex = 2;
            // 
            // kryptonTextBoxCargo
            // 
            kryptonTextBoxCargo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonTextBoxCargo.Enabled = false;
            kryptonTextBoxCargo.Location = new Point(610, 51);
            kryptonTextBoxCargo.Name = "kryptonTextBoxCargo";
            kryptonTextBoxCargo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonTextBoxCargo.ReadOnly = true;
            kryptonTextBoxCargo.Size = new Size(205, 29);
            kryptonTextBoxCargo.StateCommon.Border.Color1 = Color.WhiteSmoke;
            kryptonTextBoxCargo.StateCommon.Border.Color2 = Color.WhiteSmoke;
            kryptonTextBoxCargo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBoxCargo.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxCargo.StateCommon.Border.Rounding = 8F;
            kryptonTextBoxCargo.StateCommon.Border.Width = 1;
            kryptonTextBoxCargo.StateCommon.Content.Color1 = Color.FromArgb(56, 56, 56);
            kryptonTextBoxCargo.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonTextBoxCargo.TabIndex = 0;
            kryptonTextBoxCargo.Text = "Cargo:";
            // 
            // kryptonTextBoxUsuario
            // 
            kryptonTextBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonTextBoxUsuario.Enabled = false;
            kryptonTextBoxUsuario.Location = new Point(610, 18);
            kryptonTextBoxUsuario.Name = "kryptonTextBoxUsuario";
            kryptonTextBoxUsuario.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonTextBoxUsuario.ReadOnly = true;
            kryptonTextBoxUsuario.Size = new Size(205, 29);
            kryptonTextBoxUsuario.StateCommon.Border.Color1 = Color.WhiteSmoke;
            kryptonTextBoxUsuario.StateCommon.Border.Color2 = Color.WhiteSmoke;
            kryptonTextBoxUsuario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBoxUsuario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxUsuario.StateCommon.Border.Rounding = 8F;
            kryptonTextBoxUsuario.StateCommon.Border.Width = 1;
            kryptonTextBoxUsuario.StateCommon.Content.Color1 = Color.FromArgb(56, 56, 56);
            kryptonTextBoxUsuario.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonTextBoxUsuario.TabIndex = 0;
            kryptonTextBoxUsuario.Text = "Usuário:";
            // 
            // menu
            // 
            menu.Anchor = AnchorStyles.None;
            menu.AutoSize = false;
            menu.BackColor = Color.FromArgb(114, 101, 75);
            menu.Dock = DockStyle.None;
            menu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem, clientesFornecedoresToolStripMenuItem, produçãoToolStripMenuItem, produtoToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(0, 2, 0, 2);
            menu.Size = new Size(585, 97);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, colaboradoresToolStripMenuItem });
            usuárioToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usuárioToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            usuárioToolStripMenuItem.Image = (Image)resources.GetObject("usuárioToolStripMenuItem.Image");
            usuárioToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Padding = new Padding(10);
            usuárioToolStripMenuItem.Size = new Size(93, 93);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            usuariosToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(191, 26);
            usuariosToolStripMenuItem.Text = "Usuários";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // colaboradoresToolStripMenuItem
            // 
            colaboradoresToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            colaboradoresToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            colaboradoresToolStripMenuItem.Size = new Size(191, 26);
            colaboradoresToolStripMenuItem.Text = "Colaboradores";
            colaboradoresToolStripMenuItem.Click += colaboradoresToolStripMenuItem_Click;
            // 
            // clientesFornecedoresToolStripMenuItem
            // 
            clientesFornecedoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, fornecedoresToolStripMenuItem });
            clientesFornecedoresToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientesFornecedoresToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            clientesFornecedoresToolStripMenuItem.Image = (Image)resources.GetObject("clientesFornecedoresToolStripMenuItem.Image");
            clientesFornecedoresToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            clientesFornecedoresToolStripMenuItem.Name = "clientesFornecedoresToolStripMenuItem";
            clientesFornecedoresToolStripMenuItem.Padding = new Padding(10);
            clientesFornecedoresToolStripMenuItem.Size = new Size(204, 93);
            clientesFornecedoresToolStripMenuItem.Text = "Clientes/Fornecedores";
            clientesFornecedoresToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            clientesToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(182, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            fornecedoresToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(182, 26);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += fornecedoresToolStripMenuItem_Click;
            // 
            // produçãoToolStripMenuItem
            // 
            produçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gruposToolStripMenuItem, insumosToolStripMenuItem, produtosFinaisToolStripMenuItem });
            produçãoToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            produçãoToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            produçãoToolStripMenuItem.Image = (Image)resources.GetObject("produçãoToolStripMenuItem.Image");
            produçãoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            produçãoToolStripMenuItem.Padding = new Padding(10);
            produçãoToolStripMenuItem.Size = new Size(107, 93);
            produçãoToolStripMenuItem.Text = "Produção";
            produçãoToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // gruposToolStripMenuItem
            // 
            gruposToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            gruposToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            gruposToolStripMenuItem.Size = new Size(180, 22);
            gruposToolStripMenuItem.Text = "Grupos";
            gruposToolStripMenuItem.Click += gruposToolStripMenuItem_Click;
            // 
            // insumosToolStripMenuItem
            // 
            insumosToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            insumosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { componentesToolStripMenuItem, opcionaisToolStripMenuItem });
            insumosToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            insumosToolStripMenuItem.Size = new Size(180, 22);
            insumosToolStripMenuItem.Text = "Insumos";
            // 
            // componentesToolStripMenuItem
            // 
            componentesToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            componentesToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            componentesToolStripMenuItem.Size = new Size(149, 22);
            componentesToolStripMenuItem.Text = "Componentes";
            componentesToolStripMenuItem.Click += componentesToolStripMenuItem_Click;
            // 
            // opcionaisToolStripMenuItem
            // 
            opcionaisToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            opcionaisToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            opcionaisToolStripMenuItem.Name = "opcionaisToolStripMenuItem";
            opcionaisToolStripMenuItem.Size = new Size(149, 22);
            opcionaisToolStripMenuItem.Text = "Opcionais";
            opcionaisToolStripMenuItem.Click += opcionaisToolStripMenuItem_Click;
            // 
            // produtosFinaisToolStripMenuItem
            // 
            produtosFinaisToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            produtosFinaisToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            produtosFinaisToolStripMenuItem.Name = "produtosFinaisToolStripMenuItem";
            produtosFinaisToolStripMenuItem.Size = new Size(180, 22);
            produtosFinaisToolStripMenuItem.Text = "Produtos finais";
            produtosFinaisToolStripMenuItem.Click += produtosFinaisToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estoqueToolStripMenuItem, vendaToolStripMenuItem });
            produtoToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            produtoToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            produtoToolStripMenuItem.Image = (Image)resources.GetObject("produtoToolStripMenuItem.Image");
            produtoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Padding = new Padding(10);
            produtoToolStripMenuItem.Size = new Size(96, 93);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estoqueToolStripMenuItem1, entradaSaídaToolStripMenuItem });
            estoqueToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(141, 26);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // estoqueToolStripMenuItem1
            // 
            estoqueToolStripMenuItem1.BackColor = Color.FromArgb(114, 101, 75);
            estoqueToolStripMenuItem1.ForeColor = Color.WhiteSmoke;
            estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            estoqueToolStripMenuItem1.Size = new Size(188, 26);
            estoqueToolStripMenuItem1.Text = "Estoque";
            estoqueToolStripMenuItem1.Click += estoqueToolStripMenuItem1_Click;
            // 
            // entradaSaídaToolStripMenuItem
            // 
            entradaSaídaToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            entradaSaídaToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            entradaSaídaToolStripMenuItem.Name = "entradaSaídaToolStripMenuItem";
            entradaSaídaToolStripMenuItem.Size = new Size(188, 26);
            entradaSaídaToolStripMenuItem.Text = "Entrada/Saída";
            entradaSaídaToolStripMenuItem.Click += entradaSaídaToolStripMenuItem_Click;
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            vendaToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(141, 26);
            vendaToolStripMenuItem.Text = "Venda";
            vendaToolStripMenuItem.Click += vendaToolStripMenuItem_Click;
            // 
            // menuSaida
            // 
            menuSaida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuSaida.AutoSize = false;
            menuSaida.BackColor = Color.FromArgb(114, 101, 75);
            menuSaida.Dock = DockStyle.None;
            menuSaida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuSaida.ImageScalingSize = new Size(20, 20);
            menuSaida.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuSaida.Location = new Point(736, 0);
            menuSaida.Name = "menuSaida";
            menuSaida.Padding = new Padding(0, 2, 0, 2);
            menuSaida.Size = new Size(194, 97);
            menuSaida.TabIndex = 3;
            menuSaida.Text = "menuSaida";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            sairToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sairToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            sairToolStripMenuItem.Image = Properties.Resources.icon_logout;
            sairToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Padding = new Padding(10);
            sairToolStripMenuItem.Size = new Size(72, 93);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(930, 600);
            Controls.Add(pnlHome);
            ForeColor = Color.WhiteSmoke;
            MainMenuStrip = menu;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Página Inicial";
            WindowState = FormWindowState.Maximized;
            pnlHome.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            menuSaida.ResumeLayout(false);
            menuSaida.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHome;
        private MenuStrip menu;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem colaboradoresToolStripMenuItem;
        private ToolStripMenuItem clientesFornecedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem produçãoToolStripMenuItem;
        private ToolStripMenuItem gruposToolStripMenuItem;
        private ToolStripMenuItem insumosToolStripMenuItem;
        private ToolStripMenuItem produtosFinaisToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Panel pnlHeader;
        private MenuStrip menuSaida;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label txtMovSoft;
        private ToolStripMenuItem componentesToolStripMenuItem;
        private ToolStripMenuItem opcionaisToolStripMenuItem;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxUsuario;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxCargo;
        private ToolStripMenuItem estoqueToolStripMenuItem1;
        private ToolStripMenuItem entradaSaídaToolStripMenuItem;
        protected Panel pnlMain;
    }
}