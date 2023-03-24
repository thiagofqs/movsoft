namespace MovSoft.Forms
{
    partial class Estoque
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
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            this.toggleButtonAtivo = new MovSoft.Controls.ToggleButton();
            this.kryptonLabelMovimento = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelProduto = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCusto = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelQuantidade = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelFornecedor = new Krypton.Toolkit.KryptonLabel();
            this.comboBoxMovimento = new System.Windows.Forms.ComboBox();
            this.numericUpCusto = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQuantidade = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.imgFiltro = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.inputPesquisar = new System.Windows.Forms.TextBox();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadastro.Controls.Add(this.kryptonLabelAtivo);
            this.pnlCadastro.Controls.Add(this.toggleButtonAtivo);
            this.pnlCadastro.Controls.Add(this.kryptonLabelMovimento);
            this.pnlCadastro.Controls.Add(this.kryptonLabelProduto);
            this.pnlCadastro.Controls.Add(this.kryptonLabelCusto);
            this.pnlCadastro.Controls.Add(this.kryptonLabelQuantidade);
            this.pnlCadastro.Controls.Add(this.kryptonLabelFornecedor);
            this.pnlCadastro.Controls.Add(this.comboBoxMovimento);
            this.pnlCadastro.Controls.Add(this.numericUpCusto);
            this.pnlCadastro.Controls.Add(this.numericUpDownQuantidade);
            this.pnlCadastro.Controls.Add(this.comboBoxProduto);
            this.pnlCadastro.Controls.Add(this.comboBoxFornecedor);
            this.pnlCadastro.Enabled = false;
            this.pnlCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlCadastro.Location = new System.Drawing.Point(198, 36);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(561, 162);
            this.pnlCadastro.TabIndex = 7;
            // 
            // kryptonLabelAtivo
            // 
            this.kryptonLabelAtivo.Location = new System.Drawing.Point(280, 79);
            this.kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            this.kryptonLabelAtivo.Size = new System.Drawing.Size(45, 21);
            this.kryptonLabelAtivo.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelAtivo.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelAtivo.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.TabIndex = 13;
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
            this.toggleButtonAtivo.Location = new System.Drawing.Point(280, 106);
            this.toggleButtonAtivo.MinimumSize = new System.Drawing.Size(45, 23);
            this.toggleButtonAtivo.Name = "toggleButtonAtivo";
            this.toggleButtonAtivo.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonAtivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonAtivo.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButtonAtivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonAtivo.Size = new System.Drawing.Size(45, 23);
            this.toggleButtonAtivo.TabIndex = 13;
            this.toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelMovimento
            // 
            this.kryptonLabelMovimento.Location = new System.Drawing.Point(280, 10);
            this.kryptonLabelMovimento.Name = "kryptonLabelMovimento";
            this.kryptonLabelMovimento.Size = new System.Drawing.Size(96, 21);
            this.kryptonLabelMovimento.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelMovimento.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelMovimento.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelMovimento.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelMovimento.TabIndex = 10;
            this.kryptonLabelMovimento.Values.ExtraText = "*";
            this.kryptonLabelMovimento.Values.Text = "Movimento";
            // 
            // kryptonLabelProduto
            // 
            this.kryptonLabelProduto.Location = new System.Drawing.Point(148, 10);
            this.kryptonLabelProduto.Name = "kryptonLabelProduto";
            this.kryptonLabelProduto.Size = new System.Drawing.Size(74, 21);
            this.kryptonLabelProduto.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelProduto.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelProduto.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelProduto.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelProduto.TabIndex = 9;
            this.kryptonLabelProduto.Values.ExtraText = "*";
            this.kryptonLabelProduto.Values.Text = "Produto";
            // 
            // kryptonLabelCusto
            // 
            this.kryptonLabelCusto.Location = new System.Drawing.Point(148, 80);
            this.kryptonLabelCusto.Name = "kryptonLabelCusto";
            this.kryptonLabelCusto.Size = new System.Drawing.Size(59, 21);
            this.kryptonLabelCusto.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCusto.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCusto.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCusto.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCusto.TabIndex = 12;
            this.kryptonLabelCusto.Values.ExtraText = "*";
            this.kryptonLabelCusto.Values.Text = "Custo";
            // 
            // kryptonLabelQuantidade
            // 
            this.kryptonLabelQuantidade.Location = new System.Drawing.Point(13, 80);
            this.kryptonLabelQuantidade.Name = "kryptonLabelQuantidade";
            this.kryptonLabelQuantidade.Size = new System.Drawing.Size(96, 21);
            this.kryptonLabelQuantidade.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelQuantidade.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelQuantidade.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelQuantidade.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelQuantidade.TabIndex = 11;
            this.kryptonLabelQuantidade.Values.ExtraText = "*";
            this.kryptonLabelQuantidade.Values.Text = "Quantidade";
            // 
            // kryptonLabelFornecedor
            // 
            this.kryptonLabelFornecedor.Location = new System.Drawing.Point(12, 10);
            this.kryptonLabelFornecedor.Name = "kryptonLabelFornecedor";
            this.kryptonLabelFornecedor.Size = new System.Drawing.Size(94, 21);
            this.kryptonLabelFornecedor.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelFornecedor.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelFornecedor.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelFornecedor.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelFornecedor.TabIndex = 8;
            this.kryptonLabelFornecedor.Values.ExtraText = "*";
            this.kryptonLabelFornecedor.Values.Text = "Fornecedor";
            // 
            // comboBoxMovimento
            // 
            this.comboBoxMovimento.FormattingEnabled = true;
            this.comboBoxMovimento.Location = new System.Drawing.Point(280, 37);
            this.comboBoxMovimento.Name = "comboBoxMovimento";
            this.comboBoxMovimento.Size = new System.Drawing.Size(124, 23);
            this.comboBoxMovimento.TabIndex = 10;
            this.comboBoxMovimento.Tag = "Movimento";
            // 
            // numericUpCusto
            // 
            this.numericUpCusto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpCusto.DecimalPlaces = 2;
            this.numericUpCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpCusto.Location = new System.Drawing.Point(149, 106);
            this.numericUpCusto.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpCusto.Name = "numericUpCusto";
            this.numericUpCusto.Size = new System.Drawing.Size(106, 23);
            this.numericUpCusto.TabIndex = 12;
            this.numericUpCusto.Tag = "Custo";
            // 
            // numericUpDownQuantidade
            // 
            this.numericUpDownQuantidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numericUpDownQuantidade.DecimalPlaces = 2;
            this.numericUpDownQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownQuantidade.Location = new System.Drawing.Point(13, 107);
            this.numericUpDownQuantidade.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            this.numericUpDownQuantidade.Size = new System.Drawing.Size(106, 23);
            this.numericUpDownQuantidade.TabIndex = 11;
            this.numericUpDownQuantidade.Tag = "Quantidade";
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(148, 37);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(107, 23);
            this.comboBoxProduto.TabIndex = 9;
            this.comboBoxProduto.Tag = "Produto";
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(12, 37);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(107, 23);
            this.comboBoxFornecedor.TabIndex = 8;
            this.comboBoxFornecedor.Tag = "Fornecedor";
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AllowUserToAddRows = false;
            this.dataGridViewEstoque.AllowUserToDeleteRows = false;
            this.dataGridViewEstoque.AllowUserToResizeColumns = false;
            this.dataGridViewEstoque.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEstoque.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEstoque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEstoque.EnableHeadersVisualStyles = false;
            this.dataGridViewEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dataGridViewEstoque.Location = new System.Drawing.Point(198, 273);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.ReadOnly = true;
            this.dataGridViewEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEstoque.RowHeadersVisible = false;
            this.dataGridViewEstoque.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewEstoque.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEstoque.RowTemplate.Height = 25;
            this.dataGridViewEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstoque.ShowCellErrors = false;
            this.dataGridViewEstoque.ShowCellToolTips = false;
            this.dataGridViewEstoque.ShowEditingIcon = false;
            this.dataGridViewEstoque.ShowRowErrors = false;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewEstoque.TabIndex = 33;
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
            this.btnEditar.Location = new System.Drawing.Point(634, 316);
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
            this.btnCancelar.Location = new System.Drawing.Point(634, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 34);
            this.btnCancelar.TabIndex = 5;
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
            this.btnCadastrar.Location = new System.Drawing.Point(634, 276);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 34);
            this.btnCadastrar.TabIndex = 3;
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
            this.imgFiltro.TabIndex = 32;
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
            this.comboBoxFiltro.TabIndex = 2;
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
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.imgFiltro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.inputPesquisar);
            this.Controls.Add(this.pnlCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.Text = "MovSoft - Estoque";
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlCadastro;
        private DataGridView dataGridViewEstoque;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnCadastrar;
        private PictureBox imgFiltro;
        private Button btnPesquisar;
        private ComboBox comboBoxFiltro;
        private TextBox inputPesquisar;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpCusto;
        private ComboBox comboBoxMovimento;
        private Krypton.Toolkit.KryptonLabel kryptonLabelMovimento;
        private Krypton.Toolkit.KryptonLabel kryptonLabelProduto;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCusto;
        private Krypton.Toolkit.KryptonLabel kryptonLabelQuantidade;
        private Krypton.Toolkit.KryptonLabel kryptonLabelFornecedor;
        private Krypton.Toolkit.KryptonLabel kryptonLabelAtivo;
        private Controls.ToggleButton toggleButtonAtivo;
    }
}