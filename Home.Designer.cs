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
            this.pnlHeaderJanela = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMinimizarJanela = new System.Windows.Forms.Button();
            this.btnFecharJanela = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confecçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ensaiosProvisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finançasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análiseDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelDeControleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeaderJanela.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderJanela
            // 
            this.pnlHeaderJanela.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlHeaderJanela.Controls.Add(this.txtCargo);
            this.pnlHeaderJanela.Controls.Add(this.txtUsuario);
            this.pnlHeaderJanela.Controls.Add(this.btnSair);
            this.pnlHeaderJanela.Controls.Add(this.btnMinimizarJanela);
            this.pnlHeaderJanela.Controls.Add(this.btnFecharJanela);
            this.pnlHeaderJanela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderJanela.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderJanela.Name = "pnlHeaderJanela";
            this.pnlHeaderJanela.Size = new System.Drawing.Size(930, 30);
            this.pnlHeaderJanela.TabIndex = 0;
            // 
            // txtCargo
            // 
            this.txtCargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargo.AutoSize = true;
            this.txtCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.txtCargo.Location = new System.Drawing.Point(657, 15);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(45, 15);
            this.txtCargo.TabIndex = 4;
            this.txtCargo.Text = "Cargo: ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.txtUsuario.Location = new System.Drawing.Point(657, 0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(55, 15);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "Usuário: ";
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnSair.Location = new System.Drawing.Point(840, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 30);
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "<";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnMinimizarJanela
            // 
            this.btnMinimizarJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarJanela.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizarJanela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimizarJanela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnMinimizarJanela.Location = new System.Drawing.Point(870, 0);
            this.btnMinimizarJanela.Name = "btnMinimizarJanela";
            this.btnMinimizarJanela.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizarJanela.TabIndex = 0;
            this.btnMinimizarJanela.TabStop = false;
            this.btnMinimizarJanela.Text = "-";
            this.btnMinimizarJanela.UseVisualStyleBackColor = true;
            this.btnMinimizarJanela.Click += new System.EventHandler(this.btnMinimizarJanela_Click);
            // 
            // btnFecharJanela
            // 
            this.btnFecharJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharJanela.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFecharJanela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecharJanela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnFecharJanela.Location = new System.Drawing.Point(900, 0);
            this.btnFecharJanela.Name = "btnFecharJanela";
            this.btnFecharJanela.Size = new System.Drawing.Size(30, 30);
            this.btnFecharJanela.TabIndex = 0;
            this.btnFecharJanela.TabStop = false;
            this.btnFecharJanela.Text = "X";
            this.btnFecharJanela.UseVisualStyleBackColor = true;
            this.btnFecharJanela.Click += new System.EventHandler(this.btnFecharJanela_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.pnlMain);
            this.pnlHome.Controls.Add(this.menu);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHome.Location = new System.Drawing.Point(0, 30);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(930, 570);
            this.pnlHome.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 97);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(930, 473);
            this.pnlMain.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.clientesFornecedoresToolStripMenuItem,
            this.produçãoToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.gestorToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(930, 97);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.colaboradoresToolStripMenuItem});
            this.usuárioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usuárioToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usuárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuárioToolStripMenuItem.Image")));
            this.usuárioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(93, 93);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.usuáriosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.colaboradoresToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click_1);
            // 
            // clientesFornecedoresToolStripMenuItem
            // 
            this.clientesFornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.clientesFornecedoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientesFornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clientesFornecedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesFornecedoresToolStripMenuItem.Image")));
            this.clientesFornecedoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesFornecedoresToolStripMenuItem.Name = "clientesFornecedoresToolStripMenuItem";
            this.clientesFornecedoresToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.clientesFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(204, 93);
            this.clientesFornecedoresToolStripMenuItem.Text = "Clientes/Fornecedores";
            this.clientesFornecedoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.fornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // produçãoToolStripMenuItem
            // 
            this.produçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confecçãoToolStripMenuItem,
            this.insumosToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.produtoFinalToolStripMenuItem});
            this.produçãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.produçãoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.produçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produçãoToolStripMenuItem.Image")));
            this.produçãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.produçãoToolStripMenuItem.Name = "produçãoToolStripMenuItem";
            this.produçãoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.produçãoToolStripMenuItem.Size = new System.Drawing.Size(107, 93);
            this.produçãoToolStripMenuItem.Text = "Produção";
            this.produçãoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // confecçãoToolStripMenuItem
            // 
            this.confecçãoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.confecçãoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.confecçãoToolStripMenuItem.Name = "confecçãoToolStripMenuItem";
            this.confecçãoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.confecçãoToolStripMenuItem.Text = "Grupos";
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.insumosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.insumosToolStripMenuItem.Text = "Insumos";
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.gruposToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.gruposToolStripMenuItem.Text = "Confecção";
            // 
            // produtoFinalToolStripMenuItem
            // 
            this.produtoFinalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.produtoFinalToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.produtoFinalToolStripMenuItem.Name = "produtoFinalToolStripMenuItem";
            this.produtoFinalToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.produtoFinalToolStripMenuItem.Text = "Produto final";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revendaToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.vendaToolStripMenuItem});
            this.produtoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.produtoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.produtoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoToolStripMenuItem.Image")));
            this.produtoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(96, 93);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // revendaToolStripMenuItem
            // 
            this.revendaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.revendaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.revendaToolStripMenuItem.Name = "revendaToolStripMenuItem";
            this.revendaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.revendaToolStripMenuItem.Text = "Revenda";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.produtosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.vendaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // gestorToolStripMenuItem
            // 
            this.gestorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ensaiosProvisãoToolStripMenuItem,
            this.finançasToolStripMenuItem,
            this.análiseDeDadosToolStripMenuItem,
            this.painelDeControleToolStripMenuItem});
            this.gestorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gestorToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gestorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gestorToolStripMenuItem.Image")));
            this.gestorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.gestorToolStripMenuItem.Name = "gestorToolStripMenuItem";
            this.gestorToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.gestorToolStripMenuItem.Size = new System.Drawing.Size(83, 93);
            this.gestorToolStripMenuItem.Text = "Gestor";
            this.gestorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ensaiosProvisãoToolStripMenuItem
            // 
            this.ensaiosProvisãoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.ensaiosProvisãoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ensaiosProvisãoToolStripMenuItem.Name = "ensaiosProvisãoToolStripMenuItem";
            this.ensaiosProvisãoToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.ensaiosProvisãoToolStripMenuItem.Text = "Ensaios/Provisão";
            // 
            // finançasToolStripMenuItem
            // 
            this.finançasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.finançasToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.finançasToolStripMenuItem.Name = "finançasToolStripMenuItem";
            this.finançasToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.finançasToolStripMenuItem.Text = "Finanças";
            // 
            // análiseDeDadosToolStripMenuItem
            // 
            this.análiseDeDadosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.análiseDeDadosToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.análiseDeDadosToolStripMenuItem.Name = "análiseDeDadosToolStripMenuItem";
            this.análiseDeDadosToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.análiseDeDadosToolStripMenuItem.Text = "Análise de dados";
            // 
            // painelDeControleToolStripMenuItem
            // 
            this.painelDeControleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.painelDeControleToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.painelDeControleToolStripMenuItem.Name = "painelDeControleToolStripMenuItem";
            this.painelDeControleToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.painelDeControleToolStripMenuItem.Text = "Painel de controle";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 600);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlHeaderJanela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeaderJanela.ResumeLayout(false);
            this.pnlHeaderJanela.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlHeaderJanela;
        private Button btnFecharJanela;
        private Button btnMinimizarJanela;
        private Button btnSair;
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
        private ToolStripMenuItem confecçãoToolStripMenuItem;
        private ToolStripMenuItem insumosToolStripMenuItem;
        private ToolStripMenuItem gruposToolStripMenuItem;
        private ToolStripMenuItem produtoFinalToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem revendaToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem gestorToolStripMenuItem;
        private ToolStripMenuItem ensaiosProvisãoToolStripMenuItem;
        private ToolStripMenuItem finançasToolStripMenuItem;
        private ToolStripMenuItem análiseDeDadosToolStripMenuItem;
        private ToolStripMenuItem painelDeControleToolStripMenuItem;
        private Panel pnlMain;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
    }
}