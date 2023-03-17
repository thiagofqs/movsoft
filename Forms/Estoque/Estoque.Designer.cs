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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlCadastro = new Panel();
            kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            toggleButtonAtivo = new Controls.ToggleButton();
            kryptonLabelMovimento = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelProduto = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelCusto = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelQuantidade = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelFornecedor = new Krypton.Toolkit.KryptonLabel();
            comboBoxMovimento = new ComboBox();
            numericUpCusto = new NumericUpDown();
            numericUpDownQuantidade = new NumericUpDown();
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            dataGridViewEstoque = new DataGridView();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            imgFiltro = new PictureBox();
            btnPesquisar = new Button();
            comboBoxFiltro = new ComboBox();
            inputPesquisar = new TextBox();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpCusto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            SuspendLayout();
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.FromArgb(114, 101, 75);
            pnlCadastro.BorderStyle = BorderStyle.Fixed3D;
            pnlCadastro.Controls.Add(kryptonLabelAtivo);
            pnlCadastro.Controls.Add(toggleButtonAtivo);
            pnlCadastro.Controls.Add(kryptonLabelMovimento);
            pnlCadastro.Controls.Add(kryptonLabelProduto);
            pnlCadastro.Controls.Add(kryptonLabelCusto);
            pnlCadastro.Controls.Add(kryptonLabelQuantidade);
            pnlCadastro.Controls.Add(kryptonLabelFornecedor);
            pnlCadastro.Controls.Add(comboBoxMovimento);
            pnlCadastro.Controls.Add(numericUpCusto);
            pnlCadastro.Controls.Add(numericUpDownQuantidade);
            pnlCadastro.Controls.Add(comboBoxProduto);
            pnlCadastro.Controls.Add(comboBoxFornecedor);
            pnlCadastro.Enabled = false;
            pnlCadastro.ForeColor = Color.FromArgb(56, 56, 56);
            pnlCadastro.Location = new Point(226, 48);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(641, 215);
            pnlCadastro.TabIndex = 7;
            // 
            // kryptonLabelAtivo
            // 
            kryptonLabelAtivo.Location = new Point(362, 107);
            kryptonLabelAtivo.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            kryptonLabelAtivo.Size = new Size(54, 26);
            kryptonLabelAtivo.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelAtivo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelAtivo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.TabIndex = 13;
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
            toggleButtonAtivo.Location = new Point(362, 143);
            toggleButtonAtivo.Margin = new Padding(3, 4, 3, 4);
            toggleButtonAtivo.MinimumSize = new Size(51, 31);
            toggleButtonAtivo.Name = "toggleButtonAtivo";
            toggleButtonAtivo.OffBackColor = Color.Gray;
            toggleButtonAtivo.OffToggleColor = Color.Gainsboro;
            toggleButtonAtivo.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButtonAtivo.OnToggleColor = Color.WhiteSmoke;
            toggleButtonAtivo.Size = new Size(51, 31);
            toggleButtonAtivo.TabIndex = 13;
            toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelMovimento
            // 
            kryptonLabelMovimento.Location = new Point(320, 13);
            kryptonLabelMovimento.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelMovimento.Name = "kryptonLabelMovimento";
            kryptonLabelMovimento.Size = new Size(118, 26);
            kryptonLabelMovimento.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelMovimento.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelMovimento.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelMovimento.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelMovimento.TabIndex = 10;
            kryptonLabelMovimento.Values.ExtraText = "*";
            kryptonLabelMovimento.Values.Text = "Movimento";
            // 
            // kryptonLabelProduto
            // 
            kryptonLabelProduto.Location = new Point(169, 13);
            kryptonLabelProduto.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelProduto.Name = "kryptonLabelProduto";
            kryptonLabelProduto.Size = new Size(91, 26);
            kryptonLabelProduto.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelProduto.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelProduto.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelProduto.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelProduto.TabIndex = 9;
            kryptonLabelProduto.Values.ExtraText = "*";
            kryptonLabelProduto.Values.Text = "Produto";
            // 
            // kryptonLabelCusto
            // 
            kryptonLabelCusto.Location = new Point(169, 107);
            kryptonLabelCusto.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCusto.Name = "kryptonLabelCusto";
            kryptonLabelCusto.Size = new Size(72, 26);
            kryptonLabelCusto.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCusto.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCusto.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCusto.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCusto.TabIndex = 12;
            kryptonLabelCusto.Values.ExtraText = "*";
            kryptonLabelCusto.Values.Text = "Custo";
            // 
            // kryptonLabelQuantidade
            // 
            kryptonLabelQuantidade.Location = new Point(15, 107);
            kryptonLabelQuantidade.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelQuantidade.Name = "kryptonLabelQuantidade";
            kryptonLabelQuantidade.Size = new Size(119, 26);
            kryptonLabelQuantidade.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelQuantidade.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelQuantidade.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelQuantidade.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelQuantidade.TabIndex = 11;
            kryptonLabelQuantidade.Values.ExtraText = "*";
            kryptonLabelQuantidade.Values.Text = "Quantidade";
            // 
            // kryptonLabelFornecedor
            // 
            kryptonLabelFornecedor.Location = new Point(14, 13);
            kryptonLabelFornecedor.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelFornecedor.Name = "kryptonLabelFornecedor";
            kryptonLabelFornecedor.Size = new Size(116, 26);
            kryptonLabelFornecedor.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelFornecedor.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelFornecedor.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelFornecedor.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelFornecedor.TabIndex = 8;
            kryptonLabelFornecedor.Values.ExtraText = "*";
            kryptonLabelFornecedor.Values.Text = "Fornecedor";
            // 
            // comboBoxMovimento
            // 
            comboBoxMovimento.FormattingEnabled = true;
            comboBoxMovimento.Location = new Point(320, 49);
            comboBoxMovimento.Margin = new Padding(3, 4, 3, 4);
            comboBoxMovimento.Name = "comboBoxMovimento";
            comboBoxMovimento.Size = new Size(141, 28);
            comboBoxMovimento.TabIndex = 10;
            comboBoxMovimento.Tag = "Movimento";
            // 
            // numericUpCusto
            // 
            numericUpCusto.BackColor = Color.WhiteSmoke;
            numericUpCusto.DecimalPlaces = 2;
            numericUpCusto.ForeColor = Color.FromArgb(56, 56, 56);
            numericUpCusto.Location = new Point(170, 141);
            numericUpCusto.Margin = new Padding(3, 4, 3, 4);
            numericUpCusto.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpCusto.Name = "numericUpCusto";
            numericUpCusto.Size = new Size(121, 27);
            numericUpCusto.TabIndex = 12;
            numericUpCusto.Tag = "Custo";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.BackColor = Color.WhiteSmoke;
            numericUpDownQuantidade.DecimalPlaces = 2;
            numericUpDownQuantidade.ForeColor = Color.FromArgb(56, 56, 56);
            numericUpDownQuantidade.Location = new Point(15, 143);
            numericUpDownQuantidade.Margin = new Padding(3, 4, 3, 4);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(121, 27);
            numericUpDownQuantidade.TabIndex = 11;
            numericUpDownQuantidade.Tag = "Quantidade";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(169, 49);
            comboBoxProduto.Margin = new Padding(3, 4, 3, 4);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(122, 28);
            comboBoxProduto.TabIndex = 9;
            comboBoxProduto.Tag = "Produto";
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(14, 49);
            comboBoxFornecedor.Margin = new Padding(3, 4, 3, 4);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(122, 28);
            comboBoxFornecedor.TabIndex = 8;
            comboBoxFornecedor.Tag = "Fornecedor";
            // 
            // dataGridViewEstoque
            // 
            dataGridViewEstoque.AllowUserToAddRows = false;
            dataGridViewEstoque.AllowUserToDeleteRows = false;
            dataGridViewEstoque.AllowUserToResizeColumns = false;
            dataGridViewEstoque.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEstoque.BackgroundColor = Color.WhiteSmoke;
            dataGridViewEstoque.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewEstoque.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewEstoque.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstoque.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEstoque.EnableHeadersVisualStyles = false;
            dataGridViewEstoque.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewEstoque.Location = new Point(226, 364);
            dataGridViewEstoque.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEstoque.Name = "dataGridViewEstoque";
            dataGridViewEstoque.ReadOnly = true;
            dataGridViewEstoque.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewEstoque.RowHeadersVisible = false;
            dataGridViewEstoque.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewEstoque.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewEstoque.RowTemplate.Height = 25;
            dataGridViewEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEstoque.ShowCellErrors = false;
            dataGridViewEstoque.ShowCellToolTips = false;
            dataGridViewEstoque.ShowEditingIcon = false;
            dataGridViewEstoque.ShowRowErrors = false;
            dataGridViewEstoque.Size = new Size(491, 189);
            dataGridViewEstoque.TabIndex = 33;
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
            btnEditar.Location = new Point(725, 421);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(143, 45);
            btnEditar.TabIndex = 4;
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
            btnCancelar.Location = new Point(725, 475);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 45);
            btnCancelar.TabIndex = 5;
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
            btnCadastrar.Location = new Point(725, 368);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(143, 45);
            btnCadastrar.TabIndex = 3;
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
            imgFiltro.TabIndex = 32;
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
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // comboBoxFiltro
            // 
            comboBoxFiltro.BackColor = Color.WhiteSmoke;
            comboBoxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltro.ForeColor = Color.FromArgb(56, 56, 56);
            comboBoxFiltro.FormattingEnabled = true;
            comboBoxFiltro.Items.AddRange(new object[] { "Habilitado", "Desabilitado" });
            comboBoxFiltro.Location = new Point(606, 324);
            comboBoxFiltro.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(111, 28);
            comboBoxFiltro.TabIndex = 2;
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
            inputPesquisar.TabIndex = 0;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1063, 671);
            Controls.Add(dataGridViewEstoque);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(imgFiltro);
            Controls.Add(btnPesquisar);
            Controls.Add(comboBoxFiltro);
            Controls.Add(inputPesquisar);
            Controls.Add(pnlCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Estoque";
            Text = "MovSoft - Estoque";
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpCusto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            ResumeLayout(false);
            PerformLayout();
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