namespace MovSoft.Forms
{
    partial class ListaColaboradores
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            btnCadColaboradores = new Button();
            dataGridView = new DataGridView();
            inputPesquisarColaborador = new TextBox();
            btnPesquisar = new Button();
            comboBoxFiltro = new ComboBox();
            imgFiltro = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            SuspendLayout();
            // 
            // btnCadColaboradores
            // 
            btnCadColaboradores.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadColaboradores.BackColor = Color.FromArgb(0, 133, 132);
            btnCadColaboradores.Cursor = Cursors.Hand;
            btnCadColaboradores.FlatAppearance.BorderSize = 0;
            btnCadColaboradores.FlatStyle = FlatStyle.Flat;
            btnCadColaboradores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadColaboradores.ForeColor = Color.WhiteSmoke;
            btnCadColaboradores.Location = new Point(539, 422);
            btnCadColaboradores.Name = "btnCadColaboradores";
            btnCadColaboradores.Size = new Size(220, 34);
            btnCadColaboradores.TabIndex = 5;
            btnCadColaboradores.Text = "Cadastrar Colaborador";
            btnCadColaboradores.UseVisualStyleBackColor = false;
            btnCadColaboradores.Click += btnCadColaboradores_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.WhiteSmoke;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Cursor = Cursors.Hand;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.FromArgb(56, 56, 56);
            dataGridView.Location = new Point(198, 95);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
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
            // imgFiltro
            // 
            imgFiltro.BackColor = Color.Transparent;
            imgFiltro.BackgroundImage = Properties.Resources.icon_filter;
            imgFiltro.BackgroundImageLayout = ImageLayout.Zoom;
            imgFiltro.Location = new Point(501, 66);
            imgFiltro.Name = "imgFiltro";
            imgFiltro.Size = new Size(23, 23);
            imgFiltro.TabIndex = 9;
            imgFiltro.TabStop = false;
            // 
            // ListaColaboradores
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
            Controls.Add(btnCadColaboradores);
            ForeColor = Color.FromArgb(56, 56, 56);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListaColaboradores";
            Text = "MovSoft - Lista de Colaboradores";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCadColaboradores;
        private DataGridView dataGridView;
        private TextBox inputPesquisarColaborador;
        private Button btnPesquisar;
        private ComboBox comboBoxFiltro;
        private PictureBox imgFiltro;
    }
}