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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            kryptonCheckBoxControlarEstoque = new Krypton.Toolkit.KryptonCheckBox();
            kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            toggleButtonAtivo = new Controls.ToggleButton();
            kryptonLabelNomeProduto = new Krypton.Toolkit.KryptonLabel();
            btnVincularOpcionais = new Button();
            btnVincularComponentes = new Button();
            inputNomeProduto = new TextBox();
            kryptonLabelPreco = new Krypton.Toolkit.KryptonLabel();
            numericUpDownPreco = new NumericUpDown();
            dataGridViewProdutosFinais = new DataGridView();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            imgFiltro = new PictureBox();
            btnPesquisar = new Button();
            comboBoxFiltro = new ComboBox();
            inputPesquisar = new TextBox();
            pnlCadastro = new Panel();
            kryptonLabelGrupo = new Krypton.Toolkit.KryptonLabel();
            comboBoxGrupo = new ComboBox();
            comboBoxFiltroGrupo = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutosFinais).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonCheckBoxControlarEstoque
            // 
            kryptonCheckBoxControlarEstoque.Location = new Point(151, 143);
            kryptonCheckBoxControlarEstoque.Margin = new Padding(3, 4, 3, 4);
            kryptonCheckBoxControlarEstoque.Name = "kryptonCheckBoxControlarEstoque";
            kryptonCheckBoxControlarEstoque.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonCheckBoxControlarEstoque.Size = new Size(170, 28);
            kryptonCheckBoxControlarEstoque.StateDisabled.LongText.Color1 = Color.DarkGray;
            kryptonCheckBoxControlarEstoque.StateDisabled.ShortText.Color1 = Color.DarkGray;
            kryptonCheckBoxControlarEstoque.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonCheckBoxControlarEstoque.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonCheckBoxControlarEstoque.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonCheckBoxControlarEstoque.TabIndex = 11;
            kryptonCheckBoxControlarEstoque.Values.Text = "Controlar estoque";
            // 
            // kryptonLabelAtivo
            // 
            kryptonLabelAtivo.Location = new Point(326, 107);
            kryptonLabelAtivo.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            kryptonLabelAtivo.Size = new Size(54, 26);
            kryptonLabelAtivo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelAtivo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.TabIndex = 12;
            kryptonLabelAtivo.Values.Text = "Ativo";
            // 
            // toggleButtonAtivo
            // 
            toggleButtonAtivo.AutoSize = true;
            toggleButtonAtivo.BackColor = Color.Transparent;
            toggleButtonAtivo.Checked = true;
            toggleButtonAtivo.CheckState = CheckState.Checked;
            toggleButtonAtivo.Cursor = Cursors.Hand;
            toggleButtonAtivo.FocusToggleColor = Color.Gold;
            toggleButtonAtivo.Location = new Point(326, 143);
            toggleButtonAtivo.Margin = new Padding(3, 4, 3, 4);
            toggleButtonAtivo.MinimumSize = new Size(51, 31);
            toggleButtonAtivo.Name = "toggleButtonAtivo";
            toggleButtonAtivo.OffBackColor = Color.Gray;
            toggleButtonAtivo.OffToggleColor = Color.Gainsboro;
            toggleButtonAtivo.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButtonAtivo.OnToggleColor = Color.WhiteSmoke;
            toggleButtonAtivo.Size = new Size(51, 31);
            toggleButtonAtivo.TabIndex = 12;
            toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelNomeProduto
            // 
            kryptonLabelNomeProduto.Location = new Point(14, 29);
            kryptonLabelNomeProduto.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNomeProduto.Name = "kryptonLabelNomeProduto";
            kryptonLabelNomeProduto.Size = new Size(169, 26);
            kryptonLabelNomeProduto.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNomeProduto.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNomeProduto.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNomeProduto.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNomeProduto.TabIndex = 8;
            kryptonLabelNomeProduto.Values.ExtraText = "*";
            kryptonLabelNomeProduto.Values.Text = "Nome do produto";
            // 
            // btnVincularOpcionais
            // 
            btnVincularOpcionais.BackColor = Color.FromArgb(0, 133, 132);
            btnVincularOpcionais.Cursor = Cursors.Hand;
            btnVincularOpcionais.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            btnVincularOpcionais.FlatAppearance.BorderSize = 0;
            btnVincularOpcionais.FlatStyle = FlatStyle.Flat;
            btnVincularOpcionais.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVincularOpcionais.ForeColor = Color.WhiteSmoke;
            btnVincularOpcionais.Location = new Point(502, 115);
            btnVincularOpcionais.Margin = new Padding(3, 4, 3, 4);
            btnVincularOpcionais.Name = "btnVincularOpcionais";
            btnVincularOpcionais.Size = new Size(110, 64);
            btnVincularOpcionais.TabIndex = 14;
            btnVincularOpcionais.Text = "Vincular Opcionais";
            btnVincularOpcionais.UseVisualStyleBackColor = false;
            btnVincularOpcionais.Click += btnVincularOpcionais_Click;
            // 
            // btnVincularComponentes
            // 
            btnVincularComponentes.BackColor = Color.FromArgb(0, 133, 132);
            btnVincularComponentes.Cursor = Cursors.Hand;
            btnVincularComponentes.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            btnVincularComponentes.FlatAppearance.BorderSize = 0;
            btnVincularComponentes.FlatStyle = FlatStyle.Flat;
            btnVincularComponentes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVincularComponentes.ForeColor = Color.WhiteSmoke;
            btnVincularComponentes.Location = new Point(502, 37);
            btnVincularComponentes.Margin = new Padding(3, 4, 3, 4);
            btnVincularComponentes.Name = "btnVincularComponentes";
            btnVincularComponentes.Size = new Size(110, 64);
            btnVincularComponentes.TabIndex = 13;
            btnVincularComponentes.Text = "Vincular Componentes";
            btnVincularComponentes.UseVisualStyleBackColor = false;
            btnVincularComponentes.Click += btnVincularComponentes_Click;
            // 
            // inputNomeProduto
            // 
            inputNomeProduto.BackColor = Color.WhiteSmoke;
            inputNomeProduto.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeProduto.Location = new Point(14, 65);
            inputNomeProduto.Margin = new Padding(3, 4, 3, 4);
            inputNomeProduto.Name = "inputNomeProduto";
            inputNomeProduto.Size = new Size(204, 27);
            inputNomeProduto.TabIndex = 8;
            inputNomeProduto.Tag = "Nome do Produto";
            // 
            // kryptonLabelPreco
            // 
            kryptonLabelPreco.Location = new Point(14, 107);
            kryptonLabelPreco.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelPreco.Name = "kryptonLabelPreco";
            kryptonLabelPreco.Size = new Size(71, 26);
            kryptonLabelPreco.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelPreco.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelPreco.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelPreco.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelPreco.TabIndex = 10;
            kryptonLabelPreco.Values.ExtraText = "*";
            kryptonLabelPreco.Values.Text = "Preço";
            // 
            // numericUpDownPreco
            // 
            numericUpDownPreco.BackColor = Color.WhiteSmoke;
            numericUpDownPreco.DecimalPlaces = 2;
            numericUpDownPreco.ForeColor = Color.FromArgb(56, 56, 56);
            numericUpDownPreco.Location = new Point(14, 143);
            numericUpDownPreco.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPreco.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownPreco.Name = "numericUpDownPreco";
            numericUpDownPreco.Size = new Size(121, 27);
            numericUpDownPreco.TabIndex = 10;
            numericUpDownPreco.Tag = "Preço";
            // 
            // dataGridViewProdutosFinais
            // 
            dataGridViewProdutosFinais.AllowUserToAddRows = false;
            dataGridViewProdutosFinais.AllowUserToDeleteRows = false;
            dataGridViewProdutosFinais.AllowUserToResizeColumns = false;
            dataGridViewProdutosFinais.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewProdutosFinais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProdutosFinais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProdutosFinais.BackgroundColor = Color.WhiteSmoke;
            dataGridViewProdutosFinais.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewProdutosFinais.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewProdutosFinais.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewProdutosFinais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProdutosFinais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutosFinais.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewProdutosFinais.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProdutosFinais.EnableHeadersVisualStyles = false;
            dataGridViewProdutosFinais.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewProdutosFinais.Location = new Point(226, 363);
            dataGridViewProdutosFinais.Margin = new Padding(3, 4, 3, 4);
            dataGridViewProdutosFinais.Name = "dataGridViewProdutosFinais";
            dataGridViewProdutosFinais.ReadOnly = true;
            dataGridViewProdutosFinais.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewProdutosFinais.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewProdutosFinais.RowHeadersVisible = false;
            dataGridViewProdutosFinais.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewProdutosFinais.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewProdutosFinais.RowTemplate.Height = 25;
            dataGridViewProdutosFinais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProdutosFinais.ShowCellErrors = false;
            dataGridViewProdutosFinais.ShowCellToolTips = false;
            dataGridViewProdutosFinais.ShowEditingIcon = false;
            dataGridViewProdutosFinais.ShowRowErrors = false;
            dataGridViewProdutosFinais.Size = new Size(491, 189);
            dataGridViewProdutosFinais.TabIndex = 1;
            dataGridViewProdutosFinais.CellContentClick += dataGridViewProdutosFinais_CellContentClick;
            dataGridViewProdutosFinais.CellDoubleClick += dataGridViewProdutosFinais_CellDoubleClick;
            dataGridViewProdutosFinais.CellEnter += dataGridViewProdutosFinais_CellClick;
            dataGridViewProdutosFinais.CellFormatting += dataGridViewProdutosFinais_CellFormatting;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(0, 133, 132);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.WhiteSmoke;
            btnEditar.Location = new Point(725, 416);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(143, 45);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(0, 133, 132);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Enabled = false;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(725, 469);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 45);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrar.BackColor = Color.FromArgb(0, 133, 132);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.WhiteSmoke;
            btnCadastrar.Location = new Point(725, 363);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(143, 45);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // imgFiltro
            // 
            imgFiltro.BackColor = Color.Transparent;
            imgFiltro.BackgroundImage = Properties.Resources.icon_filter;
            imgFiltro.BackgroundImageLayout = ImageLayout.Zoom;
            imgFiltro.Location = new Point(573, 324);
            imgFiltro.Margin = new Padding(3, 4, 3, 4);
            imgFiltro.Name = "imgFiltro";
            imgFiltro.Size = new Size(26, 31);
            imgFiltro.TabIndex = 25;
            imgFiltro.TabStop = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.BackgroundImage = Properties.Resources.icon_search;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.FromArgb(56, 56, 56);
            btnPesquisar.Location = new Point(507, 324);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(26, 31);
            btnPesquisar.TabIndex = 23;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // comboBoxFiltro
            // 
            comboBoxFiltro.BackColor = Color.WhiteSmoke;
            comboBoxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltro.ForeColor = Color.FromArgb(56, 56, 56);
            comboBoxFiltro.FormattingEnabled = true;
            comboBoxFiltro.Items.AddRange(new object[] { "Todos", "Habilitado", "Desabilitado" });
            comboBoxFiltro.Location = new Point(606, 324);
            comboBoxFiltro.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(111, 28);
            comboBoxFiltro.TabIndex = 24;
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
            // 
            // inputPesquisar
            // 
            inputPesquisar.BackColor = Color.WhiteSmoke;
            inputPesquisar.ForeColor = Color.FromArgb(56, 56, 56);
            inputPesquisar.Location = new Point(226, 324);
            inputPesquisar.Margin = new Padding(3, 4, 3, 4);
            inputPesquisar.Name = "inputPesquisar";
            inputPesquisar.PlaceholderText = "Pesquisar";
            inputPesquisar.Size = new Size(274, 27);
            inputPesquisar.TabIndex = 22;
            inputPesquisar.KeyPress += inputPesquisar_KeyPress;
            // 
            // pnlCadastro
            // 
            pnlCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastro.BackColor = Color.FromArgb(114, 101, 75);
            pnlCadastro.BorderStyle = BorderStyle.Fixed3D;
            pnlCadastro.Controls.Add(kryptonLabelGrupo);
            pnlCadastro.Controls.Add(comboBoxGrupo);
            pnlCadastro.Controls.Add(kryptonLabelPreco);
            pnlCadastro.Controls.Add(btnVincularOpcionais);
            pnlCadastro.Controls.Add(kryptonLabelAtivo);
            pnlCadastro.Controls.Add(numericUpDownPreco);
            pnlCadastro.Controls.Add(btnVincularComponentes);
            pnlCadastro.Controls.Add(kryptonCheckBoxControlarEstoque);
            pnlCadastro.Controls.Add(inputNomeProduto);
            pnlCadastro.Controls.Add(toggleButtonAtivo);
            pnlCadastro.Controls.Add(kryptonLabelNomeProduto);
            pnlCadastro.Enabled = false;
            pnlCadastro.ForeColor = Color.WhiteSmoke;
            pnlCadastro.Location = new Point(226, 48);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(641, 215);
            pnlCadastro.TabIndex = 7;
            // 
            // kryptonLabelGrupo
            // 
            kryptonLabelGrupo.Location = new Point(239, 29);
            kryptonLabelGrupo.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelGrupo.Name = "kryptonLabelGrupo";
            kryptonLabelGrupo.Size = new Size(76, 26);
            kryptonLabelGrupo.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelGrupo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelGrupo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelGrupo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelGrupo.TabIndex = 9;
            kryptonLabelGrupo.Values.ExtraText = "*";
            kryptonLabelGrupo.Values.Text = "Grupo";
            // 
            // comboBoxGrupo
            // 
            comboBoxGrupo.AutoCompleteMode = AutoCompleteMode.Append;
            comboBoxGrupo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxGrupo.BackColor = Color.WhiteSmoke;
            comboBoxGrupo.ForeColor = Color.FromArgb(56, 56, 56);
            comboBoxGrupo.FormattingEnabled = true;
            comboBoxGrupo.Location = new Point(239, 65);
            comboBoxGrupo.Margin = new Padding(3, 4, 3, 4);
            comboBoxGrupo.Name = "comboBoxGrupo";
            comboBoxGrupo.Size = new Size(138, 28);
            comboBoxGrupo.TabIndex = 9;
            comboBoxGrupo.Tag = "Grupo";
            comboBoxGrupo.Validating += comboBox1_Validating;
            // 
            // comboBoxFiltroGrupo
            // 
            comboBoxFiltroGrupo.BackColor = Color.WhiteSmoke;
            comboBoxFiltroGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltroGrupo.ForeColor = Color.FromArgb(56, 56, 56);
            comboBoxFiltroGrupo.FormattingEnabled = true;
            comboBoxFiltroGrupo.Items.AddRange(new object[] { "Grupos", "Todos" });
            comboBoxFiltroGrupo.Location = new Point(761, 324);
            comboBoxFiltroGrupo.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiltroGrupo.Name = "comboBoxFiltroGrupo";
            comboBoxFiltroGrupo.Size = new Size(111, 28);
            comboBoxFiltroGrupo.TabIndex = 26;
            comboBoxFiltroGrupo.DropDown += comboBox1_DropDown;
            comboBoxFiltroGrupo.SelectedIndexChanged += comboBoxFiltroGrupo_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.icon_filter;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(729, 324);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 31);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // ProdutosFinais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1063, 671);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxFiltroGrupo);
            Controls.Add(pnlCadastro);
            Controls.Add(imgFiltro);
            Controls.Add(btnPesquisar);
            Controls.Add(comboBoxFiltro);
            Controls.Add(inputPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(dataGridViewProdutosFinais);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProdutosFinais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos Finais";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutosFinais).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel pnlCadastro;
        private Krypton.Toolkit.KryptonLabel kryptonLabelGrupo;
        private ComboBox comboBoxGrupo;
        private ComboBox comboBoxFiltroGrupo;
        private PictureBox pictureBox1;
    }
}