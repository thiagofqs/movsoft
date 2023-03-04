namespace MovSoft
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
            inputPesquisarGrupos = new TextBox();
            dataGridViewGrupos = new DataGridView();
            btnPesquisar = new Button();
            inputNomeGrupo = new TextBox();
            txtNomeGrupo = new Label();
            txtObr1 = new Label();
            txtObr2 = new Label();
            txtAtivo = new Label();
            toggleButtonAtivo = new Controls.ToggleButton();
            btnCadastrarGrupos = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            imgFiltro = new PictureBox();
            comboBoxFiltro = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).BeginInit();
            SuspendLayout();
            // 
            // inputPesquisarGrupos
            // 
            inputPesquisarGrupos.BackColor = Color.WhiteSmoke;
            inputPesquisarGrupos.ForeColor = Color.FromArgb(56, 56, 56);
            inputPesquisarGrupos.Location = new Point(198, 243);
            inputPesquisarGrupos.Name = "inputPesquisarGrupos";
            inputPesquisarGrupos.PlaceholderText = "Pesquisar";
            inputPesquisarGrupos.Size = new Size(240, 23);
            inputPesquisarGrupos.TabIndex = 2;
            // 
            // dataGridViewGrupos
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewGrupos.BackgroundColor = Color.WhiteSmoke;
            dataGridViewGrupos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewGrupos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewGrupos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewGrupos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGrupos.Location = new Point(198, 274);
            dataGridViewGrupos.Name = "dataGridViewGrupos";
            dataGridViewGrupos.RowTemplate.Height = 25;
            dataGridViewGrupos.Size = new Size(430, 142);
            dataGridViewGrupos.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.BackgroundImage = Properties.Resources.icon_search;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Location = new Point(444, 243);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(23, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnSearch_Click;
            // 
            // inputNomeGrupo
            // 
            inputNomeGrupo.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeGrupo.Location = new Point(12, 34);
            inputNomeGrupo.Name = "inputNomeGrupo";
            inputNomeGrupo.Size = new Size(179, 23);
            inputNomeGrupo.TabIndex = 0;
            // 
            // txtNomeGrupo
            // 
            txtNomeGrupo.AutoSize = true;
            txtNomeGrupo.BackColor = Color.Transparent;
            txtNomeGrupo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNomeGrupo.ForeColor = Color.WhiteSmoke;
            txtNomeGrupo.Location = new Point(12, 14);
            txtNomeGrupo.Name = "txtNomeGrupo";
            txtNomeGrupo.Size = new Size(106, 17);
            txtNomeGrupo.TabIndex = 0;
            txtNomeGrupo.Text = "Nome do grupo";
            // 
            // txtObr1
            // 
            txtObr1.AutoSize = true;
            txtObr1.BackColor = Color.Transparent;
            txtObr1.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr1.Location = new Point(124, 16);
            txtObr1.Name = "txtObr1";
            txtObr1.Size = new Size(12, 15);
            txtObr1.TabIndex = 0;
            txtObr1.Text = "*";
            // 
            // txtObr2
            // 
            txtObr2.AutoSize = true;
            txtObr2.BackColor = Color.Transparent;
            txtObr2.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr2.Location = new Point(264, 17);
            txtObr2.Name = "txtObr2";
            txtObr2.Size = new Size(12, 15);
            txtObr2.TabIndex = 1;
            txtObr2.Text = "*";
            // 
            // txtAtivo
            // 
            txtAtivo.AutoSize = true;
            txtAtivo.BackColor = Color.Transparent;
            txtAtivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAtivo.ForeColor = Color.WhiteSmoke;
            txtAtivo.Location = new Point(217, 15);
            txtAtivo.Name = "txtAtivo";
            txtAtivo.Size = new Size(41, 17);
            txtAtivo.TabIndex = 1;
            txtAtivo.Text = "Ativo";
            txtAtivo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // toggleButtonAtivo
            // 
            toggleButtonAtivo.AutoSize = true;
            toggleButtonAtivo.Checked = true;
            toggleButtonAtivo.CheckState = CheckState.Checked;
            toggleButtonAtivo.Cursor = Cursors.Hand;
            toggleButtonAtivo.FocusToggleColor = Color.Gold;
            toggleButtonAtivo.Location = new Point(217, 35);
            toggleButtonAtivo.MinimumSize = new Size(45, 22);
            toggleButtonAtivo.Name = "toggleButtonAtivo";
            toggleButtonAtivo.OffBackColor = Color.Gray;
            toggleButtonAtivo.OffToggleColor = Color.Gainsboro;
            toggleButtonAtivo.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButtonAtivo.OnToggleColor = Color.WhiteSmoke;
            toggleButtonAtivo.Size = new Size(45, 22);
            toggleButtonAtivo.TabIndex = 1;
            toggleButtonAtivo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarGrupos
            // 
            btnCadastrarGrupos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCadastrarGrupos.BackColor = Color.FromArgb(0, 133, 132);
            btnCadastrarGrupos.Cursor = Cursors.Hand;
            btnCadastrarGrupos.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            btnCadastrarGrupos.FlatAppearance.BorderSize = 0;
            btnCadastrarGrupos.FlatStyle = FlatStyle.Flat;
            btnCadastrarGrupos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarGrupos.ForeColor = Color.WhiteSmoke;
            btnCadastrarGrupos.Location = new Point(634, 274);
            btnCadastrarGrupos.Name = "btnCadastrarGrupos";
            btnCadastrarGrupos.Size = new Size(125, 34);
            btnCadastrarGrupos.TabIndex = 5;
            btnCadastrarGrupos.Text = "Cadastrar";
            btnCadastrarGrupos.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(0, 133, 132);
            button1.Cursor = Cursors.Hand;
            button1.Enabled = false;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(634, 354);
            button1.Name = "button1";
            button1.Size = new Size(125, 34);
            button1.TabIndex = 7;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(0, 133, 132);
            button2.Cursor = Cursors.Hand;
            button2.Enabled = false;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(634, 314);
            button2.Name = "button2";
            button2.Size = new Size(125, 34);
            button2.TabIndex = 6;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(114, 101, 75);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(inputNomeGrupo);
            panel1.Controls.Add(txtNomeGrupo);
            panel1.Controls.Add(txtObr1);
            panel1.Controls.Add(toggleButtonAtivo);
            panel1.Controls.Add(txtObr2);
            panel1.Controls.Add(txtAtivo);
            panel1.Enabled = false;
            panel1.ForeColor = Color.FromArgb(56, 56, 56);
            panel1.Location = new Point(198, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 162);
            panel1.TabIndex = 17;
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
            comboBoxFiltro.TabIndex = 4;
            // 
            // Grupos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(930, 503);
            Controls.Add(imgFiltro);
            Controls.Add(comboBoxFiltro);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCadastrarGrupos);
            Controls.Add(btnPesquisar);
            Controls.Add(dataGridViewGrupos);
            Controls.Add(inputPesquisarGrupos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Grupos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Lista de Grupos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewGrupos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFiltro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputPesquisarGrupos;
        private DataGridView dataGridViewGrupos;
        private Button btnPesquisar;
        private TextBox inputNomeGrupo;
        private Label txtNomeGrupo;
        private Label txtObr1;
        private Label txtObr2;
        private Label txtAtivo;
        private Controls.ToggleButton toggleButtonAtivo;
        private Button btnCadastrarGrupos;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private PictureBox imgFiltro;
        private ComboBox comboBoxFiltro;
    }
}