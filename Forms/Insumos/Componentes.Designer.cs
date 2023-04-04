namespace MovSoft.Forms
{
    partial class Componentes
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
            inputPesquisar = new TextBox();
            comboBoxFiltro = new ComboBox();
            imgFiltro = new PictureBox();
            btnPesquisar = new Button();
            comboBoxUnidadeDeMedida = new ComboBox();
            inputNomeComponente = new TextBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            pnlCadastro = new Panel();
            toggleButtonAtivo = new Controls.ToggleButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelUnidadeDeMedida = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelNome = new Krypton.Toolkit.KryptonLabel();
            dataGridViewComponentes = new DataGridView();
            kryptonCheckBoxControlarEstoque = new Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComponentes).BeginInit();
            SuspendLayout();
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
            inputPesquisar.KeyPress += inputPesquisar_KeyPress;
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
            comboBoxFiltro.TabIndex = 2;
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
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
            imgFiltro.TabIndex = 21;
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
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // comboBoxUnidadeDeMedida
            // 
            comboBoxUnidadeDeMedida.BackColor = Color.WhiteSmoke;
            comboBoxUnidadeDeMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnidadeDeMedida.ForeColor = Color.FromArgb(56, 56, 56);
            comboBoxUnidadeDeMedida.FormattingEnabled = true;
            comboBoxUnidadeDeMedida.Items.AddRange(new object[] { "Unidade (un)", "Metro (m)", "Milímetro (mm)", "Litro (L)", "Mililitro (mL)", "Quilograma (kg)", "Grama (g)", "Miligrama (mg)" });
            comboBoxUnidadeDeMedida.Location = new Point(14, 141);
            comboBoxUnidadeDeMedida.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnidadeDeMedida.Name = "comboBoxUnidadeDeMedida";
            comboBoxUnidadeDeMedida.Size = new Size(145, 28);
            comboBoxUnidadeDeMedida.TabIndex = 9;
            comboBoxUnidadeDeMedida.Tag = "Unidade de Medida";
            // 
            // inputNomeComponente
            // 
            inputNomeComponente.BackColor = Color.WhiteSmoke;
            inputNomeComponente.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeComponente.Location = new Point(14, 55);
            inputNomeComponente.Margin = new Padding(3, 4, 3, 4);
            inputNomeComponente.Name = "inputNomeComponente";
            inputNomeComponente.Size = new Size(204, 27);
            inputNomeComponente.TabIndex = 8;
            inputNomeComponente.Tag = "Nome do Componente";
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
            btnCadastrar.Location = new Point(725, 365);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(143, 45);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
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
            btnEditar.Location = new Point(725, 419);
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
            btnCancelar.Location = new Point(725, 472);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 45);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pnlCadastro
            // 
            pnlCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastro.BackColor = Color.FromArgb(114, 101, 75);
            pnlCadastro.BorderStyle = BorderStyle.Fixed3D;
            pnlCadastro.Controls.Add(kryptonCheckBoxControlarEstoque);
            pnlCadastro.Controls.Add(toggleButtonAtivo);
            pnlCadastro.Controls.Add(kryptonLabel1);
            pnlCadastro.Controls.Add(kryptonLabelUnidadeDeMedida);
            pnlCadastro.Controls.Add(kryptonLabelNome);
            pnlCadastro.Controls.Add(inputNomeComponente);
            pnlCadastro.Controls.Add(comboBoxUnidadeDeMedida);
            pnlCadastro.Enabled = false;
            pnlCadastro.ForeColor = Color.FromArgb(56, 56, 56);
            pnlCadastro.Location = new Point(226, 48);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(641, 215);
            pnlCadastro.TabIndex = 24;
            // 
            // toggleButtonAtivo
            // 
            toggleButtonAtivo.AutoSize = true;
            toggleButtonAtivo.BackColor = Color.Transparent;
            toggleButtonAtivo.Checked = true;
            toggleButtonAtivo.CheckState = CheckState.Checked;
            toggleButtonAtivo.Cursor = Cursors.Hand;
            toggleButtonAtivo.FocusToggleColor = Color.Gold;
            toggleButtonAtivo.Location = new Point(254, 55);
            toggleButtonAtivo.Margin = new Padding(3, 4, 3, 4);
            toggleButtonAtivo.MinimumSize = new Size(51, 31);
            toggleButtonAtivo.Name = "toggleButtonAtivo";
            toggleButtonAtivo.OffBackColor = Color.Gray;
            toggleButtonAtivo.OffToggleColor = Color.Gainsboro;
            toggleButtonAtivo.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButtonAtivo.OnToggleColor = Color.WhiteSmoke;
            toggleButtonAtivo.Size = new Size(51, 31);
            toggleButtonAtivo.TabIndex = 10;
            toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(254, 19);
            kryptonLabel1.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(54, 26);
            kryptonLabel1.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 10;
            kryptonLabel1.Values.Text = "Ativo";
            // 
            // kryptonLabelUnidadeDeMedida
            // 
            kryptonLabelUnidadeDeMedida.Location = new Point(14, 105);
            kryptonLabelUnidadeDeMedida.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelUnidadeDeMedida.Name = "kryptonLabelUnidadeDeMedida";
            kryptonLabelUnidadeDeMedida.Size = new Size(180, 26);
            kryptonLabelUnidadeDeMedida.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelUnidadeDeMedida.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUnidadeDeMedida.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelUnidadeDeMedida.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUnidadeDeMedida.TabIndex = 9;
            kryptonLabelUnidadeDeMedida.Values.ExtraText = "*";
            kryptonLabelUnidadeDeMedida.Values.Text = "Unidade de medida";
            // 
            // kryptonLabelNome
            // 
            kryptonLabelNome.Location = new Point(14, 19);
            kryptonLabelNome.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNome.Name = "kryptonLabelNome";
            kryptonLabelNome.Size = new Size(204, 26);
            kryptonLabelNome.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNome.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNome.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.TabIndex = 8;
            kryptonLabelNome.Values.ExtraText = "*";
            kryptonLabelNome.Values.Text = "Nome do componente";
            // 
            // dataGridViewComponentes
            // 
            dataGridViewComponentes.AllowUserToAddRows = false;
            dataGridViewComponentes.AllowUserToDeleteRows = false;
            dataGridViewComponentes.AllowUserToResizeColumns = false;
            dataGridViewComponentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewComponentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewComponentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewComponentes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewComponentes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewComponentes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewComponentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewComponentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewComponentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComponentes.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewComponentes.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewComponentes.EnableHeadersVisualStyles = false;
            dataGridViewComponentes.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewComponentes.Location = new Point(226, 365);
            dataGridViewComponentes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewComponentes.Name = "dataGridViewComponentes";
            dataGridViewComponentes.ReadOnly = true;
            dataGridViewComponentes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewComponentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewComponentes.RowHeadersVisible = false;
            dataGridViewComponentes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewComponentes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewComponentes.RowTemplate.Height = 25;
            dataGridViewComponentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewComponentes.ShowCellErrors = false;
            dataGridViewComponentes.ShowCellToolTips = false;
            dataGridViewComponentes.ShowEditingIcon = false;
            dataGridViewComponentes.ShowRowErrors = false;
            dataGridViewComponentes.Size = new Size(491, 189);
            dataGridViewComponentes.TabIndex = 25;
            dataGridViewComponentes.CellClick += dataGridViewComponentes_CellClick;
            dataGridViewComponentes.CellContentClick += dataGridView_CellContentClick;
            dataGridViewComponentes.CellDoubleClick += dataGridViewComponentes_CellDoubleClick;
            dataGridViewComponentes.CellFormatting += dataGridView_CellFormatting;
            // 
            // kryptonCheckBoxControlarEstoque
            // 
            kryptonCheckBoxControlarEstoque.Location = new Point(183, 141);
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
            // Componentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1063, 671);
            Controls.Add(dataGridViewComponentes);
            Controls.Add(pnlCadastro);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(imgFiltro);
            Controls.Add(btnPesquisar);
            Controls.Add(comboBoxFiltro);
            Controls.Add(inputPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Componentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Lista de Insumos";
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComponentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputPesquisar;
        private ComboBox comboBoxFiltro;
        private PictureBox imgFiltro;
        private Button btnPesquisar;
        private TextBox inputNomeComponente;
        private Label txtAtivo;
        private Controls.ToggleButton toggleButtonAtivoComponentes;
        private ComboBox comboBoxUnidadeDeMedida;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnCancelar;
        private Panel pnlCadastro;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNome;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabelUnidadeDeMedida;
        private Controls.ToggleButton toggleButtonAtivo;
        private Label txtObg3;
        private Label txtUnidadeDeMedida;
        private DataGridView dataGridViewComponentes;
        private Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxControlarEstoque;
    }
}