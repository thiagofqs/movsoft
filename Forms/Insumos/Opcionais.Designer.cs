namespace MovSoft.Forms.Grupo
{
    partial class Opcionais
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
            this.txtObg1Insumos = new System.Windows.Forms.Label();
            this.txtNomeOpcionais = new System.Windows.Forms.Label();
            this.inputNomeOpcionais = new System.Windows.Forms.TextBox();
            this.txtQuantidadeOpcionais = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObg2Insumos = new System.Windows.Forms.Label();
            this.toggleButtonAtivoOpcionais = new MovSoft.Controls.ToggleButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridViewOpcionais = new System.Windows.Forms.DataGridView();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.numericUpDownOpcionais = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpcionais)).BeginInit();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpcionais)).BeginInit();
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
            // txtObg1Insumos
            // 
            this.txtObg1Insumos.AutoSize = true;
            this.txtObg1Insumos.BackColor = System.Drawing.Color.Transparent;
            this.txtObg1Insumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg1Insumos.Location = new System.Drawing.Point(124, 23);
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
            this.txtNomeOpcionais.Location = new System.Drawing.Point(12, 21);
            this.txtNomeOpcionais.Name = "txtNomeOpcionais";
            this.txtNomeOpcionais.Size = new System.Drawing.Size(45, 17);
            this.txtNomeOpcionais.TabIndex = 21;
            this.txtNomeOpcionais.Text = "Nome";
            // 
            // inputNomeOpcionais
            // 
            this.inputNomeOpcionais.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNomeOpcionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeOpcionais.Location = new System.Drawing.Point(12, 41);
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
            this.txtQuantidadeOpcionais.Location = new System.Drawing.Point(12, 85);
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
            this.label4.Location = new System.Drawing.Point(146, 87);
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
            this.txtObg2Insumos.Location = new System.Drawing.Point(98, 85);
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
            this.toggleButtonAtivoOpcionais.Location = new System.Drawing.Point(146, 107);
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
            // dataGridViewOpcionais
            // 
            this.dataGridViewOpcionais.AllowUserToAddRows = false;
            this.dataGridViewOpcionais.AllowUserToDeleteRows = false;
            this.dataGridViewOpcionais.AllowUserToResizeColumns = false;
            this.dataGridViewOpcionais.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewOpcionais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOpcionais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOpcionais.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewOpcionais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOpcionais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOpcionais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewOpcionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOpcionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpcionais.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOpcionais.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOpcionais.EnableHeadersVisualStyles = false;
            this.dataGridViewOpcionais.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dataGridViewOpcionais.Location = new System.Drawing.Point(198, 272);
            this.dataGridViewOpcionais.Name = "dataGridViewOpcionais";
            this.dataGridViewOpcionais.ReadOnly = true;
            this.dataGridViewOpcionais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewOpcionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOpcionais.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewOpcionais.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOpcionais.RowTemplate.Height = 25;
            this.dataGridViewOpcionais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOpcionais.ShowCellErrors = false;
            this.dataGridViewOpcionais.ShowCellToolTips = false;
            this.dataGridViewOpcionais.ShowEditingIcon = false;
            this.dataGridViewOpcionais.ShowRowErrors = false;
            this.dataGridViewOpcionais.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewOpcionais.TabIndex = 22;
            this.dataGridViewOpcionais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOpcionais_CellDoubleClick);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadastro.Controls.Add(this.numericUpDownOpcionais);
            this.pnlCadastro.Controls.Add(this.inputNomeOpcionais);
            this.pnlCadastro.Controls.Add(this.txtObg1Insumos);
            this.pnlCadastro.Controls.Add(this.toggleButtonAtivoOpcionais);
            this.pnlCadastro.Controls.Add(this.txtNomeOpcionais);
            this.pnlCadastro.Controls.Add(this.txtObg2Insumos);
            this.pnlCadastro.Controls.Add(this.label4);
            this.pnlCadastro.Controls.Add(this.txtQuantidadeOpcionais);
            this.pnlCadastro.Enabled = false;
            this.pnlCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlCadastro.Location = new System.Drawing.Point(198, 36);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(561, 162);
            this.pnlCadastro.TabIndex = 23;
            // 
            // numericUpDownOpcionais
            // 
            this.numericUpDownOpcionais.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownOpcionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownOpcionais.Location = new System.Drawing.Point(12, 106);
            this.numericUpDownOpcionais.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownOpcionais.Name = "numericUpDownOpcionais";
            this.numericUpDownOpcionais.Size = new System.Drawing.Size(106, 23);
            this.numericUpDownOpcionais.TabIndex = 23;
            // 
            // Opcionais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.dataGridViewOpcionais);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.imgFiltro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.inputPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opcionais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Lista de Insumos";
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpcionais)).EndInit();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOpcionais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox inputPesquisar;
        private ComboBox comboBoxFiltro;
        private PictureBox imgFiltro;
        private Button btnPesquisar;
        private Button btnCadastrar;
        private Label txtObg1Insumos;
        private Label txtNomeOpcionais;
        private TextBox inputNomeOpcionais;
        private Label txtQuantidadeOpcionais;
        private Label label4;
        private Label txtObg2Insumos;
        private Controls.ToggleButton toggleButtonAtivoOpcionais;
        private Button btnEditar;
        private Button btnCancelar;
        private DataGridView dataGridViewOpcionais;
        private Panel pnlCadastro;
        private NumericUpDown numericUpDownOpcionais;
    }
}