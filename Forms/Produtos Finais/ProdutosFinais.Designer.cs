namespace MovSoft.Forms
{
    partial class ProdutosFinais
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
            this.tabControlProdutos = new System.Windows.Forms.TabControl();
            this.Geral = new System.Windows.Forms.TabPage();
            this.kryptonCheckBoxControlarEstoque = new Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            this.toggleButtonAtivo = new MovSoft.Controls.ToggleButton();
            this.kryptonLabelNomeProduto = new Krypton.Toolkit.KryptonLabel();
            this.btnVincularOpcionais = new System.Windows.Forms.Button();
            this.btnVincularComponentes = new System.Windows.Forms.Button();
            this.inputNomeProduto = new System.Windows.Forms.TextBox();
            this.Preco = new System.Windows.Forms.TabPage();
            this.comboBoxUnidadeDeMedida = new System.Windows.Forms.ComboBox();
            this.kryptonLabelPreco = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelDescricao = new Krypton.Toolkit.KryptonLabel();
            this.numericUpDownPreco = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewProdutosFinais = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.imgFiltro = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.inputPesquisar = new System.Windows.Forms.TextBox();
            this.tabControlProdutos.SuspendLayout();
            this.Geral.SuspendLayout();
            this.Preco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosFinais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProdutos
            // 
            this.tabControlProdutos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControlProdutos.Controls.Add(this.Geral);
            this.tabControlProdutos.Controls.Add(this.Preco);
            this.tabControlProdutos.Enabled = false;
            this.tabControlProdutos.Location = new System.Drawing.Point(198, 36);
            this.tabControlProdutos.Name = "tabControlProdutos";
            this.tabControlProdutos.SelectedIndex = 0;
            this.tabControlProdutos.Size = new System.Drawing.Size(561, 162);
            this.tabControlProdutos.TabIndex = 0;
            // 
            // Geral
            // 
            this.Geral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.Geral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Geral.Controls.Add(this.kryptonCheckBoxControlarEstoque);
            this.Geral.Controls.Add(this.kryptonLabelAtivo);
            this.Geral.Controls.Add(this.toggleButtonAtivo);
            this.Geral.Controls.Add(this.kryptonLabelNomeProduto);
            this.Geral.Controls.Add(this.btnVincularOpcionais);
            this.Geral.Controls.Add(this.btnVincularComponentes);
            this.Geral.Controls.Add(this.inputNomeProduto);
            this.Geral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Geral.Location = new System.Drawing.Point(4, 24);
            this.Geral.Name = "Geral";
            this.Geral.Padding = new System.Windows.Forms.Padding(3);
            this.Geral.Size = new System.Drawing.Size(553, 134);
            this.Geral.TabIndex = 0;
            this.Geral.Text = "Geral";
            // 
            // kryptonCheckBoxControlarEstoque
            // 
            this.kryptonCheckBoxControlarEstoque.Location = new System.Drawing.Point(12, 82);
            this.kryptonCheckBoxControlarEstoque.Name = "kryptonCheckBoxControlarEstoque";
            this.kryptonCheckBoxControlarEstoque.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonCheckBoxControlarEstoque.Size = new System.Drawing.Size(137, 23);
            this.kryptonCheckBoxControlarEstoque.StateDisabled.LongText.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonCheckBoxControlarEstoque.StateDisabled.ShortText.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonCheckBoxControlarEstoque.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonCheckBoxControlarEstoque.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonCheckBoxControlarEstoque.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonCheckBoxControlarEstoque.TabIndex = 10;
            this.kryptonCheckBoxControlarEstoque.Values.Text = "Controlar estoque";
            // 
            // kryptonLabelAtivo
            // 
            this.kryptonLabelAtivo.Location = new System.Drawing.Point(218, 9);
            this.kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            this.kryptonLabelAtivo.Size = new System.Drawing.Size(45, 21);
            this.kryptonLabelAtivo.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelAtivo.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.TabIndex = 9;
            this.kryptonLabelAtivo.Values.Text = "Ativo";
            // 
            // toggleButtonAtivo
            // 
            this.toggleButtonAtivo.AutoSize = true;
            this.toggleButtonAtivo.BackColor = System.Drawing.Color.Transparent;
            this.toggleButtonAtivo.Checked = true;
            this.toggleButtonAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonAtivo.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButtonAtivo.Location = new System.Drawing.Point(218, 36);
            this.toggleButtonAtivo.MinimumSize = new System.Drawing.Size(45, 23);
            this.toggleButtonAtivo.Name = "toggleButtonAtivo";
            this.toggleButtonAtivo.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonAtivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonAtivo.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButtonAtivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonAtivo.Size = new System.Drawing.Size(45, 23);
            this.toggleButtonAtivo.TabIndex = 9;
            this.toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelNomeProduto
            // 
            this.kryptonLabelNomeProduto.Location = new System.Drawing.Point(12, 9);
            this.kryptonLabelNomeProduto.Name = "kryptonLabelNomeProduto";
            this.kryptonLabelNomeProduto.Size = new System.Drawing.Size(137, 21);
            this.kryptonLabelNomeProduto.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelNomeProduto.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNomeProduto.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelNomeProduto.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNomeProduto.TabIndex = 8;
            this.kryptonLabelNomeProduto.Values.ExtraText = "*";
            this.kryptonLabelNomeProduto.Values.Text = "Nome do produto";
            // 
            // btnVincularOpcionais
            // 
            this.btnVincularOpcionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnVincularOpcionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVincularOpcionais.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnVincularOpcionais.FlatAppearance.BorderSize = 0;
            this.btnVincularOpcionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularOpcionais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVincularOpcionais.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVincularOpcionais.Location = new System.Drawing.Point(430, 67);
            this.btnVincularOpcionais.Name = "btnVincularOpcionais";
            this.btnVincularOpcionais.Size = new System.Drawing.Size(96, 48);
            this.btnVincularOpcionais.TabIndex = 12;
            this.btnVincularOpcionais.Text = "Vincular Opcionais";
            this.btnVincularOpcionais.UseVisualStyleBackColor = false;
            this.btnVincularOpcionais.Click += new System.EventHandler(this.btnVincularOpcionais_Click);
            // 
            // btnVincularComponentes
            // 
            this.btnVincularComponentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnVincularComponentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVincularComponentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnVincularComponentes.FlatAppearance.BorderSize = 0;
            this.btnVincularComponentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincularComponentes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVincularComponentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVincularComponentes.Location = new System.Drawing.Point(430, 9);
            this.btnVincularComponentes.Name = "btnVincularComponentes";
            this.btnVincularComponentes.Size = new System.Drawing.Size(96, 48);
            this.btnVincularComponentes.TabIndex = 11;
            this.btnVincularComponentes.Text = "Vincular Componentes";
            this.btnVincularComponentes.UseVisualStyleBackColor = false;
            this.btnVincularComponentes.Click += new System.EventHandler(this.btnVincularComponentes_Click);
            // 
            // inputNomeProduto
            // 
            this.inputNomeProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeProduto.Location = new System.Drawing.Point(12, 36);
            this.inputNomeProduto.Name = "inputNomeProduto";
            this.inputNomeProduto.Size = new System.Drawing.Size(179, 23);
            this.inputNomeProduto.TabIndex = 8;
            this.inputNomeProduto.Tag = "Nome do Produto";
            this.inputNomeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNomeProduto_KeyPress);
            // 
            // Preco
            // 
            this.Preco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.Preco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Preco.Controls.Add(this.comboBoxUnidadeDeMedida);
            this.Preco.Controls.Add(this.kryptonLabelPreco);
            this.Preco.Controls.Add(this.kryptonLabelDescricao);
            this.Preco.Controls.Add(this.numericUpDownPreco);
            this.Preco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Preco.Location = new System.Drawing.Point(4, 24);
            this.Preco.Name = "Preco";
            this.Preco.Padding = new System.Windows.Forms.Padding(3);
            this.Preco.Size = new System.Drawing.Size(553, 134);
            this.Preco.TabIndex = 1;
            this.Preco.Text = "Preço";
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
            this.comboBoxUnidadeDeMedida.Location = new System.Drawing.Point(12, 36);
            this.comboBoxUnidadeDeMedida.Name = "comboBoxUnidadeDeMedida";
            this.comboBoxUnidadeDeMedida.Size = new System.Drawing.Size(127, 23);
            this.comboBoxUnidadeDeMedida.TabIndex = 11;
            this.comboBoxUnidadeDeMedida.Tag = "Unidade de Medida";
            // 
            // kryptonLabelPreco
            // 
            this.kryptonLabelPreco.Location = new System.Drawing.Point(12, 69);
            this.kryptonLabelPreco.Name = "kryptonLabelPreco";
            this.kryptonLabelPreco.Size = new System.Drawing.Size(58, 21);
            this.kryptonLabelPreco.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelPreco.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelPreco.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelPreco.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelPreco.TabIndex = 9;
            this.kryptonLabelPreco.Values.ExtraText = "*";
            this.kryptonLabelPreco.Values.Text = "Preço";
            // 
            // kryptonLabelDescricao
            // 
            this.kryptonLabelDescricao.Location = new System.Drawing.Point(12, 9);
            this.kryptonLabelDescricao.Name = "kryptonLabelDescricao";
            this.kryptonLabelDescricao.Size = new System.Drawing.Size(145, 21);
            this.kryptonLabelDescricao.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelDescricao.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelDescricao.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelDescricao.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelDescricao.TabIndex = 8;
            this.kryptonLabelDescricao.Tag = "Descrição";
            this.kryptonLabelDescricao.Values.ExtraText = "*";
            this.kryptonLabelDescricao.Values.Text = "Unidade de medida";
            // 
            // numericUpDownPreco
            // 
            this.numericUpDownPreco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownPreco.DecimalPlaces = 2;
            this.numericUpDownPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownPreco.Location = new System.Drawing.Point(12, 96);
            this.numericUpDownPreco.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownPreco.Name = "numericUpDownPreco";
            this.numericUpDownPreco.Size = new System.Drawing.Size(106, 23);
            this.numericUpDownPreco.TabIndex = 9;
            this.numericUpDownPreco.Tag = "Preço";
            this.numericUpDownPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownPreco_KeyPress);
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
            this.dataGridViewProdutosFinais.RowHeadersWidth = 51;
            this.dataGridViewProdutosFinais.RowTemplate.Height = 25;
            this.dataGridViewProdutosFinais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutosFinais.ShowCellErrors = false;
            this.dataGridViewProdutosFinais.ShowCellToolTips = false;
            this.dataGridViewProdutosFinais.ShowEditingIcon = false;
            this.dataGridViewProdutosFinais.ShowRowErrors = false;
            this.dataGridViewProdutosFinais.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewProdutosFinais.TabIndex = 1;
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
            this.btnCancelar.Location = new System.Drawing.Point(634, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Todos",
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
            this.inputPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPesquisar_KeyPress);
            // 
            // ProdutosFinais
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
            this.Controls.Add(this.tabControlProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdutosFinais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos Finais";
            this.tabControlProdutos.ResumeLayout(false);
            this.Geral.ResumeLayout(false);
            this.Geral.PerformLayout();
            this.Preco.ResumeLayout(false);
            this.Preco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosFinais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControlProdutos;
        private TabPage Geral;
        private TabPage Preco;
        private DataGridView dataGridViewProdutosFinais;
        private NumericUpDown numericUpDownPreco;
        private TextBox inputNomeProduto;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnCadastrar;
        private PictureBox imgFiltro;
        private Button btnPesquisar;
        private ComboBox comboBoxFiltro;
        private TextBox inputPesquisar;
        private Button btnVincularOpcionais;
        private Button btnVincularComponentes;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNomeProduto;
        private Controls.ToggleButton toggleButtonAtivo;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxControlarEstoque;
        private Krypton.Toolkit.KryptonLabel kryptonLabelAtivo;
        private Krypton.Toolkit.KryptonLabel kryptonLabelPreco;
        private Krypton.Toolkit.KryptonLabel kryptonLabelDescricao;
        private ComboBox comboBoxUnidadeDeMedida;
    }
}