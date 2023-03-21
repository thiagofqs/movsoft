namespace MovSoft.Forms
{
    partial class ListaClientes
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
            inputPesquisarClientes = new TextBox();
            dataGridView = new DataGridView();
            btnCadClientes = new Button();
            btnPesquisar = new Button();
            imgFiltro = new PictureBox();
            comboBoxFiltro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            SuspendLayout();
            // 
            // inputPesquisarClientes
            // 
            inputPesquisarClientes.BackColor = Color.WhiteSmoke;
            inputPesquisarClientes.ForeColor = Color.FromArgb(56, 56, 56);
            inputPesquisarClientes.Location = new Point(226, 88);
            inputPesquisarClientes.Margin = new Padding(3, 4, 3, 4);
            inputPesquisarClientes.MaximumSize = new Size(274, 23);
            inputPesquisarClientes.MaxLength = 0;
            inputPesquisarClientes.Name = "inputPesquisarClientes";
            inputPesquisarClientes.PlaceholderText = "Pesquisar";
            inputPesquisarClientes.Size = new Size(274, 23);
            inputPesquisarClientes.TabIndex = 0;
            inputPesquisarClientes.KeyPress += inputPesquisarClientes_KeyPress;
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
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
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
            dataGridView.Location = new Point(226, 127);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
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
            dataGridView.Size = new Size(641, 428);
            dataGridView.TabIndex = 4;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // btnCadClientes
            // 
            btnCadClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadClientes.BackColor = Color.FromArgb(0, 133, 132);
            btnCadClientes.Cursor = Cursors.Hand;
            btnCadClientes.FlatAppearance.BorderSize = 0;
            btnCadClientes.FlatStyle = FlatStyle.Flat;
            btnCadClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadClientes.ForeColor = Color.WhiteSmoke;
            btnCadClientes.Location = new Point(658, 563);
            btnCadClientes.Margin = new Padding(3, 4, 3, 4);
            btnCadClientes.MaximumSize = new Size(245, 45);
            btnCadClientes.Name = "btnCadClientes";
            btnCadClientes.Size = new Size(209, 45);
            btnCadClientes.TabIndex = 5;
            btnCadClientes.Text = "Cadastrar Cliente";
            btnCadClientes.UseVisualStyleBackColor = false;
            btnCadClientes.Click += btnCadClientes_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.BackgroundImage = Properties.Resources.icon_search;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Location = new Point(507, 88);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(26, 31);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // imgFiltro
            // 
            imgFiltro.BackColor = Color.Transparent;
            imgFiltro.BackgroundImage = Properties.Resources.icon_filter;
            imgFiltro.BackgroundImageLayout = ImageLayout.Zoom;
            imgFiltro.Location = new Point(573, 88);
            imgFiltro.Margin = new Padding(3, 4, 3, 4);
            imgFiltro.Name = "imgFiltro";
            imgFiltro.Size = new Size(26, 31);
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
            comboBoxFiltro.Location = new Point(606, 88);
            comboBoxFiltro.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(111, 28);
            comboBoxFiltro.TabIndex = 2;
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
            // 
            // ListaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1063, 671);
            Controls.Add(imgFiltro);
            Controls.Add(comboBoxFiltro);
            Controls.Add(btnPesquisar);
            Controls.Add(inputPesquisarClientes);
            Controls.Add(dataGridView);
            Controls.Add(btnCadClientes);
            ForeColor = Color.FromArgb(56, 56, 56);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputPesquisarClientes;
        private DataGridView dataGridView;
        private Button btnCadClientes;
        private Button btnPesquisar;
        private PictureBox imgFiltro;
        private ComboBox comboBoxFiltro;
    }
}