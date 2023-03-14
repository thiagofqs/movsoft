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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridViewGrupos = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.inputNomeGrupo = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.toggleButton1 = new MovSoft.Controls.ToggleButton();
            this.kryptonLabelNome = new Krypton.Toolkit.KryptonLabel();
            this.imgFiltro = new System.Windows.Forms.PictureBox();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).BeginInit();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPesquisar
            // 
            this.inputPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputPesquisar.Location = new System.Drawing.Point(198, 243);
            this.inputPesquisar.Name = "inputPesquisar";
            this.inputPesquisar.PlaceholderText = "Pesquisar";
            this.inputPesquisar.Size = new System.Drawing.Size(240, 23);
            this.inputPesquisar.TabIndex = 0;
            this.inputPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputPesquisarGrupos_KeyPress);
            // 
            // dataGridViewGrupos
            // 
            this.dataGridViewGrupos.AllowUserToAddRows = false;
            this.dataGridViewGrupos.AllowUserToDeleteRows = false;
            this.dataGridViewGrupos.AllowUserToResizeColumns = false;
            this.dataGridViewGrupos.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGrupos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewGrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGrupos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewGrupos.EnableHeadersVisualStyles = false;
            this.dataGridViewGrupos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dataGridViewGrupos.Location = new System.Drawing.Point(198, 274);
            this.dataGridViewGrupos.Name = "dataGridViewGrupos";
            this.dataGridViewGrupos.ReadOnly = true;
            this.dataGridViewGrupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewGrupos.RowHeadersVisible = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewGrupos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewGrupos.RowTemplate.Height = 25;
            this.dataGridViewGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrupos.ShowCellErrors = false;
            this.dataGridViewGrupos.ShowCellToolTips = false;
            this.dataGridViewGrupos.ShowEditingIcon = false;
            this.dataGridViewGrupos.ShowRowErrors = false;
            this.dataGridViewGrupos.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewGrupos.TabIndex = 6;
            this.dataGridViewGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupos_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::MovSoft.Properties.Resources.icon_search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnPesquisar.Location = new System.Drawing.Point(444, 243);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(23, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // inputNomeGrupo
            // 
            this.inputNomeGrupo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNomeGrupo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeGrupo.Location = new System.Drawing.Point(12, 34);
            this.inputNomeGrupo.Name = "inputNomeGrupo";
            this.inputNomeGrupo.Size = new System.Drawing.Size(179, 23);
            this.inputNomeGrupo.TabIndex = 7;
            this.inputNomeGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNomeGrupo_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(634, 274);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 34);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(634, 354);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.Location = new System.Drawing.Point(634, 314);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(125, 34);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadastro.Controls.Add(this.kryptonLabel1);
            this.pnlCadastro.Controls.Add(this.toggleButton1);
            this.pnlCadastro.Controls.Add(this.kryptonLabelNome);
            this.pnlCadastro.Controls.Add(this.inputNomeGrupo);
            this.pnlCadastro.Enabled = false;
            this.pnlCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.pnlCadastro.Location = new System.Drawing.Point(198, 36);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(561, 162);
            this.pnlCadastro.TabIndex = 17;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(222, 7);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(57, 21);
            this.kryptonLabel1.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabel1.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.ExtraText = "*";
            this.kryptonLabel1.Values.Text = "Ativo";
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.toggleButton1.Checked = true;
            this.toggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton1.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButton1.Location = new System.Drawing.Point(222, 34);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 23);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 23);
            this.toggleButton1.TabIndex = 10;
            this.toggleButton1.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelNome
            // 
            this.kryptonLabelNome.Location = new System.Drawing.Point(12, 7);
            this.kryptonLabelNome.Name = "kryptonLabelNome";
            this.kryptonLabelNome.Size = new System.Drawing.Size(123, 21);
            this.kryptonLabelNome.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelNome.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNome.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelNome.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNome.TabIndex = 9;
            this.kryptonLabelNome.Values.ExtraText = "*";
            this.kryptonLabelNome.Values.Text = "Nome do grupo";
            // 
            // imgFiltro
            // 
            this.imgFiltro.BackColor = System.Drawing.Color.Transparent;
            this.imgFiltro.BackgroundImage = global::MovSoft.Properties.Resources.icon_filter;
            this.imgFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFiltro.Location = new System.Drawing.Point(501, 243);
            this.imgFiltro.Name = "imgFiltro";
            this.imgFiltro.Size = new System.Drawing.Size(23, 23);
            this.imgFiltro.TabIndex = 19;
            this.imgFiltro.TabStop = false;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Habilitado",
            "Desabilitado"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(530, 243);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(98, 23);
            this.comboBoxFiltro.TabIndex = 2;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.imgFiltro);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dataGridViewGrupos);
            this.Controls.Add(this.inputPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Lista de Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).EndInit();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputPesquisar;
        private DataGridView dataGridViewGrupos;
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
    }
}