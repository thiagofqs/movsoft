namespace MovSoft.Forms
{
    partial class ListaFornecedores
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
            inputPesquisarColaborador = new TextBox();
            dataGridView = new DataGridView();
            btnCadFornecedores = new Button();
            btnPesquisar = new Button();
            imgFiltro = new PictureBox();
            comboBoxFiltro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            SuspendLayout();
            // 
            // inputPesquisarColaborador
            // 
            inputPesquisarColaborador.BackColor = Color.WhiteSmoke;
            inputPesquisarColaborador.ForeColor = Color.FromArgb(56, 56, 56);
            inputPesquisarColaborador.Location = new Point(198, 66);
            inputPesquisarColaborador.MaximumSize = new Size(240, 23);
            inputPesquisarColaborador.MaxLength = 0;
            inputPesquisarColaborador.Name = "inputPesquisarColaborador";
            inputPesquisarColaborador.PlaceholderText = "Pesquisar";
            inputPesquisarColaborador.Size = new Size(240, 23);
            inputPesquisarColaborador.TabIndex = 0;
            inputPesquisarColaborador.KeyPress += inputPesquisarColaborador_KeyPress;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.WhiteSmoke;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(56, 56, 56);
            dataGridView.Location = new Point(198, 95);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ShowCellErrors = false;
            dataGridView.ShowCellToolTips = false;
            dataGridView.ShowEditingIcon = false;
            dataGridView.ShowRowErrors = false;
            dataGridView.Size = new Size(561, 321);
            dataGridView.TabIndex = 4;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // btnCadFornecedores
            // 
            btnCadFornecedores.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadFornecedores.BackColor = Color.FromArgb(0, 133, 132);
            btnCadFornecedores.Cursor = Cursors.Hand;
            btnCadFornecedores.FlatAppearance.BorderSize = 0;
            btnCadFornecedores.FlatStyle = FlatStyle.Flat;
            btnCadFornecedores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadFornecedores.ForeColor = Color.WhiteSmoke;
            btnCadFornecedores.Location = new Point(548, 422);
            btnCadFornecedores.Name = "btnCadFornecedores";
            btnCadFornecedores.Size = new Size(211, 34);
            btnCadFornecedores.TabIndex = 5;
            btnCadFornecedores.Text = "Cadastrar Fornecedor";
            btnCadFornecedores.UseVisualStyleBackColor = false;
            btnCadFornecedores.Click += btnCadFornecedores_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.BackgroundImage = Properties.Resources.icon_search;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Location = new Point(444, 66);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(23, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // imgFiltro
            // 
            imgFiltro.BackColor = Color.Transparent;
            imgFiltro.BackgroundImage = Properties.Resources.icon_filter;
            imgFiltro.BackgroundImageLayout = ImageLayout.Zoom;
            imgFiltro.Location = new Point(501, 66);
            imgFiltro.Name = "imgFiltro";
            imgFiltro.Size = new Size(23, 23);
            imgFiltro.TabIndex = 11;
            imgFiltro.TabStop = false;
            // 
            // comboBoxFiltro
            // 
            comboBoxFiltro.BackColor = Color.WhiteSmoke;
            comboBoxFiltro.Cursor = Cursors.Hand;
            comboBoxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltro.ForeColor = Color.FromArgb(56, 56, 56);
            comboBoxFiltro.FormattingEnabled = true;
            comboBoxFiltro.Items.AddRange(new object[] { "Todos", "Habilitado", "Desabilitado" });
            comboBoxFiltro.Location = new Point(530, 66);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(108, 23);
            comboBoxFiltro.TabIndex = 2;
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
            // 
            // ListaFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(930, 503);
            Controls.Add(imgFiltro);
            Controls.Add(comboBoxFiltro);
            Controls.Add(btnPesquisar);
            Controls.Add(inputPesquisarColaborador);
            Controls.Add(dataGridView);
            Controls.Add(btnCadFornecedores);
            ForeColor = Color.FromArgb(56, 56, 56);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaFornecedores";
            Text = "ListaFornecedores";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputPesquisarColaborador;
        private DataGridView dataGridView;
        private Button btnCadFornecedores;
        private Button btnPesquisar;
        private PictureBox imgFiltro;
        private ComboBox comboBoxFiltro;
    }
}