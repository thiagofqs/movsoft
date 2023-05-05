namespace MovSoft.Forms
{
    partial class HistoricoEstoque
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
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            comboBox1 = new ComboBox();
            kryptonLabelMovimento = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelProduto = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelQuantidade = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelFornecedor = new Krypton.Toolkit.KryptonLabel();
            comboBoxMovimento = new ComboBox();
            numericUpDownQuantidade = new NumericUpDown();
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            dataGridViewEstoque = new DataGridView();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).BeginInit();
            SuspendLayout();
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.FromArgb(114, 101, 75);
            pnlCadastro.BorderStyle = BorderStyle.Fixed3D;
            pnlCadastro.Controls.Add(kryptonLabel1);
            pnlCadastro.Controls.Add(comboBox1);
            pnlCadastro.Controls.Add(kryptonLabelMovimento);
            pnlCadastro.Controls.Add(kryptonLabelProduto);
            pnlCadastro.Controls.Add(kryptonLabelQuantidade);
            pnlCadastro.Controls.Add(kryptonLabelFornecedor);
            pnlCadastro.Controls.Add(comboBoxMovimento);
            pnlCadastro.Controls.Add(numericUpDownQuantidade);
            pnlCadastro.Controls.Add(comboBoxProduto);
            pnlCadastro.Controls.Add(comboBoxFornecedor);
            pnlCadastro.Enabled = false;
            pnlCadastro.ForeColor = Color.FromArgb(56, 56, 56);
            pnlCadastro.Location = new Point(198, 36);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(561, 162);
            pnlCadastro.TabIndex = 7;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(262, 80);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(104, 21);
            kryptonLabel1.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabel1.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 15;
            kryptonLabel1.Values.ExtraText = "*";
            kryptonLabel1.Values.Text = "Tipo do Item";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Produto", "Componente", "Opção" });
            comboBox1.Location = new Point(262, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 23);
            comboBox1.TabIndex = 14;
            comboBox1.Tag = "Tipo do Item";
            comboBox1.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // kryptonLabelMovimento
            // 
            kryptonLabelMovimento.Location = new Point(12, 80);
            kryptonLabelMovimento.Name = "kryptonLabelMovimento";
            kryptonLabelMovimento.Size = new Size(96, 21);
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
            kryptonLabelProduto.Location = new Point(12, 10);
            kryptonLabelProduto.Name = "kryptonLabelProduto";
            kryptonLabelProduto.Size = new Size(52, 21);
            kryptonLabelProduto.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelProduto.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelProduto.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelProduto.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelProduto.TabIndex = 9;
            kryptonLabelProduto.Values.ExtraText = "*";
            kryptonLabelProduto.Values.Text = "Item";
            // 
            // kryptonLabelQuantidade
            // 
            kryptonLabelQuantidade.Location = new Point(139, 79);
            kryptonLabelQuantidade.Name = "kryptonLabelQuantidade";
            kryptonLabelQuantidade.Size = new Size(96, 21);
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
            kryptonLabelFornecedor.Location = new Point(201, 10);
            kryptonLabelFornecedor.Name = "kryptonLabelFornecedor";
            kryptonLabelFornecedor.Size = new Size(94, 21);
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
            comboBoxMovimento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMovimento.FormattingEnabled = true;
            comboBoxMovimento.Items.AddRange(new object[] { "Saída", "Entrada" });
            comboBoxMovimento.Location = new Point(12, 106);
            comboBoxMovimento.Name = "comboBoxMovimento";
            comboBoxMovimento.Size = new Size(107, 23);
            comboBoxMovimento.TabIndex = 10;
            comboBoxMovimento.Tag = "Movimento";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.BackColor = Color.WhiteSmoke;
            numericUpDownQuantidade.DecimalPlaces = 2;
            numericUpDownQuantidade.ForeColor = Color.FromArgb(56, 56, 56);
            numericUpDownQuantidade.Location = new Point(139, 106);
            numericUpDownQuantidade.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(106, 23);
            numericUpDownQuantidade.TabIndex = 11;
            numericUpDownQuantidade.Tag = "Quantidade";
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduto.DropDownWidth = 161;
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(12, 37);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(161, 23);
            comboBoxProduto.TabIndex = 8;
            comboBoxProduto.Tag = "Item";
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(201, 37);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(168, 23);
            comboBoxFornecedor.TabIndex = 9;
            comboBoxFornecedor.Tag = "Fornecedor";
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
            btnCancelar.Location = new Point(634, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 34);
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
            btnCadastrar.Location = new Point(634, 272);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 34);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            dataGridViewEstoque.Location = new Point(198, 272);
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
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewEstoque.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewEstoque.RowTemplate.Height = 25;
            dataGridViewEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEstoque.ShowCellErrors = false;
            dataGridViewEstoque.ShowCellToolTips = false;
            dataGridViewEstoque.ShowEditingIcon = false;
            dataGridViewEstoque.ShowRowErrors = false;
            dataGridViewEstoque.Size = new Size(430, 142);
            dataGridViewEstoque.TabIndex = 34;
            // 
            // HistoricoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(930, 503);
            Controls.Add(dataGridViewEstoque);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(pnlCadastro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HistoricoEstoque";
            Text = "MovSoft - Historico Estoque";
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadastro;
        private Button btnCancelar;
        private Button btnCadastrar;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private NumericUpDown numericUpDownQuantidade;
        private ComboBox comboBoxMovimento;
        private Krypton.Toolkit.KryptonLabel kryptonLabelMovimento;
        private Krypton.Toolkit.KryptonLabel kryptonLabelProduto;
        private Krypton.Toolkit.KryptonLabel kryptonLabelQuantidade;
        private Krypton.Toolkit.KryptonLabel kryptonLabelFornecedor;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComboBox comboBox1;
        private DataGridView dataGridViewEstoque;
    }
}