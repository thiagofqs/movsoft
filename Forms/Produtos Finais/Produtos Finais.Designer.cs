﻿namespace MovSoft.Forms
{
    partial class Produtos_Finais
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
            this.tabControlGeral = new System.Windows.Forms.TabControl();
            this.Geral = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.toggleButton3 = new MovSoft.Controls.ToggleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeGeral = new System.Windows.Forms.Label();
            this.tabControlPreco = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNomeComponente = new System.Windows.Forms.TextBox();
            this.txtObg1 = new System.Windows.Forms.Label();
            this.txtNomeComponentes = new System.Windows.Forms.Label();
            this.dataGridViewProdutosFinais = new System.Windows.Forms.DataGridView();
            this.checkBoxControleEstoque = new System.Windows.Forms.CheckBox();
            this.numericUpDownComponentes = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.imgFiltro = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.inputPesquisar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControlGeral.SuspendLayout();
            this.Geral.SuspendLayout();
            this.tabControlPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosFinais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComponentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGeral
            // 
            this.tabControlGeral.Controls.Add(this.Geral);
            this.tabControlGeral.Controls.Add(this.tabControlPreco);
            this.tabControlGeral.Location = new System.Drawing.Point(198, 36);
            this.tabControlGeral.Name = "tabControlGeral";
            this.tabControlGeral.SelectedIndex = 0;
            this.tabControlGeral.Size = new System.Drawing.Size(561, 162);
            this.tabControlGeral.TabIndex = 0;
            // 
            // Geral
            // 
            this.Geral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.Geral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Geral.Controls.Add(this.button3);
            this.Geral.Controls.Add(this.button4);
            this.Geral.Controls.Add(this.checkBoxControleEstoque);
            this.Geral.Controls.Add(this.label5);
            this.Geral.Controls.Add(this.toggleButton3);
            this.Geral.Controls.Add(this.label7);
            this.Geral.Controls.Add(this.textBox3);
            this.Geral.Controls.Add(this.label8);
            this.Geral.Controls.Add(this.txtNomeGeral);
            this.Geral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Geral.Location = new System.Drawing.Point(4, 24);
            this.Geral.Name = "Geral";
            this.Geral.Padding = new System.Windows.Forms.Padding(3);
            this.Geral.Size = new System.Drawing.Size(553, 134);
            this.Geral.TabIndex = 0;
            this.Geral.Text = "Geral";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(167, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "*";
            // 
            // toggleButton3
            // 
            this.toggleButton3.AutoSize = true;
            this.toggleButton3.Checked = true;
            this.toggleButton3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton3.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toggleButton3.Location = new System.Drawing.Point(242, 33);
            this.toggleButton3.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton3.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButton3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton3.Size = new System.Drawing.Size(45, 22);
            this.toggleButton3.TabIndex = 26;
            this.toggleButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(242, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ativo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.label8.Location = new System.Drawing.Point(81, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "*";
            // 
            // txtNomeGeral
            // 
            this.txtNomeGeral.AutoSize = true;
            this.txtNomeGeral.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeGeral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeGeral.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeGeral.Location = new System.Drawing.Point(30, 11);
            this.txtNomeGeral.Name = "txtNomeGeral";
            this.txtNomeGeral.Size = new System.Drawing.Size(45, 17);
            this.txtNomeGeral.TabIndex = 23;
            this.txtNomeGeral.Text = "Nome";
            // 
            // tabControlPreco
            // 
            this.tabControlPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.tabControlPreco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabControlPreco.Controls.Add(this.numericUpDownComponentes);
            this.tabControlPreco.Controls.Add(this.label2);
            this.tabControlPreco.Controls.Add(this.label3);
            this.tabControlPreco.Controls.Add(this.inputNomeComponente);
            this.tabControlPreco.Controls.Add(this.txtObg1);
            this.tabControlPreco.Controls.Add(this.txtNomeComponentes);
            this.tabControlPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tabControlPreco.Location = new System.Drawing.Point(4, 24);
            this.tabControlPreco.Name = "tabControlPreco";
            this.tabControlPreco.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlPreco.Size = new System.Drawing.Size(553, 134);
            this.tabControlPreco.TabIndex = 1;
            this.tabControlPreco.Text = "Preço";
            this.tabControlPreco.Click += new System.EventHandler(this.tabControlPreco_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(80, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Preço";
            // 
            // inputNomeComponente
            // 
            this.inputNomeComponente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNomeComponente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeComponente.Location = new System.Drawing.Point(28, 33);
            this.inputNomeComponente.Name = "inputNomeComponente";
            this.inputNomeComponente.Size = new System.Drawing.Size(179, 23);
            this.inputNomeComponente.TabIndex = 12;
            // 
            // txtObg1
            // 
            this.txtObg1.AutoSize = true;
            this.txtObg1.BackColor = System.Drawing.Color.Transparent;
            this.txtObg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg1.Location = new System.Drawing.Point(95, 15);
            this.txtObg1.Name = "txtObg1";
            this.txtObg1.Size = new System.Drawing.Size(12, 15);
            this.txtObg1.TabIndex = 14;
            this.txtObg1.Text = "*";
            this.txtObg1.Click += new System.EventHandler(this.txtObg1_Click);
            // 
            // txtNomeComponentes
            // 
            this.txtNomeComponentes.AutoSize = true;
            this.txtNomeComponentes.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeComponentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeComponentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeComponentes.Location = new System.Drawing.Point(28, 13);
            this.txtNomeComponentes.Name = "txtNomeComponentes";
            this.txtNomeComponentes.Size = new System.Drawing.Size(67, 17);
            this.txtNomeComponentes.TabIndex = 13;
            this.txtNomeComponentes.Text = "Descrição";
            this.txtNomeComponentes.Click += new System.EventHandler(this.txtNomeComponentes_Click);
            // 
            // dataGridViewProdutosFinais
            // 
            this.dataGridViewProdutosFinais.AllowUserToAddRows = false;
            this.dataGridViewProdutosFinais.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosFinais.AllowUserToResizeColumns = false;
            this.dataGridViewProdutosFinais.AllowUserToResizeRows = false;
            this.dataGridViewProdutosFinais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutosFinais.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProdutosFinais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProdutosFinais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProdutosFinais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProdutosFinais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosFinais.EnableHeadersVisualStyles = false;
            this.dataGridViewProdutosFinais.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dataGridViewProdutosFinais.Location = new System.Drawing.Point(198, 272);
            this.dataGridViewProdutosFinais.Name = "dataGridViewProdutosFinais";
            this.dataGridViewProdutosFinais.ReadOnly = true;
            this.dataGridViewProdutosFinais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProdutosFinais.RowHeadersVisible = false;
            this.dataGridViewProdutosFinais.RowTemplate.Height = 25;
            this.dataGridViewProdutosFinais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutosFinais.ShowCellErrors = false;
            this.dataGridViewProdutosFinais.ShowCellToolTips = false;
            this.dataGridViewProdutosFinais.ShowEditingIcon = false;
            this.dataGridViewProdutosFinais.ShowRowErrors = false;
            this.dataGridViewProdutosFinais.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewProdutosFinais.TabIndex = 1;
            // 
            // checkBoxControleEstoque
            // 
            this.checkBoxControleEstoque.AutoSize = true;
            this.checkBoxControleEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxControleEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxControleEstoque.Location = new System.Drawing.Point(31, 84);
            this.checkBoxControleEstoque.Name = "checkBoxControleEstoque";
            this.checkBoxControleEstoque.Size = new System.Drawing.Size(138, 21);
            this.checkBoxControleEstoque.TabIndex = 32;
            this.checkBoxControleEstoque.Text = "Controlar estoque";
            this.checkBoxControleEstoque.UseVisualStyleBackColor = true;
            // 
            // numericUpDownComponentes
            // 
            this.numericUpDownComponentes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownComponentes.DecimalPlaces = 2;
            this.numericUpDownComponentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownComponentes.Location = new System.Drawing.Point(29, 88);
            this.numericUpDownComponentes.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownComponentes.Name = "numericUpDownComponentes";
            this.numericUpDownComponentes.Size = new System.Drawing.Size(106, 23);
            this.numericUpDownComponentes.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox3.Location = new System.Drawing.Point(30, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 23);
            this.textBox3.TabIndex = 22;
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
            this.btnEditar.Location = new System.Drawing.Point(634, 312);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 34);
            this.btnEditar.TabIndex = 7;
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
            this.btnCancelar.Location = new System.Drawing.Point(634, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnCadastrar.Location = new System.Drawing.Point(634, 272);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 34);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // imgFiltro
            // 
            this.imgFiltro.BackColor = System.Drawing.Color.Transparent;
            this.imgFiltro.BackgroundImage = global::MovSoft.Properties.Resources.icon_filter;
            this.imgFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFiltro.Location = new System.Drawing.Point(501, 243);
            this.imgFiltro.Name = "imgFiltro";
            this.imgFiltro.Size = new System.Drawing.Size(23, 23);
            this.imgFiltro.TabIndex = 25;
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
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.UseVisualStyleBackColor = false;
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
            this.comboBoxFiltro.TabIndex = 24;
            // 
            // inputPesquisar
            // 
            this.inputPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputPesquisar.Location = new System.Drawing.Point(198, 243);
            this.inputPesquisar.Name = "inputPesquisar";
            this.inputPesquisar.PlaceholderText = "Pesquisar";
            this.inputPesquisar.Size = new System.Drawing.Size(240, 23);
            this.inputPesquisar.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(434, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 48);
            this.button3.TabIndex = 34;
            this.button3.Text = "Vincular Opcionais";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(434, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 48);
            this.button4.TabIndex = 33;
            this.button4.Text = "Vincular Componentes";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Produtos_Finais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.imgFiltro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.inputPesquisar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGridViewProdutosFinais);
            this.Controls.Add(this.tabControlGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos_Finais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos Finais";
            this.tabControlGeral.ResumeLayout(false);
            this.Geral.ResumeLayout(false);
            this.Geral.PerformLayout();
            this.tabControlPreco.ResumeLayout(false);
            this.tabControlPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosFinais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComponentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControlGeral;
        private TabPage Geral;
        private TabPage tabControlPreco;
        private DataGridView dataGridViewProdutosFinais;
        private TextBox inputNomeComponente;
        private Label txtObg1;
        private Label txtNomeComponentes;
        private Label label5;
        private Controls.ToggleButton toggleButton3;
        private Label label7;
        private Label label8;
        private Label txtNomeGeral;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxControleEstoque;
        private NumericUpDown numericUpDownComponentes;
        private TextBox textBox3;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnCadastrar;
        private PictureBox imgFiltro;
        private Button btnPesquisar;
        private ComboBox comboBoxFiltro;
        private TextBox inputPesquisar;
        private Button button3;
        private Button button4;
    }
}