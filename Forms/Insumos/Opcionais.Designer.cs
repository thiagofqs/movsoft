namespace MovSoft.Forms
{
    partial class Opcionais
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
            inputNomeOpcional = new TextBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            dataGridViewOpcionais = new DataGridView();
            pnlCadastro = new Panel();
            btnAdicionarOpcoes = new Button();
            toggleButtonAtivo = new Controls.ToggleButton();
            kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelQuantidade = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelNome = new Krypton.Toolkit.KryptonLabel();
            numericUpDownOpcionais = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOpcionais).BeginInit();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOpcionais).BeginInit();
            SuspendLayout();
            // 
            // inputPesquisar
            // 
            inputPesquisar.BackColor = Color.WhiteSmoke;
            inputPesquisar.ForeColor = Color.FromArgb(56, 56, 56);
            inputPesquisar.Location = new Point(198, 243);
            inputPesquisar.Name = "inputPesquisar";
            inputPesquisar.PlaceholderText = "Pesquisar";
            inputPesquisar.Size = new Size(240, 23);
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
            comboBoxFiltro.Location = new Point(530, 243);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(98, 23);
            comboBoxFiltro.TabIndex = 2;
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
            // 
            // imgFiltro
            // 
            imgFiltro.BackColor = Color.Transparent;
            imgFiltro.BackgroundImage = Properties.Resources.icon_filter;
            imgFiltro.BackgroundImageLayout = ImageLayout.Zoom;
            imgFiltro.Location = new Point(501, 243);
            imgFiltro.Name = "imgFiltro";
            imgFiltro.Size = new Size(23, 23);
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
            btnPesquisar.Location = new Point(444, 243);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(23, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // inputNomeOpcional
            // 
            inputNomeOpcional.BackColor = Color.WhiteSmoke;
            inputNomeOpcional.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeOpcional.Location = new Point(12, 41);
            inputNomeOpcional.Name = "inputNomeOpcional";
            inputNomeOpcional.Size = new Size(179, 23);
            inputNomeOpcional.TabIndex = 8;
            inputNomeOpcional.Tag = "Nome do Opcional";
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
            btnCadastrar.Location = new Point(634, 274);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(125, 34);
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
            btnEditar.Location = new Point(634, 314);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 34);
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
            btnCancelar.Location = new Point(634, 354);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridViewOpcionais
            // 
            dataGridViewOpcionais.AllowUserToAddRows = false;
            dataGridViewOpcionais.AllowUserToDeleteRows = false;
            dataGridViewOpcionais.AllowUserToResizeColumns = false;
            dataGridViewOpcionais.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewOpcionais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOpcionais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOpcionais.BackgroundColor = Color.WhiteSmoke;
            dataGridViewOpcionais.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewOpcionais.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewOpcionais.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewOpcionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewOpcionais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOpcionais.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewOpcionais.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewOpcionais.EnableHeadersVisualStyles = false;
            dataGridViewOpcionais.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewOpcionais.Location = new Point(198, 274);
            dataGridViewOpcionais.Name = "dataGridViewOpcionais";
            dataGridViewOpcionais.ReadOnly = true;
            dataGridViewOpcionais.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewOpcionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewOpcionais.RowHeadersVisible = false;
            dataGridViewOpcionais.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewOpcionais.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewOpcionais.RowTemplate.Height = 25;
            dataGridViewOpcionais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOpcionais.ShowCellErrors = false;
            dataGridViewOpcionais.ShowCellToolTips = false;
            dataGridViewOpcionais.ShowEditingIcon = false;
            dataGridViewOpcionais.ShowRowErrors = false;
            dataGridViewOpcionais.Size = new Size(430, 142);
            dataGridViewOpcionais.TabIndex = 22;
            dataGridViewOpcionais.CellClick += dataGridViewOpcionais_CellClick;
            dataGridViewOpcionais.CellContentClick += dataGridViewOpcionais_CellContentClick;
            dataGridViewOpcionais.CellDoubleClick += dataGridViewOpcionais_CellDoubleClick;
            dataGridViewOpcionais.CellFormatting += dataGridViewOpcionais_CellFormatting;
            // 
            // pnlCadastro
            // 
            pnlCadastro.Anchor = AnchorStyles.Top;
            pnlCadastro.BackColor = Color.FromArgb(114, 101, 75);
            pnlCadastro.BorderStyle = BorderStyle.Fixed3D;
            pnlCadastro.Controls.Add(btnAdicionarOpcoes);
            pnlCadastro.Controls.Add(toggleButtonAtivo);
            pnlCadastro.Controls.Add(kryptonLabelAtivo);
            pnlCadastro.Controls.Add(kryptonLabelQuantidade);
            pnlCadastro.Controls.Add(kryptonLabelNome);
            pnlCadastro.Controls.Add(numericUpDownOpcionais);
            pnlCadastro.Controls.Add(inputNomeOpcional);
            pnlCadastro.Enabled = false;
            pnlCadastro.ForeColor = Color.FromArgb(56, 56, 56);
            pnlCadastro.Location = new Point(198, 36);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(561, 162);
            pnlCadastro.TabIndex = 10;
            // 
            // btnAdicionarOpcoes
            // 
            btnAdicionarOpcoes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionarOpcoes.BackColor = Color.FromArgb(0, 133, 132);
            btnAdicionarOpcoes.Cursor = Cursors.Hand;
            btnAdicionarOpcoes.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            btnAdicionarOpcoes.FlatAppearance.BorderSize = 0;
            btnAdicionarOpcoes.FlatStyle = FlatStyle.Flat;
            btnAdicionarOpcoes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdicionarOpcoes.ForeColor = Color.WhiteSmoke;
            btnAdicionarOpcoes.Location = new Point(418, 56);
            btnAdicionarOpcoes.Name = "btnAdicionarOpcoes";
            btnAdicionarOpcoes.Size = new Size(96, 48);
            btnAdicionarOpcoes.TabIndex = 11;
            btnAdicionarOpcoes.Text = "Adicionar Opções";
            btnAdicionarOpcoes.UseVisualStyleBackColor = false;
            btnAdicionarOpcoes.Click += btnAdicionarOpcoes_Click;
            // 
            // toggleButtonAtivo
            // 
            toggleButtonAtivo.AutoSize = true;
            toggleButtonAtivo.BackColor = Color.Transparent;
            toggleButtonAtivo.Checked = true;
            toggleButtonAtivo.CheckState = CheckState.Checked;
            toggleButtonAtivo.Cursor = Cursors.Hand;
            toggleButtonAtivo.FocusToggleColor = Color.Gold;
            toggleButtonAtivo.Location = new Point(146, 106);
            toggleButtonAtivo.MinimumSize = new Size(45, 23);
            toggleButtonAtivo.Name = "toggleButtonAtivo";
            toggleButtonAtivo.OffBackColor = Color.Gray;
            toggleButtonAtivo.OffToggleColor = Color.Gainsboro;
            toggleButtonAtivo.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButtonAtivo.OnToggleColor = Color.WhiteSmoke;
            toggleButtonAtivo.Size = new Size(45, 23);
            toggleButtonAtivo.TabIndex = 10;
            toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelAtivo
            // 
            kryptonLabelAtivo.Location = new Point(146, 79);
            kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            kryptonLabelAtivo.Size = new Size(45, 21);
            kryptonLabelAtivo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelAtivo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.TabIndex = 10;
            kryptonLabelAtivo.Values.Text = "Ativo";
            // 
            // kryptonLabelQuantidade
            // 
            kryptonLabelQuantidade.Location = new Point(12, 79);
            kryptonLabelQuantidade.Name = "kryptonLabelQuantidade";
            kryptonLabelQuantidade.Size = new Size(96, 21);
            kryptonLabelQuantidade.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelQuantidade.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelQuantidade.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelQuantidade.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelQuantidade.TabIndex = 9;
            kryptonLabelQuantidade.Values.ExtraText = "*";
            kryptonLabelQuantidade.Values.Text = "Quantidade";
            // 
            // kryptonLabelNome
            // 
            kryptonLabelNome.Location = new Point(12, 14);
            kryptonLabelNome.Name = "kryptonLabelNome";
            kryptonLabelNome.Size = new Size(139, 21);
            kryptonLabelNome.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNome.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNome.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.TabIndex = 8;
            kryptonLabelNome.Values.ExtraText = "*";
            kryptonLabelNome.Values.Text = "Nome do opcional";
            // 
            // numericUpDownOpcionais
            // 
            numericUpDownOpcionais.BackColor = Color.WhiteSmoke;
            numericUpDownOpcionais.ForeColor = Color.FromArgb(56, 56, 56);
            numericUpDownOpcionais.Location = new Point(12, 106);
            numericUpDownOpcionais.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDownOpcionais.Name = "numericUpDownOpcionais";
            numericUpDownOpcionais.Size = new Size(106, 23);
            numericUpDownOpcionais.TabIndex = 9;
            numericUpDownOpcionais.Tag = "Quantiade";
            // 
            // Opcionais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(930, 503);
            Controls.Add(pnlCadastro);
            Controls.Add(dataGridViewOpcionais);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(imgFiltro);
            Controls.Add(btnPesquisar);
            Controls.Add(comboBoxFiltro);
            Controls.Add(inputPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Opcionais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Lista de Insumos";
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOpcionais).EndInit();
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOpcionais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox inputPesquisar;
        private ComboBox comboBoxFiltro;
        private PictureBox imgFiltro;
        private Button btnPesquisar;
        private Button btnCadastrar;
        private TextBox inputNomeOpcional;
        private Button btnEditar;
        private Button btnCancelar;
        private DataGridView dataGridViewOpcionais;
        private Panel pnlCadastro;
        private NumericUpDown numericUpDownOpcionais;
        private Krypton.Toolkit.KryptonLabel kryptonLabelAtivo;
        private Krypton.Toolkit.KryptonLabel kryptonLabelQuantidade;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNome;
        private Controls.ToggleButton toggleButtonAtivo;
        private Button btnAdicionarOpcoes;
    }
}