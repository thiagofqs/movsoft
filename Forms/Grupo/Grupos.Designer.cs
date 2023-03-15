namespace MovSoft.Forms
{
    partial class Grupos
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
            inputPesquisar = new TextBox();
            btnPesquisar = new Button();
            inputNomeGrupo = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            pnlCadastro = new Panel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            toggleButton1 = new Controls.ToggleButton();
            kryptonLabelNome = new Krypton.Toolkit.KryptonLabel();
            imgFiltro = new PictureBox();
            comboBoxFiltro = new ComboBox();
            dataGridViewGrupos = new DataGridView();
            pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).BeginInit();
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
            inputPesquisar.KeyPress += inputPesquisarGrupos_KeyPress;
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
            // inputNomeGrupo
            // 
            inputNomeGrupo.BackColor = Color.WhiteSmoke;
            inputNomeGrupo.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeGrupo.Location = new Point(12, 41);
            inputNomeGrupo.Name = "inputNomeGrupo";
            inputNomeGrupo.Size = new Size(179, 23);
            inputNomeGrupo.TabIndex = 7;
            inputNomeGrupo.KeyPress += inputNomeGrupo_KeyPress;
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
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.FromArgb(114, 101, 75);
            pnlCadastro.BorderStyle = BorderStyle.Fixed3D;
            pnlCadastro.Controls.Add(kryptonLabel1);
            pnlCadastro.Controls.Add(toggleButton1);
            pnlCadastro.Controls.Add(kryptonLabelNome);
            pnlCadastro.Controls.Add(inputNomeGrupo);
            pnlCadastro.Enabled = false;
            pnlCadastro.ForeColor = Color.FromArgb(56, 56, 56);
            pnlCadastro.Location = new Point(198, 36);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(561, 162);
            pnlCadastro.TabIndex = 7;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(222, 14);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(57, 21);
            kryptonLabel1.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabel1.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 11;
            kryptonLabel1.Values.ExtraText = "*";
            kryptonLabel1.Values.Text = "Ativo";
            // 
            // toggleButton1
            // 
            toggleButton1.AutoSize = true;
            toggleButton1.BackColor = Color.Transparent;
            toggleButton1.Checked = true;
            toggleButton1.CheckState = CheckState.Checked;
            toggleButton1.Cursor = Cursors.Hand;
            toggleButton1.FocusToggleColor = Color.Gold;
            toggleButton1.Location = new Point(222, 41);
            toggleButton1.MinimumSize = new Size(45, 23);
            toggleButton1.Name = "toggleButton1";
            toggleButton1.OffBackColor = Color.Gray;
            toggleButton1.OffToggleColor = Color.Gainsboro;
            toggleButton1.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButton1.OnToggleColor = Color.WhiteSmoke;
            toggleButton1.Size = new Size(45, 23);
            toggleButton1.TabIndex = 10;
            toggleButton1.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelNome
            // 
            kryptonLabelNome.Location = new Point(12, 14);
            kryptonLabelNome.Name = "kryptonLabelNome";
            kryptonLabelNome.Size = new Size(123, 21);
            kryptonLabelNome.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNome.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNome.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.TabIndex = 9;
            kryptonLabelNome.Values.ExtraText = "*";
            kryptonLabelNome.Values.Text = "Nome do grupo";
            // 
            // imgFiltro
            // 
            imgFiltro.BackColor = Color.Transparent;
            imgFiltro.BackgroundImage = Properties.Resources.icon_filter;
            imgFiltro.BackgroundImageLayout = ImageLayout.Zoom;
            imgFiltro.Location = new Point(501, 243);
            imgFiltro.Name = "imgFiltro";
            imgFiltro.Size = new Size(23, 23);
            imgFiltro.TabIndex = 19;
            imgFiltro.TabStop = false;
            // 
            // comboBoxFiltro
            // 
            comboBoxFiltro.BackColor = Color.WhiteSmoke;
            comboBoxFiltro.Cursor = Cursors.Hand;
            comboBoxFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFiltro.ForeColor = Color.FromArgb(56, 56, 56);
            comboBoxFiltro.FormattingEnabled = true;
            comboBoxFiltro.Items.AddRange(new object[] { "Habilitado", "Desabilitado" });
            comboBoxFiltro.Location = new Point(530, 243);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(98, 23);
            comboBoxFiltro.TabIndex = 2;
            // 
            // dataGridViewGrupos
            // 
            dataGridViewGrupos.AllowUserToAddRows = false;
            dataGridViewGrupos.AllowUserToDeleteRows = false;
            dataGridViewGrupos.AllowUserToResizeColumns = false;
            dataGridViewGrupos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGrupos.BackgroundColor = Color.WhiteSmoke;
            dataGridViewGrupos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewGrupos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewGrupos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Cursor = Cursors.Hand;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewGrupos.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewGrupos.EnableHeadersVisualStyles = false;
            dataGridViewGrupos.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewGrupos.Location = new Point(198, 274);
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.ReadOnly = true;
            dataGridViewGrupos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewGrupos.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewGrupos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewGrupos.RowTemplate.Height = 25;
            dataGridViewGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrupos.ShowCellErrors = false;
            dataGridViewGrupos.ShowCellToolTips = false;
            dataGridViewGrupos.ShowEditingIcon = false;
            dataGridViewGrupos.ShowRowErrors = false;
            dataGridViewGrupos.Size = new Size(430, 142);
            dataGridViewGrupos.TabIndex = 20;
            // 
            // Grupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(930, 503);
            Controls.Add(dataGridViewGrupos);
            Controls.Add(imgFiltro);
            Controls.Add(comboBoxFiltro);
            Controls.Add(pnlCadastro);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnPesquisar);
            Controls.Add(inputPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grupos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Lista de Grupos";
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputPesquisar;
        private Button btnPesquisar;
        private TextBox inputNomeGrupo;
        private Button btnCadastrar;
        private Button btnCancelar;
        private Button btnEditar;
        private Panel pnlCadastro;
        private PictureBox imgFiltro;
        private ComboBox comboBoxFiltro;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Controls.ToggleButton toggleButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNome;
        private DataGridView dataGridViewGrupos;
    }
}