namespace MovSoft.Forms.Grupo
{
    partial class Insumos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputPesquisar = new System.Windows.Forms.TextBox();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.imgFiltro = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtUnidadeDeMedida = new System.Windows.Forms.Label();
            this.txtObg3 = new System.Windows.Forms.Label();
            this.comboBoxUnidadeDeMedida = new System.Windows.Forms.ComboBox();
            this.toggleButtonAtivoComponentes = new MovSoft.Controls.ToggleButton();
            this.inputNomeComponente = new System.Windows.Forms.TextBox();
            this.txtAtivo = new System.Windows.Forms.Label();
            this.tabPageCadastroInsumos = new System.Windows.Forms.TabControl();
            this.tabPageComponentes = new System.Windows.Forms.TabPage();
            this.txtObg1 = new System.Windows.Forms.Label();
            this.txtNomeComponentes = new System.Windows.Forms.Label();
            this.txtObg2 = new System.Windows.Forms.Label();
            this.inputQuantidadeComponentes = new System.Windows.Forms.TextBox();
            this.txtQuanidadeComponentes = new System.Windows.Forms.Label();
            this.tabPageOpcionais = new System.Windows.Forms.TabPage();
            this.txtObg1Insumos = new System.Windows.Forms.Label();
            this.txtNomeOpcionais = new System.Windows.Forms.Label();
            this.inputNomeOpcionais = new System.Windows.Forms.TextBox();
            this.txtQuantidadeOpcionais = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObg2Insumos = new System.Windows.Forms.Label();
            this.toggleButtonAtivoOpcionais = new MovSoft.Controls.ToggleButton();
            this.comboBoxQuantidadeOpcionais = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridViewInsumos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            this.tabPageCadastroInsumos.SuspendLayout();
            this.tabPageComponentes.SuspendLayout();
            this.tabPageOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPesquisar
            // 
            this.inputPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputPesquisar.Location = new System.Drawing.Point(198, 243);
            this.inputPesquisar.Name = "inputPesquisar";
            this.inputPesquisar.PlaceholderText = "Pesquisar";
            this.inputPesquisar.Size = new System.Drawing.Size(240, 23);
            this.inputPesquisar.TabIndex = 0;
            this.inputPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPesquisar_KeyPress);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Habilitado",
            "Desabilitado"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(530, 243);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(98, 23);
            this.comboBoxFiltro.TabIndex = 2;
            // 
            // imgFiltro
            // 
            this.imgFiltro.BackColor = System.Drawing.Color.Transparent;
            this.imgFiltro.BackgroundImage = global::MovSoft.Properties.Resources.icon_filter;
            this.imgFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFiltro.Location = new System.Drawing.Point(501, 243);
            this.imgFiltro.Name = "imgFiltro";
            this.imgFiltro.Size = new System.Drawing.Size(23, 23);
            this.imgFiltro.TabIndex = 21;
            this.imgFiltro.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::MovSoft.Properties.Resources.icon_search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnPesquisar.Location = new System.Drawing.Point(444, 243);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(23, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtUnidadeDeMedida
            // 
            this.txtUnidadeDeMedida.AutoSize = true;
            this.txtUnidadeDeMedida.BackColor = System.Drawing.Color.Transparent;
            this.txtUnidadeDeMedida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUnidadeDeMedida.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUnidadeDeMedida.Location = new System.Drawing.Point(223, 74);
            this.txtUnidadeDeMedida.Name = "txtUnidadeDeMedida";
            this.txtUnidadeDeMedida.Size = new System.Drawing.Size(128, 17);
            this.txtUnidadeDeMedida.TabIndex = 8;
            this.txtUnidadeDeMedida.Text = "Unidade de medida";
            // 
            // txtObg3
            // 
            this.txtObg3.AutoSize = true;
            this.txtObg3.BackColor = System.Drawing.Color.Transparent;
            this.txtObg3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg3.Location = new System.Drawing.Point(357, 76);
            this.txtObg3.Name = "txtObg3";
            this.txtObg3.Size = new System.Drawing.Size(12, 15);
            this.txtObg3.TabIndex = 9;
            this.txtObg3.Text = "*";
            // 
            // comboBoxUnidadeDeMedida
            // 
            this.comboBoxUnidadeDeMedida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxUnidadeDeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidadeDeMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxUnidadeDeMedida.FormattingEnabled = true;
            this.comboBoxUnidadeDeMedida.Location = new System.Drawing.Point(224, 94);
            this.comboBoxUnidadeDeMedida.Name = "comboBoxUnidadeDeMedida";
            this.comboBoxUnidadeDeMedida.Size = new System.Drawing.Size(127, 23);
            this.comboBoxUnidadeDeMedida.TabIndex = 10;
            // 
            // toggleButtonAtivoComponentes
            // 
            this.toggleButtonAtivoComponentes.AutoSize = true;
            this.toggleButtonAtivoComponentes.Checked = true;
            this.toggleButtonAtivoComponentes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonAtivoComponentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonAtivoComponentes.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButtonAtivoComponentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toggleButtonAtivoComponentes.Location = new System.Drawing.Point(379, 95);
            this.toggleButtonAtivoComponentes.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonAtivoComponentes.Name = "toggleButtonAtivoComponentes";
            this.toggleButtonAtivoComponentes.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonAtivoComponentes.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonAtivoComponentes.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButtonAtivoComponentes.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonAtivoComponentes.Size = new System.Drawing.Size(45, 22);
            this.toggleButtonAtivoComponentes.TabIndex = 11;
            this.toggleButtonAtivoComponentes.UseVisualStyleBackColor = true;
            // 
            // inputNomeComponente
            // 
            this.inputNomeComponente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNomeComponente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeComponente.Location = new System.Drawing.Point(45, 38);
            this.inputNomeComponente.Name = "inputNomeComponente";
            this.inputNomeComponente.Size = new System.Drawing.Size(179, 23);
            this.inputNomeComponente.TabIndex = 8;
            // 
            // txtAtivo
            // 
            this.txtAtivo.AutoSize = true;
            this.txtAtivo.BackColor = System.Drawing.Color.Transparent;
            this.txtAtivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAtivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAtivo.Location = new System.Drawing.Point(379, 75);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.Size = new System.Drawing.Size(41, 17);
            this.txtAtivo.TabIndex = 1;
            this.txtAtivo.Text = "Ativo";
            this.txtAtivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabPageCadastroInsumos
            // 
            this.tabPageCadastroInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPageCadastroInsumos.Controls.Add(this.tabPageComponentes);
            this.tabPageCadastroInsumos.Controls.Add(this.tabPageOpcionais);
            this.tabPageCadastroInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPageCadastroInsumos.Enabled = false;
            this.tabPageCadastroInsumos.Location = new System.Drawing.Point(198, 36);
            this.tabPageCadastroInsumos.Name = "tabPageCadastroInsumos";
            this.tabPageCadastroInsumos.SelectedIndex = 0;
            this.tabPageCadastroInsumos.Size = new System.Drawing.Size(561, 194);
            this.tabPageCadastroInsumos.TabIndex = 7;
            this.tabPageCadastroInsumos.TabStop = false;
            // 
            // tabPageComponentes
            // 
            this.tabPageComponentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.tabPageComponentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageComponentes.Controls.Add(this.txtObg1);
            this.tabPageComponentes.Controls.Add(this.txtNomeComponentes);
            this.tabPageComponentes.Controls.Add(this.inputNomeComponente);
            this.tabPageComponentes.Controls.Add(this.txtUnidadeDeMedida);
            this.tabPageComponentes.Controls.Add(this.txtAtivo);
            this.tabPageComponentes.Controls.Add(this.txtObg3);
            this.tabPageComponentes.Controls.Add(this.toggleButtonAtivoComponentes);
            this.tabPageComponentes.Controls.Add(this.comboBoxUnidadeDeMedida);
            this.tabPageComponentes.Controls.Add(this.txtObg2);
            this.tabPageComponentes.Controls.Add(this.inputQuantidadeComponentes);
            this.tabPageComponentes.Controls.Add(this.txtQuanidadeComponentes);
            this.tabPageComponentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tabPageComponentes.Location = new System.Drawing.Point(4, 24);
            this.tabPageComponentes.Name = "tabPageComponentes";
            this.tabPageComponentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComponentes.Size = new System.Drawing.Size(553, 166);
            this.tabPageComponentes.TabIndex = 0;
            this.tabPageComponentes.Text = "Componentes";
            // 
            // txtObg1
            // 
            this.txtObg1.AutoSize = true;
            this.txtObg1.BackColor = System.Drawing.Color.Transparent;
            this.txtObg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg1.Location = new System.Drawing.Point(157, 20);
            this.txtObg1.Name = "txtObg1";
            this.txtObg1.Size = new System.Drawing.Size(12, 15);
            this.txtObg1.TabIndex = 11;
            this.txtObg1.Text = "*";
            // 
            // txtNomeComponentes
            // 
            this.txtNomeComponentes.AutoSize = true;
            this.txtNomeComponentes.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeComponentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeComponentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeComponentes.Location = new System.Drawing.Point(45, 18);
            this.txtNomeComponentes.Name = "txtNomeComponentes";
            this.txtNomeComponentes.Size = new System.Drawing.Size(45, 17);
            this.txtNomeComponentes.TabIndex = 10;
            this.txtNomeComponentes.Text = "Nome";
            // 
            // txtObg2
            // 
            this.txtObg2.AutoSize = true;
            this.txtObg2.BackColor = System.Drawing.Color.Transparent;
            this.txtObg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg2.Location = new System.Drawing.Point(181, 77);
            this.txtObg2.Name = "txtObg2";
            this.txtObg2.Size = new System.Drawing.Size(12, 15);
            this.txtObg2.TabIndex = 5;
            this.txtObg2.Text = "*";
            // 
            // inputQuantidadeComponentes
            // 
            this.inputQuantidadeComponentes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputQuantidadeComponentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputQuantidadeComponentes.Location = new System.Drawing.Point(45, 94);
            this.inputQuantidadeComponentes.Name = "inputQuantidadeComponentes";
            this.inputQuantidadeComponentes.Size = new System.Drawing.Size(148, 23);
            this.inputQuantidadeComponentes.TabIndex = 9;
            // 
            // txtQuanidadeComponentes
            // 
            this.txtQuanidadeComponentes.AutoSize = true;
            this.txtQuanidadeComponentes.BackColor = System.Drawing.Color.Transparent;
            this.txtQuanidadeComponentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuanidadeComponentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuanidadeComponentes.Location = new System.Drawing.Point(45, 74);
            this.txtQuanidadeComponentes.Name = "txtQuanidadeComponentes";
            this.txtQuanidadeComponentes.Size = new System.Drawing.Size(80, 17);
            this.txtQuanidadeComponentes.TabIndex = 4;
            this.txtQuanidadeComponentes.Text = "Quantidade";
            // 
            // tabPageOpcionais
            // 
            this.tabPageOpcionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.tabPageOpcionais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageOpcionais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageOpcionais.Controls.Add(this.txtObg1Insumos);
            this.tabPageOpcionais.Controls.Add(this.txtNomeOpcionais);
            this.tabPageOpcionais.Controls.Add(this.inputNomeOpcionais);
            this.tabPageOpcionais.Controls.Add(this.txtQuantidadeOpcionais);
            this.tabPageOpcionais.Controls.Add(this.label4);
            this.tabPageOpcionais.Controls.Add(this.txtObg2Insumos);
            this.tabPageOpcionais.Controls.Add(this.toggleButtonAtivoOpcionais);
            this.tabPageOpcionais.Controls.Add(this.comboBoxQuantidadeOpcionais);
            this.tabPageOpcionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tabPageOpcionais.Location = new System.Drawing.Point(4, 24);
            this.tabPageOpcionais.Name = "tabPageOpcionais";
            this.tabPageOpcionais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOpcionais.Size = new System.Drawing.Size(553, 166);
            this.tabPageOpcionais.TabIndex = 1;
            this.tabPageOpcionais.Text = "Opcionais";
            // 
            // txtObg1Insumos
            // 
            this.txtObg1Insumos.AutoSize = true;
            this.txtObg1Insumos.BackColor = System.Drawing.Color.Transparent;
            this.txtObg1Insumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg1Insumos.Location = new System.Drawing.Point(157, 20);
            this.txtObg1Insumos.Name = "txtObg1Insumos";
            this.txtObg1Insumos.Size = new System.Drawing.Size(12, 15);
            this.txtObg1Insumos.TabIndex = 22;
            this.txtObg1Insumos.Text = "*";
            // 
            // txtNomeOpcionais
            // 
            this.txtNomeOpcionais.AutoSize = true;
            this.txtNomeOpcionais.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeOpcionais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeOpcionais.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeOpcionais.Location = new System.Drawing.Point(45, 18);
            this.txtNomeOpcionais.Name = "txtNomeOpcionais";
            this.txtNomeOpcionais.Size = new System.Drawing.Size(45, 17);
            this.txtNomeOpcionais.TabIndex = 21;
            this.txtNomeOpcionais.Text = "Nome";
            // 
            // inputNomeOpcionais
            // 
            this.inputNomeOpcionais.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNomeOpcionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeOpcionais.Location = new System.Drawing.Point(45, 38);
            this.inputNomeOpcionais.Name = "inputNomeOpcionais";
            this.inputNomeOpcionais.Size = new System.Drawing.Size(179, 23);
            this.inputNomeOpcionais.TabIndex = 8;
            // 
            // txtQuantidadeOpcionais
            // 
            this.txtQuantidadeOpcionais.AutoSize = true;
            this.txtQuantidadeOpcionais.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidadeOpcionais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidadeOpcionais.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantidadeOpcionais.Location = new System.Drawing.Point(45, 74);
            this.txtQuantidadeOpcionais.Name = "txtQuantidadeOpcionais";
            this.txtQuantidadeOpcionais.Size = new System.Drawing.Size(80, 17);
            this.txtQuantidadeOpcionais.TabIndex = 19;
            this.txtQuantidadeOpcionais.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(203, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ativo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtObg2Insumos
            // 
            this.txtObg2Insumos.AutoSize = true;
            this.txtObg2Insumos.BackColor = System.Drawing.Color.Transparent;
            this.txtObg2Insumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg2Insumos.Location = new System.Drawing.Point(160, 74);
            this.txtObg2Insumos.Name = "txtObg2Insumos";
            this.txtObg2Insumos.Size = new System.Drawing.Size(12, 15);
            this.txtObg2Insumos.TabIndex = 20;
            this.txtObg2Insumos.Text = "*";
            // 
            // toggleButtonAtivoOpcionais
            // 
            this.toggleButtonAtivoOpcionais.AutoSize = true;
            this.toggleButtonAtivoOpcionais.Checked = true;
            this.toggleButtonAtivoOpcionais.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonAtivoOpcionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonAtivoOpcionais.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButtonAtivoOpcionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toggleButtonAtivoOpcionais.Location = new System.Drawing.Point(203, 94);
            this.toggleButtonAtivoOpcionais.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonAtivoOpcionais.Name = "toggleButtonAtivoOpcionais";
            this.toggleButtonAtivoOpcionais.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonAtivoOpcionais.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonAtivoOpcionais.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButtonAtivoOpcionais.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonAtivoOpcionais.Size = new System.Drawing.Size(45, 22);
            this.toggleButtonAtivoOpcionais.TabIndex = 10;
            this.toggleButtonAtivoOpcionais.UseVisualStyleBackColor = true;
            // 
            // comboBoxQuantidadeOpcionais
            // 
            this.comboBoxQuantidadeOpcionais.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxQuantidadeOpcionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuantidadeOpcionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxQuantidadeOpcionais.FormattingEnabled = true;
            this.comboBoxQuantidadeOpcionais.Location = new System.Drawing.Point(45, 94);
            this.comboBoxQuantidadeOpcionais.Name = "comboBoxQuantidadeOpcionais";
            this.comboBoxQuantidadeOpcionais.Size = new System.Drawing.Size(127, 23);
            this.comboBoxQuantidadeOpcionais.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(634, 274);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 34);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.Location = new System.Drawing.Point(634, 314);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 34);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(634, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridViewInsumos
            // 
            this.dataGridViewInsumos.AllowUserToAddRows = false;
            this.dataGridViewInsumos.AllowUserToDeleteRows = false;
            this.dataGridViewInsumos.AllowUserToResizeColumns = false;
            this.dataGridViewInsumos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewInsumos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInsumos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewInsumos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInsumos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewInsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewInsumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInsumos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInsumos.EnableHeadersVisualStyles = false;
            this.dataGridViewInsumos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dataGridViewInsumos.Location = new System.Drawing.Point(198, 272);
            this.dataGridViewInsumos.Name = "dataGridViewInsumos";
            this.dataGridViewInsumos.ReadOnly = true;
            this.dataGridViewInsumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewInsumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewInsumos.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewInsumos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewInsumos.RowTemplate.Height = 25;
            this.dataGridViewInsumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInsumos.ShowCellErrors = false;
            this.dataGridViewInsumos.ShowCellToolTips = false;
            this.dataGridViewInsumos.ShowEditingIcon = false;
            this.dataGridViewInsumos.ShowRowErrors = false;
            this.dataGridViewInsumos.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewInsumos.TabIndex = 22;
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.dataGridViewInsumos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tabPageCadastroInsumos);
            this.Controls.Add(this.imgFiltro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.inputPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Lista de Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            this.tabPageCadastroInsumos.ResumeLayout(false);
            this.tabPageComponentes.ResumeLayout(false);
            this.tabPageComponentes.PerformLayout();
            this.tabPageOpcionais.ResumeLayout(false);
            this.tabPageOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsumos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox inputPesquisar;
        private ComboBox comboBoxFiltro;
        private PictureBox imgFiltro;
        private Button btnPesquisar;
        private TextBox inputNomeComponente;
        private Label txtAtivo;
        private Controls.ToggleButton toggleButtonAtivoComponentes;
        private Label txtUnidadeDeMedida;
        private Label txtObg3;
        private ComboBox comboBoxUnidadeDeMedida;
        private TabControl tabPageCadastroInsumos;
        private TabPage tabPageComponentes;
        private TabPage tabPageOpcionais;
        private Label txtObg1;
        private Label txtNomeComponentes;
        private Button btnCadastrar;
        private Label txtObg1Insumos;
        private Label txtNomeOpcionais;
        private TextBox inputNomeOpcionais;
        private Label txtQuantidadeOpcionais;
        private Label label4;
        private Label txtObg2Insumos;
        private Controls.ToggleButton toggleButtonAtivoOpcionais;
        private ComboBox comboBoxQuantidadeOpcionais;
        private Label txtObg2;
        private TextBox inputQuantidadeComponentes;
        private Label txtQuanidadeComponentes;
        private Button btnEditar;
        private Button btnCancelar;
        private DataGridView dataGridViewInsumos;
    }
}