namespace MovSoft.Forms.Grupo
{
    partial class Insumos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewInsumos = new System.Windows.Forms.DataGridView();
            this.inputPesquisarInsumos = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imgFiltroInsumos = new System.Windows.Forms.PictureBox();
            this.btnPesquisarInsumos = new System.Windows.Forms.Button();
            this.txtUnidadeMedida = new System.Windows.Forms.Label();
            this.txtObg3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toggleButtonAtivo = new MovSoft.Controls.ToggleButton();
            this.inputNomeComponente = new System.Windows.Forms.TextBox();
            this.txtNomeComponente = new System.Windows.Forms.Label();
            this.txtObr1 = new System.Windows.Forms.Label();
            this.txtAtivo = new System.Windows.Forms.Label();
            this.tabPageComponentes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtObg1 = new System.Windows.Forms.Label();
            this.txtNomeComponentes = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtObg1Insumos = new System.Windows.Forms.Label();
            this.txtNomeInsumos = new System.Windows.Forms.Label();
            this.inputNomeInsumos = new System.Windows.Forms.TextBox();
            this.txtQuantidadeInsumos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObg2Insumos = new System.Windows.Forms.Label();
            this.toggleButton1 = new MovSoft.Controls.ToggleButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnCadastrarInsumos = new System.Windows.Forms.Button();
            this.txtObg2 = new System.Windows.Forms.Label();
            this.txtQuanidadeComponentes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEditarInsumos = new System.Windows.Forms.Button();
            this.btnCancelarInsumos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsumos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltroInsumos)).BeginInit();
            this.tabPageComponentes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInsumos
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewInsumos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInsumos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewInsumos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewInsumos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewInsumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInsumos.Location = new System.Drawing.Point(198, 274);
            this.dataGridViewInsumos.Name = "dataGridViewInsumos";
            this.dataGridViewInsumos.RowTemplate.Height = 25;
            this.dataGridViewInsumos.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewInsumos.TabIndex = 0;
            // 
            // inputPesquisarInsumos
            // 
            this.inputPesquisarInsumos.Location = new System.Drawing.Point(198, 243);
            this.inputPesquisarInsumos.Name = "inputPesquisarInsumos";
            this.inputPesquisarInsumos.PlaceholderText = "Pesquisar";
            this.inputPesquisarInsumos.Size = new System.Drawing.Size(240, 23);
            this.inputPesquisarInsumos.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(530, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // imgFiltroInsumos
            // 
            this.imgFiltroInsumos.BackColor = System.Drawing.Color.Transparent;
            this.imgFiltroInsumos.BackgroundImage = global::MovSoft.Properties.Resources.icon_filter;
            this.imgFiltroInsumos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgFiltroInsumos.Location = new System.Drawing.Point(501, 243);
            this.imgFiltroInsumos.Name = "imgFiltroInsumos";
            this.imgFiltroInsumos.Size = new System.Drawing.Size(23, 23);
            this.imgFiltroInsumos.TabIndex = 21;
            this.imgFiltroInsumos.TabStop = false;
            this.imgFiltroInsumos.Click += new System.EventHandler(this.imgFiltroInsumos_Click);
            // 
            // btnPesquisarInsumos
            // 
            this.btnPesquisarInsumos.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarInsumos.BackgroundImage = global::MovSoft.Properties.Resources.icon_search;
            this.btnPesquisarInsumos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarInsumos.FlatAppearance.BorderSize = 0;
            this.btnPesquisarInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarInsumos.Location = new System.Drawing.Point(444, 243);
            this.btnPesquisarInsumos.Name = "btnPesquisarInsumos";
            this.btnPesquisarInsumos.Size = new System.Drawing.Size(23, 23);
            this.btnPesquisarInsumos.TabIndex = 20;
            this.btnPesquisarInsumos.UseVisualStyleBackColor = false;
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.AutoSize = true;
            this.txtUnidadeMedida.BackColor = System.Drawing.Color.Transparent;
            this.txtUnidadeMedida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUnidadeMedida.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUnidadeMedida.Location = new System.Drawing.Point(294, 74);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(109, 17);
            this.txtUnidadeMedida.TabIndex = 8;
            this.txtUnidadeMedida.Text = "Unidade Medida";
            // 
            // txtObg3
            // 
            this.txtObg3.AutoSize = true;
            this.txtObg3.BackColor = System.Drawing.Color.Transparent;
            this.txtObg3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg3.Location = new System.Drawing.Point(409, 74);
            this.txtObg3.Name = "txtObg3";
            this.txtObg3.Size = new System.Drawing.Size(12, 15);
            this.txtObg3.TabIndex = 9;
            this.txtObg3.Text = "*";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(294, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(127, 23);
            this.comboBox2.TabIndex = 6;
            // 
            // toggleButtonAtivo
            // 
            this.toggleButtonAtivo.AutoSize = true;
            this.toggleButtonAtivo.Checked = true;
            this.toggleButtonAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonAtivo.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButtonAtivo.Location = new System.Drawing.Point(462, 97);
            this.toggleButtonAtivo.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonAtivo.Name = "toggleButtonAtivo";
            this.toggleButtonAtivo.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonAtivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonAtivo.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButtonAtivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonAtivo.Size = new System.Drawing.Size(45, 22);
            this.toggleButtonAtivo.TabIndex = 2;
            this.toggleButtonAtivo.UseVisualStyleBackColor = true;
            // 
            // inputNomeComponente
            // 
            this.inputNomeComponente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeComponente.Location = new System.Drawing.Point(45, 38);
            this.inputNomeComponente.Name = "inputNomeComponente";
            this.inputNomeComponente.Size = new System.Drawing.Size(179, 23);
            this.inputNomeComponente.TabIndex = 0;
            // 
            // txtNomeComponente
            // 
            this.txtNomeComponente.AutoSize = true;
            this.txtNomeComponente.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeComponente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeComponente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeComponente.Location = new System.Drawing.Point(220, 316);
            this.txtNomeComponente.Name = "txtNomeComponente";
            this.txtNomeComponente.Size = new System.Drawing.Size(134, 17);
            this.txtNomeComponente.TabIndex = 0;
            this.txtNomeComponente.Text = "Nome Componentes";
            // 
            // txtObr1
            // 
            this.txtObr1.AutoSize = true;
            this.txtObr1.BackColor = System.Drawing.Color.Transparent;
            this.txtObr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr1.Location = new System.Drawing.Point(356, 316);
            this.txtObr1.Name = "txtObr1";
            this.txtObr1.Size = new System.Drawing.Size(12, 15);
            this.txtObr1.TabIndex = 0;
            this.txtObr1.Text = "*";
            // 
            // txtAtivo
            // 
            this.txtAtivo.AutoSize = true;
            this.txtAtivo.BackColor = System.Drawing.Color.Transparent;
            this.txtAtivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAtivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAtivo.Location = new System.Drawing.Point(462, 77);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.Size = new System.Drawing.Size(41, 17);
            this.txtAtivo.TabIndex = 1;
            this.txtAtivo.Text = "Ativo";
            this.txtAtivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabPageComponentes
            // 
            this.tabPageComponentes.Controls.Add(this.tabPage1);
            this.tabPageComponentes.Controls.Add(this.tabPage2);
            this.tabPageComponentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPageComponentes.Enabled = false;
            this.tabPageComponentes.Location = new System.Drawing.Point(198, 38);
            this.tabPageComponentes.Name = "tabPageComponentes";
            this.tabPageComponentes.SelectedIndex = 0;
            this.tabPageComponentes.Size = new System.Drawing.Size(561, 194);
            this.tabPageComponentes.TabIndex = 12;
            this.tabPageComponentes.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.txtObg1);
            this.tabPage1.Controls.Add(this.txtNomeComponentes);
            this.tabPage1.Controls.Add(this.inputNomeComponente);
            this.tabPage1.Controls.Add(this.txtUnidadeMedida);
            this.tabPage1.Controls.Add(this.txtAtivo);
            this.tabPage1.Controls.Add(this.txtObg3);
            this.tabPage1.Controls.Add(this.toggleButtonAtivo);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.txtObg2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.txtQuanidadeComponentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Componentes";
            // 
            // txtObg1
            // 
            this.txtObg1.AutoSize = true;
            this.txtObg1.BackColor = System.Drawing.Color.Transparent;
            this.txtObg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg1.Location = new System.Drawing.Point(157, 20);
            this.txtObg1.Name = "txtObg1";
            this.txtObg1.Size = new System.Drawing.Size(12, 15);
            this.txtObg1.TabIndex = 11;
            this.txtObg1.Text = "*";
            // 
            // txtNomeComponentes
            // 
            this.txtNomeComponentes.AutoSize = true;
            this.txtNomeComponentes.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeComponentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeComponentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeComponentes.Location = new System.Drawing.Point(45, 18);
            this.txtNomeComponentes.Name = "txtNomeComponentes";
            this.txtNomeComponentes.Size = new System.Drawing.Size(45, 17);
            this.txtNomeComponentes.TabIndex = 10;
            this.txtNomeComponentes.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.txtObg1Insumos);
            this.tabPage2.Controls.Add(this.txtNomeInsumos);
            this.tabPage2.Controls.Add(this.inputNomeInsumos);
            this.tabPage2.Controls.Add(this.txtQuantidadeInsumos);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtObg2Insumos);
            this.tabPage2.Controls.Add(this.toggleButton1);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insumos";
            // 
            // txtObg1Insumos
            // 
            this.txtObg1Insumos.AutoSize = true;
            this.txtObg1Insumos.BackColor = System.Drawing.Color.Transparent;
            this.txtObg1Insumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg1Insumos.Location = new System.Drawing.Point(157, 20);
            this.txtObg1Insumos.Name = "txtObg1Insumos";
            this.txtObg1Insumos.Size = new System.Drawing.Size(12, 15);
            this.txtObg1Insumos.TabIndex = 22;
            this.txtObg1Insumos.Text = "*";
            // 
            // txtNomeInsumos
            // 
            this.txtNomeInsumos.AutoSize = true;
            this.txtNomeInsumos.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeInsumos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeInsumos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeInsumos.Location = new System.Drawing.Point(45, 18);
            this.txtNomeInsumos.Name = "txtNomeInsumos";
            this.txtNomeInsumos.Size = new System.Drawing.Size(45, 17);
            this.txtNomeInsumos.TabIndex = 21;
            this.txtNomeInsumos.Text = "Nome";
            // 
            // inputNomeInsumos
            // 
            this.inputNomeInsumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeInsumos.Location = new System.Drawing.Point(45, 38);
            this.inputNomeInsumos.Name = "inputNomeInsumos";
            this.inputNomeInsumos.Size = new System.Drawing.Size(179, 23);
            this.inputNomeInsumos.TabIndex = 12;
            // 
            // txtQuantidadeInsumos
            // 
            this.txtQuantidadeInsumos.AutoSize = true;
            this.txtQuantidadeInsumos.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantidadeInsumos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidadeInsumos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuantidadeInsumos.Location = new System.Drawing.Point(45, 74);
            this.txtQuantidadeInsumos.Name = "txtQuantidadeInsumos";
            this.txtQuantidadeInsumos.Size = new System.Drawing.Size(80, 17);
            this.txtQuantidadeInsumos.TabIndex = 19;
            this.txtQuantidadeInsumos.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(213, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ativo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtObg2Insumos
            // 
            this.txtObg2Insumos.AutoSize = true;
            this.txtObg2Insumos.BackColor = System.Drawing.Color.Transparent;
            this.txtObg2Insumos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg2Insumos.Location = new System.Drawing.Point(160, 74);
            this.txtObg2Insumos.Name = "txtObg2Insumos";
            this.txtObg2Insumos.Size = new System.Drawing.Size(12, 15);
            this.txtObg2Insumos.TabIndex = 20;
            this.txtObg2Insumos.Text = "*";
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Checked = true;
            this.toggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton1.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButton1.Location = new System.Drawing.Point(213, 97);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 22);
            this.toggleButton1.TabIndex = 14;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(45, 96);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(127, 23);
            this.comboBox3.TabIndex = 18;
            // 
            // btnCadastrarInsumos
            // 
            this.btnCadastrarInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadastrarInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarInsumos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadastrarInsumos.FlatAppearance.BorderSize = 0;
            this.btnCadastrarInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarInsumos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarInsumos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarInsumos.Location = new System.Drawing.Point(634, 274);
            this.btnCadastrarInsumos.Name = "btnCadastrarInsumos";
            this.btnCadastrarInsumos.Size = new System.Drawing.Size(125, 34);
            this.btnCadastrarInsumos.TabIndex = 22;
            this.btnCadastrarInsumos.Text = "Cadastrar";
            this.btnCadastrarInsumos.UseVisualStyleBackColor = false;
            // 
            // txtObg2
            // 
            this.txtObg2.AutoSize = true;
            this.txtObg2.BackColor = System.Drawing.Color.Transparent;
            this.txtObg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg2.Location = new System.Drawing.Point(157, 76);
            this.txtObg2.Name = "txtObg2";
            this.txtObg2.Size = new System.Drawing.Size(12, 15);
            this.txtObg2.TabIndex = 5;
            this.txtObg2.Text = "*";
            // 
            // txtQuanidadeComponentes
            // 
            this.txtQuanidadeComponentes.AutoSize = true;
            this.txtQuanidadeComponentes.BackColor = System.Drawing.Color.Transparent;
            this.txtQuanidadeComponentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuanidadeComponentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuanidadeComponentes.Location = new System.Drawing.Point(45, 74);
            this.txtQuanidadeComponentes.Name = "txtQuanidadeComponentes";
            this.txtQuanidadeComponentes.Size = new System.Drawing.Size(80, 17);
            this.txtQuanidadeComponentes.TabIndex = 4;
            this.txtQuanidadeComponentes.Text = "Quantidade";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox1.Location = new System.Drawing.Point(45, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 3;
            // 
            // btnEditarInsumos
            // 
            this.btnEditarInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnEditarInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarInsumos.Enabled = false;
            this.btnEditarInsumos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnEditarInsumos.FlatAppearance.BorderSize = 0;
            this.btnEditarInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarInsumos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarInsumos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarInsumos.Location = new System.Drawing.Point(634, 314);
            this.btnEditarInsumos.Name = "btnEditarInsumos";
            this.btnEditarInsumos.Size = new System.Drawing.Size(125, 34);
            this.btnEditarInsumos.TabIndex = 23;
            this.btnEditarInsumos.Text = "Editar";
            this.btnEditarInsumos.UseVisualStyleBackColor = false;
            // 
            // btnCancelarInsumos
            // 
            this.btnCancelarInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarInsumos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCancelarInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarInsumos.Enabled = false;
            this.btnCancelarInsumos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCancelarInsumos.FlatAppearance.BorderSize = 0;
            this.btnCancelarInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarInsumos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarInsumos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarInsumos.Location = new System.Drawing.Point(634, 354);
            this.btnCancelarInsumos.Name = "btnCancelarInsumos";
            this.btnCancelarInsumos.Size = new System.Drawing.Size(125, 34);
            this.btnCancelarInsumos.TabIndex = 24;
            this.btnCancelarInsumos.Text = "Cancelar";
            this.btnCancelarInsumos.UseVisualStyleBackColor = false;
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(914, 464);
            this.Controls.Add(this.btnEditarInsumos);
            this.Controls.Add(this.btnCancelarInsumos);
            this.Controls.Add(this.btnCadastrarInsumos);
            this.Controls.Add(this.tabPageComponentes);
            this.Controls.Add(this.imgFiltroInsumos);
            this.Controls.Add(this.btnPesquisarInsumos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.inputPesquisarInsumos);
            this.Controls.Add(this.dataGridViewInsumos);
            this.Controls.Add(this.txtNomeComponente);
            this.Controls.Add(this.txtObr1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insumos";
            this.Text = "MovSoft - Lista de Insulmos";
            this.Load += new System.EventHandler(this.Insumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInsumos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltroInsumos)).EndInit();
            this.tabPageComponentes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewInsumos;
        private TextBox inputPesquisarInsumos;
        private ComboBox comboBox1;
        private PictureBox imgFiltroInsumos;
        private Button btnPesquisarInsumos;
        private TextBox inputNomeComponente;
        private Label txtNomeComponente;
        private Label txtObr1;
        private Label txtAtivo;
        private Controls.ToggleButton toggleButtonAtivo;
        private Label txtUnidadeMedida;
        private Label txtObg3;
        private ComboBox comboBox2;
        private TabControl tabPageComponentes;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label txtObg1;
        private Label txtNomeComponentes;
        private Button btnCadastrarInsumos;
        private Label txtObg1Insumos;
        private Label txtNomeInsumos;
        private TextBox inputNomeInsumos;
        private Label txtQuantidadeInsumos;
        private Label label4;
        private Label txtObg2Insumos;
        private Controls.ToggleButton toggleButton1;
        private ComboBox comboBox3;
        private Label txtObg2;
        private TextBox textBox1;
        private Label txtQuanidadeComponentes;
        private Button btnEditarInsumos;
        private Button btnCancelarInsumos;
    }
}