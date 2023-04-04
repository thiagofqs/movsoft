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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            inputPesquisar = new TextBox();
            btnPesquisar = new Button();
            inputNomeGrupo = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            btnEditar = new Button();
            pnlCadastro = new Panel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            toggleButtonAtivo = new Controls.ToggleButton();
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
            inputPesquisar.Location = new Point(226, 324);
            inputPesquisar.Margin = new Padding(3, 4, 3, 4);
            inputPesquisar.Name = "inputPesquisar";
            inputPesquisar.PlaceholderText = "Pesquisar";
            inputPesquisar.Size = new Size(274, 27);
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
            btnPesquisar.Location = new Point(507, 324);
            btnPesquisar.Margin = new Padding(3, 4, 3, 4);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(26, 31);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // inputNomeGrupo
            // 
            inputNomeGrupo.BackColor = Color.WhiteSmoke;
            inputNomeGrupo.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeGrupo.Location = new Point(14, 55);
            inputNomeGrupo.Margin = new Padding(3, 4, 3, 4);
            inputNomeGrupo.Name = "inputNomeGrupo";
            inputNomeGrupo.Size = new Size(204, 27);
            inputNomeGrupo.TabIndex = 7;
            inputNomeGrupo.Tag = "Nome do Grupo";
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
            btnCadastrar.Location = new Point(725, 363);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(143, 45);
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
            btnCancelar.Location = new Point(725, 469);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 45);
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
            btnEditar.Location = new Point(725, 416);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(143, 45);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // pnlCadastro
            // 
            pnlCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastro.BackColor = Color.FromArgb(114, 101, 75);
            pnlCadastro.BorderStyle = BorderStyle.Fixed3D;
            pnlCadastro.Controls.Add(kryptonLabel1);
            pnlCadastro.Controls.Add(toggleButtonAtivo);
            pnlCadastro.Controls.Add(kryptonLabelNome);
            pnlCadastro.Controls.Add(inputNomeGrupo);
            pnlCadastro.Enabled = false;
            pnlCadastro.ForeColor = Color.FromArgb(56, 56, 56);
            pnlCadastro.Location = new Point(226, 48);
            pnlCadastro.Margin = new Padding(3, 4, 3, 4);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(641, 215);
            pnlCadastro.TabIndex = 7;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(254, 19);
            kryptonLabel1.Margin = new Padding(3, 4, 3, 4);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(69, 26);
            kryptonLabel1.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabel1.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 11;
            kryptonLabel1.Values.ExtraText = "*";
            kryptonLabel1.Values.Text = "Ativo";
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
            toggleButtonAtivo.Tag = "";
            toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelNome
            // 
            kryptonLabelNome.Location = new Point(14, 19);
            kryptonLabelNome.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNome.Name = "kryptonLabelNome";
            kryptonLabelNome.Size = new Size(152, 26);
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
            imgFiltro.Location = new Point(573, 324);
            imgFiltro.Margin = new Padding(3, 4, 3, 4);
            imgFiltro.Name = "imgFiltro";
            imgFiltro.Size = new Size(26, 31);
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
            comboBoxFiltro.Items.AddRange(new object[] { "Todos", "Habilitado", "Desabilitado" });
            comboBoxFiltro.Location = new Point(606, 324);
            comboBoxFiltro.Margin = new Padding(3, 4, 3, 4);
            comboBoxFiltro.Name = "comboBoxFiltro";
            comboBoxFiltro.Size = new Size(111, 28);
            comboBoxFiltro.TabIndex = 2;
            comboBoxFiltro.SelectedIndexChanged += comboBoxFiltro_SelectedIndexChanged;
            // 
            // dataGridViewGrupos
            // 
            dataGridViewGrupos.AllowUserToAddRows = false;
            dataGridViewGrupos.AllowUserToDeleteRows = false;
            dataGridViewGrupos.AllowUserToResizeColumns = false;
            dataGridViewGrupos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGrupos.BackgroundColor = Color.WhiteSmoke;
            dataGridViewGrupos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewGrupos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewGrupos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewGrupos.EnableHeadersVisualStyles = false;
            dataGridViewGrupos.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewGrupos.Location = new Point(226, 363);
            dataGridViewGrupos.Margin = new Padding(3, 4, 3, 4);
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.ReadOnly = true;
            dataGridViewGrupos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewGrupos.RowHeadersVisible = false;
            dataGridViewGrupos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewGrupos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewGrupos.RowTemplate.Height = 25;
            dataGridViewGrupos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGrupos.ShowCellErrors = false;
            dataGridViewGrupos.ShowCellToolTips = false;
            dataGridViewGrupos.ShowEditingIcon = false;
            dataGridViewGrupos.ShowRowErrors = false;
            dataGridViewGrupos.Size = new Size(491, 189);
            dataGridViewGrupos.TabIndex = 20;
            dataGridViewGrupos.CellClick += dataGridViewGrupos_CellClick;
            dataGridViewGrupos.CellContentClick += dataGridViewGrupos_CellContentClick;
            dataGridViewGrupos.CellDoubleClick += dataGridViewGrupos_CellDoubleClick;
            dataGridViewGrupos.CellFormatting += dataGridViewGrupos_CellFormatting;
            // 
            // Grupos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1063, 671);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Controls.ToggleButton toggleButtonAtivo;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNome;
        private DataGridView dataGridViewGrupos;
    }
}