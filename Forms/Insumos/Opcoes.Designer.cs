namespace MovSoft.Forms
{
    partial class Opcoes
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
            dataGridViewOpcoes = new DataGridView();
            pnlCadastro = new Panel();
            kryptonLabelUnidadeDeMedida = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelPreco = new Krypton.Toolkit.KryptonLabel();
            comboBoxUnidadeDeMedida = new ComboBox();
            numericUpDownPreco = new NumericUpDown();
            toggleButtonAtivo = new Controls.ToggleButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelNome = new Krypton.Toolkit.KryptonLabel();
            inputNomeOpcao = new TextBox();
            btnEditar = new Button();
            btnCancelar = new Button();
            btnCadastrar = new Button();
            imgFiltro = new PictureBox();
            btnPesquisar = new Button();
            comboBoxFiltro = new ComboBox();
            inputPesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOpcoes).BeginInit();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOpcoes
            // 
            dataGridViewOpcoes.AllowUserToAddRows = false;
            dataGridViewOpcoes.AllowUserToDeleteRows = false;
            dataGridViewOpcoes.AllowUserToResizeColumns = false;
            dataGridViewOpcoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewOpcoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOpcoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOpcoes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewOpcoes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewOpcoes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewOpcoes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewOpcoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOpcoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOpcoes.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewOpcoes.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewOpcoes.EnableHeadersVisualStyles = false;
            dataGridViewOpcoes.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewOpcoes.Location = new Point(202, 373);
            dataGridViewOpcoes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOpcoes.Name = "dataGridViewOpcoes";
            dataGridViewOpcoes.ReadOnly = true;
            dataGridViewOpcoes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewOpcoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewOpcoes.RowHeadersVisible = false;
            dataGridViewOpcoes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewOpcoes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewOpcoes.RowTemplate.Height = 25;
            dataGridViewOpcoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOpcoes.ShowCellErrors = false;
            dataGridViewOpcoes.ShowCellToolTips = false;
            dataGridViewOpcoes.ShowEditingIcon = false;
            dataGridViewOpcoes.ShowRowErrors = false;
            dataGridViewOpcoes.Size = new Size(491, 189);
            dataGridViewOpcoes.TabIndex = 6;
            dataGridViewOpcoes.CellClick += dataGridViewOpcoes_CellClick;
            dataGridViewOpcoes.CellContentClick += dataGridViewOpcoes_CellContentClick;
            dataGridViewOpcoes.CellDoubleClick += dataGridViewOpcoes_CellDoubleClick;
            dataGridViewOpcoes.CellFormatting += dataGridViewOpcoes_CellFormatting;
            // 
            // pnlCadastro
            // 
            pnlCadastro.Anchor = AnchorStyles.Top;
            pnlCadastro.BackColor = Color.FromArgb(114, 101, 75);
            pnlCadastro.BorderStyle = BorderStyle.Fixed3D;
            pnlCadastro.Controls.Add(kryptonLabelUnidadeDeMedida);
            pnlCadastro.Controls.Add(kryptonLabelPreco);
            pnlCadastro.Controls.Add(comboBoxUnidadeDeMedida);
            pnlCadastro.Controls.Add(numericUpDownPreco);
            pnlCadastro.Controls.Add(toggleButtonAtivo);
            pnlCadastro.Controls.Add(kryptonLabel1);
            pnlCadastro.Controls.Add(kryptonLabelNome);
            pnlCadastro.Controls.Add(inputNomeOpcao);
            pnlCadastro.Enabled = false;
            pnlCadastro.ForeColor = Color.FromArgb(56, 56, 56);
            pnlCadastro.Location = new Point(202, 56);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(641, 215);
            pnlCadastro.TabIndex = 7;
            // 
            // kryptonLabelUnidadeDeMedida
            // 
            kryptonLabelUnidadeDeMedida.Location = new Point(251, 19);
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
            // kryptonLabelPreco
            // 
            kryptonLabelPreco.Location = new Point(14, 112);
            kryptonLabelPreco.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelPreco.Name = "kryptonLabelPreco";
            kryptonLabelPreco.Size = new Size(56, 26);
            kryptonLabelPreco.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelPreco.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelPreco.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelPreco.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelPreco.TabIndex = 10;
            kryptonLabelPreco.Values.Text = "Preço";
            // 
            // comboBoxUnidadeDeMedida
            // 
            comboBoxUnidadeDeMedida.BackColor = Color.WhiteSmoke;
            comboBoxUnidadeDeMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnidadeDeMedida.ForeColor = Color.FromArgb(56, 56, 56);
            comboBoxUnidadeDeMedida.FormattingEnabled = true;
            comboBoxUnidadeDeMedida.Items.AddRange(new object[] { "Unidade (un)", "Metro (m)", "Milímetro (mm)", "Litro (L)", "Mililitro (mL)", "Quilograma (kg)", "Grama (g)", "Miligrama (mg)" });
            comboBoxUnidadeDeMedida.Location = new Point(251, 55);
            comboBoxUnidadeDeMedida.Margin = new Padding(3, 4, 3, 4);
            comboBoxUnidadeDeMedida.Name = "comboBoxUnidadeDeMedida";
            comboBoxUnidadeDeMedida.Size = new Size(145, 28);
            comboBoxUnidadeDeMedida.TabIndex = 9;
            comboBoxUnidadeDeMedida.Tag = "Unidade de Medida";
            // 
            // numericUpDownPreco
            // 
            numericUpDownPreco.BackColor = Color.WhiteSmoke;
            numericUpDownPreco.DecimalPlaces = 2;
            numericUpDownPreco.ForeColor = Color.FromArgb(56, 56, 56);
            numericUpDownPreco.Location = new Point(14, 148);
            numericUpDownPreco.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPreco.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownPreco.Name = "numericUpDownPreco";
            numericUpDownPreco.Size = new Size(121, 27);
            numericUpDownPreco.TabIndex = 10;
            numericUpDownPreco.Tag = "";
            // 
            // toggleButtonAtivo
            // 
            toggleButtonAtivo.AutoSize = true;
            toggleButtonAtivo.BackColor = Color.Transparent;
            toggleButtonAtivo.Checked = true;
            toggleButtonAtivo.CheckState = CheckState.Checked;
            toggleButtonAtivo.Cursor = Cursors.Hand;
            toggleButtonAtivo.FocusToggleColor = Color.Gold;
            toggleButtonAtivo.Location = new Point(167, 148);
            toggleButtonAtivo.Margin = new Padding(3, 4, 3, 4);
            toggleButtonAtivo.MinimumSize = new Size(51, 31);
            toggleButtonAtivo.Name = "toggleButtonAtivo";
            toggleButtonAtivo.OffBackColor = Color.Gray;
            toggleButtonAtivo.OffToggleColor = Color.Gainsboro;
            toggleButtonAtivo.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButtonAtivo.OnToggleColor = Color.WhiteSmoke;
            toggleButtonAtivo.Size = new Size(51, 31);
            toggleButtonAtivo.TabIndex = 11;
            toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(167, 112);
            kryptonLabel1.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(54, 26);
            kryptonLabel1.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 11;
            kryptonLabel1.Values.Text = "Ativo";
            // 
            // kryptonLabelNome
            // 
            kryptonLabelNome.Location = new Point(14, 19);
            kryptonLabelNome.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNome.Name = "kryptonLabelNome";
            kryptonLabelNome.Size = new Size(151, 26);
            kryptonLabelNome.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNome.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNome.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.TabIndex = 8;
            kryptonLabelNome.Values.ExtraText = "*";
            kryptonLabelNome.Values.Text = "Nome da opção";
            // 
            // inputNomeOpcao
            // 
            inputNomeOpcao.BackColor = Color.WhiteSmoke;
            inputNomeOpcao.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeOpcao.Location = new Point(14, 55);
            inputNomeOpcao.Margin = new Padding(3, 4, 3, 4);
            inputNomeOpcao.Name = "inputNomeOpcao";
            inputNomeOpcao.Size = new Size(204, 27);
            inputNomeOpcao.TabIndex = 8;
            inputNomeOpcao.Tag = "Nome da Opção";
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
            btnEditar.Location = new Point(701, 427);
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
            btnCancelar.Location = new Point(701, 480);
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
            btnCadastrar.Location = new Point(701, 373);
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
            imgFiltro.Location = new Point(549, 332);
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
            btnPesquisar.Location = new Point(483, 332);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(26, 31);
            btnPesquisar.TabIndex = 1;
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
            comboBoxFiltro.Location = new Point(582, 332);
            comboBoxFiltro.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(111, 28);
            comboBoxFiltro.TabIndex = 2;
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
            // 
            // inputPesquisar
            // 
            inputPesquisar.BackColor = Color.WhiteSmoke;
            inputPesquisar.ForeColor = Color.FromArgb(56, 56, 56);
            inputPesquisar.Location = new Point(202, 332);
            inputPesquisar.Margin = new Padding(3, 4, 3, 4);
            inputPesquisar.Name = "inputPesquisar";
            inputPesquisar.PlaceholderText = "Pesquisar";
            inputPesquisar.Size = new Size(274, 27);
            inputPesquisar.TabIndex = 0;
            inputPesquisar.KeyPress += inputPesquisar_KeyPress;
            // 
            // Opcoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1045, 619);
            Controls.Add(dataGridViewOpcoes);
            Controls.Add(pnlCadastro);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(imgFiltro);
            Controls.Add(btnPesquisar);
            Controls.Add(comboBoxFiltro);
            Controls.Add(inputPesquisar);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Opcoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Adicionar Opções";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOpcoes).EndInit();
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOpcoes;
        private Panel pnlCadastro;
        private Controls.ToggleButton toggleButtonAtivo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNome;
        private TextBox inputNomeOpcao;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnCadastrar;
        private PictureBox imgFiltro;
        private Button btnPesquisar;
        private ComboBox comboBoxFiltro;
        private TextBox inputPesquisar;
        private Krypton.Toolkit.KryptonLabel kryptonLabelPreco;
        private NumericUpDown numericUpDownPreco;
        private Krypton.Toolkit.KryptonLabel kryptonLabelUnidadeDeMedida;
        private ComboBox comboBoxUnidadeDeMedida;
    }
}