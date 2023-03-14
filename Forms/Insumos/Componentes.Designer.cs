namespace MovSoft.Forms.Grupo
{
    partial class Componentes
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
            this.comboBoxUnidadeDeMedida = new System.Windows.Forms.ComboBox();
            this.toggleButtonAtivoComponentes = new MovSoft.Controls.ToggleButton();
            this.inputNomeComponente = new System.Windows.Forms.TextBox();
            this.txtAtivo = new System.Windows.Forms.Label();
            this.txtObg1 = new System.Windows.Forms.Label();
            this.txtNomeComponentes = new System.Windows.Forms.Label();
            this.txtObg2 = new System.Windows.Forms.Label();
            this.txtQuanidadeComponentes = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridViewComponentes = new System.Windows.Forms.DataGridView();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.txtUnidadeDeMedida = new System.Windows.Forms.Label();
            this.txtObg3 = new System.Windows.Forms.Label();
            this.numericUpDownComponentes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponentes)).BeginInit();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComponentes)).BeginInit();
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
            // comboBoxUnidadeDeMedida
            // 
            this.comboBoxUnidadeDeMedida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxUnidadeDeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnidadeDeMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxUnidadeDeMedida.FormattingEnabled = true;
            this.comboBoxUnidadeDeMedida.Items.AddRange(new object[] {
            "Unidade (un)",
            "Metro (m)",
            "Milímetro (mm)",
            "Litro (L)",
            "Mililitro (mL)",
            "Quilograma (kg)",
            "Grama (g)",
            "Miligrama (mg)"});
            this.comboBoxUnidadeDeMedida.Location = new System.Drawing.Point(155, 102);
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
            this.toggleButtonAtivoComponentes.Location = new System.Drawing.Point(319, 102);
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
            this.inputNomeComponente.Location = new System.Drawing.Point(12, 41);
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
            this.txtAtivo.Location = new System.Drawing.Point(319, 82);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.Size = new System.Drawing.Size(41, 17);
            this.txtAtivo.TabIndex = 1;
            this.txtAtivo.Text = "Ativo";
            this.txtAtivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtObg1
            // 
            this.txtObg1.AutoSize = true;
            this.txtObg1.BackColor = System.Drawing.Color.Transparent;
            this.txtObg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg1.Location = new System.Drawing.Point(63, 23);
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
            this.txtNomeComponentes.Location = new System.Drawing.Point(12, 21);
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
            this.txtObg2.Location = new System.Drawing.Point(98, 84);
            this.txtObg2.Name = "txtObg2";
            this.txtObg2.Size = new System.Drawing.Size(12, 15);
            this.txtObg2.TabIndex = 5;
            this.txtObg2.Text = "*";
            // 
            // txtQuanidadeComponentes
            // 
            this.txtQuanidadeComponentes.AutoSize = true;
            this.txtQuanidadeComponentes.BackColor = System.Drawing.Color.Transparent;
            this.txtQuanidadeComponentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuanidadeComponentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuanidadeComponentes.Location = new System.Drawing.Point(12, 82);
            this.txtQuanidadeComponentes.Name = "txtQuanidadeComponentes";
            this.txtQuanidadeComponentes.Size = new System.Drawing.Size(80, 17);
            this.txtQuanidadeComponentes.TabIndex = 4;
            this.txtQuanidadeComponentes.Text = "Quantidade";
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // dataGridViewComponentes
            // 
            this.dataGridViewComponentes.AllowUserToAddRows = false;
            this.dataGridViewComponentes.AllowUserToDeleteRows = false;
            this.dataGridViewComponentes.AllowUserToResizeColumns = false;
            this.dataGridViewComponentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewComponentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComponentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComponentes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewComponentes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewComponentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewComponentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewComponentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewComponentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComponentes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewComponentes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewComponentes.EnableHeadersVisualStyles = false;
            this.dataGridViewComponentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dataGridViewComponentes.Location = new System.Drawing.Point(198, 272);
            this.dataGridViewComponentes.Name = "dataGridViewComponentes";
            this.dataGridViewComponentes.ReadOnly = true;
            this.dataGridViewComponentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewComponentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewComponentes.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewComponentes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewComponentes.RowTemplate.Height = 25;
            this.dataGridViewComponentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComponentes.ShowCellErrors = false;
            this.dataGridViewComponentes.ShowCellToolTips = false;
            this.dataGridViewComponentes.ShowEditingIcon = false;
            this.dataGridViewComponentes.ShowRowErrors = false;
            this.dataGridViewComponentes.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewComponentes.TabIndex = 22;
            this.dataGridViewComponentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComponentes_CellDoubleClick);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadastro.Controls.Add(this.numericUpDownComponentes);
            this.pnlCadastro.Controls.Add(this.inputNomeComponente);
            this.pnlCadastro.Controls.Add(this.txtObg1);
            this.pnlCadastro.Controls.Add(this.txtQuanidadeComponentes);
            this.pnlCadastro.Controls.Add(this.txtNomeComponentes);
            this.pnlCadastro.Controls.Add(this.txtObg2);
            this.pnlCadastro.Controls.Add(this.comboBoxUnidadeDeMedida);
            this.pnlCadastro.Controls.Add(this.toggleButtonAtivoComponentes);
            this.pnlCadastro.Controls.Add(this.txtObg3);
            this.pnlCadastro.Controls.Add(this.txtUnidadeDeMedida);
            this.pnlCadastro.Controls.Add(this.txtAtivo);
            this.pnlCadastro.Enabled = false;
            this.pnlCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlCadastro.Location = new System.Drawing.Point(198, 36);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(561, 162);
            this.pnlCadastro.TabIndex = 24;
            // 
            // txtUnidadeDeMedida
            // 
            this.txtUnidadeDeMedida.AutoSize = true;
            this.txtUnidadeDeMedida.BackColor = System.Drawing.Color.Transparent;
            this.txtUnidadeDeMedida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUnidadeDeMedida.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUnidadeDeMedida.Location = new System.Drawing.Point(154, 82);
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
            this.txtObg3.Location = new System.Drawing.Point(288, 84);
            this.txtObg3.Name = "txtObg3";
            this.txtObg3.Size = new System.Drawing.Size(12, 15);
            this.txtObg3.TabIndex = 9;
            this.txtObg3.Text = "*";
            // 
            // numericUpDownComponentes
            // 
            this.numericUpDownComponentes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownComponentes.DecimalPlaces = 2;
            this.numericUpDownComponentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownComponentes.Location = new System.Drawing.Point(12, 102);
            this.numericUpDownComponentes.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownComponentes.Name = "numericUpDownComponentes";
            this.numericUpDownComponentes.Size = new System.Drawing.Size(106, 23);
            this.numericUpDownComponentes.TabIndex = 24;
            // 
            // Componentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.dataGridViewComponentes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.imgFiltro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.inputPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Componentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Lista de Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComponentes)).EndInit();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComponentes)).EndInit();
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
        private ComboBox comboBoxUnidadeDeMedida;
        private Label txtObg1;
        private Label txtNomeComponentes;
        private Button btnCadastrar;
        private Label txtObg2;
        private Label txtQuanidadeComponentes;
        private Button btnEditar;
        private Button btnCancelar;
        private DataGridView dataGridViewComponentes;
        private Panel pnlCadastro;
        private NumericUpDown numericUpDownComponentes;
        private Label txtObg3;
        private Label txtUnidadeDeMedida;
    }
}