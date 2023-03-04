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
            txtCargo = new Label();
            txtUsuario = new Label();
            pnlHome = new Panel();
            pnlMain = new Panel();
            txtMovSoft = new Label();
            pnlHeader = new Panel();
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
            opcionasToolStripMenuItem = new ToolStripMenuItem();
            produtosFinaisToolStripMenuItem = new ToolStripMenuItem();
            processosToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            gestorToolStripMenuItem = new ToolStripMenuItem();
            ensaiosProvisaoToolStripMenuItem = new ToolStripMenuItem();
            financasToolStripMenuItem = new ToolStripMenuItem();
            analiseDeDadosToolStripMenuItem = new ToolStripMenuItem();
            painelDeControleToolStripMenuItem = new ToolStripMenuItem();
            pnlCargo = new Panel();
            pnlUsuario = new Panel();
            menuSaida = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            pnlHome.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            menu.SuspendLayout();
            pnlCargo.SuspendLayout();
            pnlUsuario.SuspendLayout();
            menuSaida.SuspendLayout();
            SuspendLayout();
            // 
            // txtCargo
            // 
            txtCargo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCargo.AutoSize = true;
            txtCargo.BackColor = Color.WhiteSmoke;
            txtCargo.ForeColor = Color.FromArgb(56, 56, 56);
            txtCargo.Location = new Point(0, -1);
            txtCargo.Name = "txtCargo";
            txtCargo.Padding = new Padding(5);
            txtCargo.Size = new Size(55, 25);
            txtCargo.TabIndex = 4;
            txtCargo.Text = "Cargo: ";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtUsuario.AutoSize = true;
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(56, 56, 56);
            txtUsuario.Location = new Point(0, -1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(5);
            txtUsuario.Size = new Size(65, 25);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "Usuário: ";
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
            pnlMain.ForeColor = Color.FromArgb(56, 56, 56);
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
            pnlHeader.Controls.Add(menu);
            pnlHeader.Controls.Add(pnlCargo);
            pnlHeader.Controls.Add(pnlUsuario);
            pnlHeader.Controls.Add(menuSaida);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = Color.FromArgb(56, 56, 56);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(930, 97);
            pnlHeader.TabIndex = 2;
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.FromArgb(114, 101, 75);
            menu.Dock = DockStyle.None;
            menu.Items.AddRange(new ToolStripItem[] { usuárioToolStripMenuItem, clientesFornecedoresToolStripMenuItem, produçãoToolStripMenuItem, produtoToolStripMenuItem, gestorToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(0, 2, 0, 2);
            menu.Size = new Size(591, 97);
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
            usuariosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // colaboradoresToolStripMenuItem
            // 
            colaboradoresToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            colaboradoresToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            colaboradoresToolStripMenuItem.Size = new Size(191, 26);
            colaboradoresToolStripMenuItem.Text = "Colaboradores";
            colaboradoresToolStripMenuItem.Click += colaboradoresToolStripMenuItem_Click_1;
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
            produçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gruposToolStripMenuItem, insumosToolStripMenuItem, produtosFinaisToolStripMenuItem, processosToolStripMenuItem });
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
            gruposToolStripMenuItem.Size = new Size(195, 26);
            gruposToolStripMenuItem.Text = "Grupos";
            gruposToolStripMenuItem.Click += confecçãoToolStripMenuItem_Click;
            // 
            // insumosToolStripMenuItem
            // 
            insumosToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            insumosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { componentesToolStripMenuItem, opcionasToolStripMenuItem });
            insumosToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            insumosToolStripMenuItem.Size = new Size(195, 26);
            insumosToolStripMenuItem.Text = "Insumos";
            // 
            // componentesToolStripMenuItem
            // 
            componentesToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            componentesToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            componentesToolStripMenuItem.Size = new Size(186, 26);
            componentesToolStripMenuItem.Text = "Componentes";
            // 
            // opcionasToolStripMenuItem
            // 
            opcionasToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            opcionasToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            opcionasToolStripMenuItem.Name = "opcionasToolStripMenuItem";
            opcionasToolStripMenuItem.Size = new Size(186, 26);
            opcionasToolStripMenuItem.Text = "Opcionas";
            // 
            // produtosFinaisToolStripMenuItem
            // 
            produtosFinaisToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            produtosFinaisToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            produtosFinaisToolStripMenuItem.Name = "produtosFinaisToolStripMenuItem";
            produtosFinaisToolStripMenuItem.Size = new Size(195, 26);
            produtosFinaisToolStripMenuItem.Text = "Produtos finais";
            // 
            // processosToolStripMenuItem
            // 
            processosToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            processosToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            processosToolStripMenuItem.Size = new Size(195, 26);
            processosToolStripMenuItem.Text = "Processos";
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
            estoqueToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(141, 26);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            vendaToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(141, 26);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // gestorToolStripMenuItem
            // 
            gestorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ensaiosProvisaoToolStripMenuItem, financasToolStripMenuItem, analiseDeDadosToolStripMenuItem, painelDeControleToolStripMenuItem });
            gestorToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gestorToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            gestorToolStripMenuItem.Image = (Image)resources.GetObject("gestorToolStripMenuItem.Image");
            gestorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            gestorToolStripMenuItem.Name = "gestorToolStripMenuItem";
            gestorToolStripMenuItem.Padding = new Padding(10);
            gestorToolStripMenuItem.Size = new Size(83, 93);
            gestorToolStripMenuItem.Text = "Gestor";
            gestorToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ensaiosProvisaoToolStripMenuItem
            // 
            ensaiosProvisaoToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            ensaiosProvisaoToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            ensaiosProvisaoToolStripMenuItem.Name = "ensaiosProvisaoToolStripMenuItem";
            ensaiosProvisaoToolStripMenuItem.Size = new Size(219, 26);
            ensaiosProvisaoToolStripMenuItem.Text = "Ensaios/Provisão";
            // 
            // financasToolStripMenuItem
            // 
            financasToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            financasToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            financasToolStripMenuItem.Name = "financasToolStripMenuItem";
            financasToolStripMenuItem.Size = new Size(219, 26);
            financasToolStripMenuItem.Text = "Finanças";
            // 
            // analiseDeDadosToolStripMenuItem
            // 
            analiseDeDadosToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            analiseDeDadosToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            analiseDeDadosToolStripMenuItem.Name = "analiseDeDadosToolStripMenuItem";
            analiseDeDadosToolStripMenuItem.Size = new Size(219, 26);
            analiseDeDadosToolStripMenuItem.Text = "Análise de dados";
            // 
            // painelDeControleToolStripMenuItem
            // 
            painelDeControleToolStripMenuItem.BackColor = Color.FromArgb(114, 101, 75);
            painelDeControleToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            painelDeControleToolStripMenuItem.Name = "painelDeControleToolStripMenuItem";
            painelDeControleToolStripMenuItem.Size = new Size(219, 26);
            painelDeControleToolStripMenuItem.Text = "Painel de controle";
            // 
            // pnlCargo
            // 
            pnlCargo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlCargo.BackColor = Color.WhiteSmoke;
            pnlCargo.Controls.Add(txtCargo);
            pnlCargo.Location = new Point(593, 50);
            pnlCargo.Name = "pnlCargo";
            pnlCargo.Size = new Size(200, 25);
            pnlCargo.TabIndex = 5;
            // 
            // pnlUsuario
            // 
            pnlUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUsuario.BackColor = Color.WhiteSmoke;
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(593, 20);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(200, 25);
            pnlUsuario.TabIndex = 3;
            // 
            // menuSaida
            // 
            menuSaida.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuSaida.AutoSize = false;
            menuSaida.BackColor = Color.FromArgb(114, 101, 75);
            menuSaida.Dock = DockStyle.None;
            menuSaida.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuSaida.ImeMode = ImeMode.NoControl;
            menuSaida.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuSaida.Location = new Point(862, 0);
            menuSaida.Name = "menuSaida";
            menuSaida.Padding = new Padding(0, 2, 0, 2);
            menuSaida.Size = new Size(68, 97);
            menuSaida.TabIndex = 3;
            menuSaida.Text = "menuSaida";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            sairToolStripMenuItem.AutoSize = false;
            sairToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sairToolStripMenuItem.ForeColor = Color.WhiteSmoke;
            sairToolStripMenuItem.Image = Properties.Resources.icon_logout;
            sairToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Padding = new Padding(10);
            sairToolStripMenuItem.Size = new Size(60, 93);
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
            MainMenuStrip = menu;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Página Inicial";
            WindowState = FormWindowState.Maximized;
            pnlHome.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlHeader.ResumeLayout(false);
            menu.ResumeLayout(false);
            menu.PerformLayout();
            pnlCargo.ResumeLayout(false);
            pnlCargo.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            menuSaida.ResumeLayout(false);
            menuSaida.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHome;
        private Label txtCargo;
        private Label txtUsuario;
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
        private ToolStripMenuItem processosToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem gestorToolStripMenuItem;
        private ToolStripMenuItem ensaiosProvisaoToolStripMenuItem;
        private ToolStripMenuItem financasToolStripMenuItem;
        private ToolStripMenuItem analiseDeDadosToolStripMenuItem;
        private ToolStripMenuItem painelDeControleToolStripMenuItem;
        private Panel pnlMain;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem componentesToolStripMenuItem;
        private ToolStripMenuItem opcionasToolStripMenuItem;
        private Panel pnlHeader;
        private MenuStrip menuSaida;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Panel pnlUsuario;
        private Panel pnlCargo;
        private Label txtMovSoft;
    }
}