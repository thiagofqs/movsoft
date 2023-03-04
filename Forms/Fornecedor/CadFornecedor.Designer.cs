namespace MovSoft
{
    partial class CadFornecedor
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
            pnlMain = new Panel();
            btnPesquisarCep = new Button();
            label1 = new Label();
            txtObr0 = new Label();
            txtAtivo = new Label();
            txtNomeFantasia = new Label();
            toggleButton = new Controls.ToggleButton();
            inputNomeFantasia = new TextBox();
            inputCep = new MaskedTextBox();
            inputCnpj = new MaskedTextBox();
            inputNumero = new TextBox();
            txtObr5 = new Label();
            txtObr2 = new Label();
            txtNumero = new Label();
            txtCnpj = new Label();
            inputComplemento = new TextBox();
            txtObr1 = new Label();
            inputboxUf = new ComboBox();
            txtRazao = new Label();
            txtObr8 = new Label();
            btnCadastrar = new Button();
            txtComplemento = new Label();
            inputRazaoSocial = new TextBox();
            txtUf = new Label();
            txtTitulo = new Label();
            txtObr7 = new Label();
            txtCep = new Label();
            txtCidade = new Label();
            txtLogradouro = new Label();
            inputCidade = new TextBox();
            txtObr3 = new Label();
            inputBairro = new TextBox();
            txtObr4 = new Label();
            txtObr6 = new Label();
            inputLogradouro = new TextBox();
            txtBairro = new Label();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.FromArgb(114, 101, 75);
            pnlMain.Controls.Add(btnPesquisarCep);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(txtObr0);
            pnlMain.Controls.Add(txtAtivo);
            pnlMain.Controls.Add(txtNomeFantasia);
            pnlMain.Controls.Add(toggleButton);
            pnlMain.Controls.Add(inputNomeFantasia);
            pnlMain.Controls.Add(inputCep);
            pnlMain.Controls.Add(inputCnpj);
            pnlMain.Controls.Add(inputNumero);
            pnlMain.Controls.Add(txtObr5);
            pnlMain.Controls.Add(txtObr2);
            pnlMain.Controls.Add(txtNumero);
            pnlMain.Controls.Add(txtCnpj);
            pnlMain.Controls.Add(inputComplemento);
            pnlMain.Controls.Add(txtObr1);
            pnlMain.Controls.Add(inputboxUf);
            pnlMain.Controls.Add(txtRazao);
            pnlMain.Controls.Add(txtObr8);
            pnlMain.Controls.Add(btnCadastrar);
            pnlMain.Controls.Add(txtComplemento);
            pnlMain.Controls.Add(inputRazaoSocial);
            pnlMain.Controls.Add(txtUf);
            pnlMain.Controls.Add(txtTitulo);
            pnlMain.Controls.Add(txtObr7);
            pnlMain.Controls.Add(txtCep);
            pnlMain.Controls.Add(txtCidade);
            pnlMain.Controls.Add(txtLogradouro);
            pnlMain.Controls.Add(inputCidade);
            pnlMain.Controls.Add(txtObr3);
            pnlMain.Controls.Add(inputBairro);
            pnlMain.Controls.Add(txtObr4);
            pnlMain.Controls.Add(txtObr6);
            pnlMain.Controls.Add(inputLogradouro);
            pnlMain.Controls.Add(txtBairro);
            pnlMain.Location = new Point(90, 65);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(734, 341);
            pnlMain.TabIndex = 0;
            // 
            // btnPesquisarCep
            // 
            btnPesquisarCep.BackColor = Color.FromArgb(0, 133, 132);
            btnPesquisarCep.BackgroundImage = Properties.Resources.icon_search;
            btnPesquisarCep.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisarCep.Cursor = Cursors.Hand;
            btnPesquisarCep.FlatAppearance.BorderSize = 0;
            btnPesquisarCep.FlatStyle = FlatStyle.Flat;
            btnPesquisarCep.Location = new Point(162, 164);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(23, 21);
            btnPesquisarCep.TabIndex = 4;
            btnPesquisarCep.UseVisualStyleBackColor = false;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(255, 51, 56);
            label1.Location = new Point(612, 204);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 10;
            label1.Text = "*";
            // 
            // txtObr0
            // 
            txtObr0.Anchor = AnchorStyles.None;
            txtObr0.AutoSize = true;
            txtObr0.BackColor = Color.Transparent;
            txtObr0.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr0.Location = new Point(235, 85);
            txtObr0.Name = "txtObr0";
            txtObr0.Size = new Size(12, 15);
            txtObr0.TabIndex = 0;
            txtObr0.Text = "*";
            // 
            // txtAtivo
            // 
            txtAtivo.Anchor = AnchorStyles.None;
            txtAtivo.AutoSize = true;
            txtAtivo.BackColor = Color.Transparent;
            txtAtivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAtivo.ForeColor = Color.WhiteSmoke;
            txtAtivo.Location = new Point(565, 202);
            txtAtivo.Name = "txtAtivo";
            txtAtivo.Size = new Size(41, 17);
            txtAtivo.TabIndex = 10;
            txtAtivo.Text = "Ativo";
            txtAtivo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Anchor = AnchorStyles.None;
            txtNomeFantasia.AutoSize = true;
            txtNomeFantasia.BackColor = Color.Transparent;
            txtNomeFantasia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNomeFantasia.ForeColor = Color.WhiteSmoke;
            txtNomeFantasia.Location = new Point(131, 83);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(98, 17);
            txtNomeFantasia.TabIndex = 0;
            txtNomeFantasia.Text = "Nome fantasia";
            // 
            // toggleButton
            // 
            toggleButton.Anchor = AnchorStyles.None;
            toggleButton.AutoSize = true;
            toggleButton.Checked = true;
            toggleButton.CheckState = CheckState.Checked;
            toggleButton.Cursor = Cursors.Hand;
            toggleButton.FocusToggleColor = Color.Gold;
            toggleButton.Location = new Point(565, 222);
            toggleButton.MinimumSize = new Size(45, 22);
            toggleButton.Name = "toggleButton";
            toggleButton.OffBackColor = Color.Gray;
            toggleButton.OffToggleColor = Color.Gainsboro;
            toggleButton.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButton.OnToggleColor = Color.WhiteSmoke;
            toggleButton.Size = new Size(45, 22);
            toggleButton.TabIndex = 11;
            toggleButton.UseVisualStyleBackColor = true;
            // 
            // inputNomeFantasia
            // 
            inputNomeFantasia.Anchor = AnchorStyles.None;
            inputNomeFantasia.BackColor = Color.WhiteSmoke;
            inputNomeFantasia.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeFantasia.Location = new Point(131, 103);
            inputNomeFantasia.MaxLength = 100;
            inputNomeFantasia.Name = "inputNomeFantasia";
            inputNomeFantasia.Size = new Size(154, 23);
            inputNomeFantasia.TabIndex = 0;
            // 
            // inputCep
            // 
            inputCep.Anchor = AnchorStyles.None;
            inputCep.BackColor = Color.WhiteSmoke;
            inputCep.ForeColor = Color.FromArgb(56, 56, 56);
            inputCep.Location = new Point(86, 163);
            inputCep.Mask = "00000-000";
            inputCep.Name = "inputCep";
            inputCep.PromptChar = ' ';
            inputCep.Size = new Size(100, 23);
            inputCep.TabIndex = 3;
            inputCep.KeyPress += inputCep_KeyPress;
            // 
            // inputCnpj
            // 
            inputCnpj.Anchor = AnchorStyles.None;
            inputCnpj.BackColor = Color.WhiteSmoke;
            inputCnpj.ForeColor = Color.FromArgb(56, 56, 56);
            inputCnpj.Location = new Point(479, 103);
            inputCnpj.Mask = "00,000,000/0000-00";
            inputCnpj.Name = "inputCnpj";
            inputCnpj.PromptChar = ' ';
            inputCnpj.Size = new Size(110, 23);
            inputCnpj.TabIndex = 2;
            inputCnpj.TextAlign = HorizontalAlignment.Center;
            // 
            // inputNumero
            // 
            inputNumero.Anchor = AnchorStyles.None;
            inputNumero.BackColor = Color.WhiteSmoke;
            inputNumero.ForeColor = Color.FromArgb(56, 56, 56);
            inputNumero.Location = new Point(380, 163);
            inputNumero.MaxLength = 5;
            inputNumero.Name = "inputNumero";
            inputNumero.Size = new Size(76, 23);
            inputNumero.TabIndex = 6;
            // 
            // txtObr5
            // 
            txtObr5.Anchor = AnchorStyles.None;
            txtObr5.AutoSize = true;
            txtObr5.BackColor = Color.Transparent;
            txtObr5.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr5.Location = new Point(444, 145);
            txtObr5.Name = "txtObr5";
            txtObr5.Size = new Size(12, 15);
            txtObr5.TabIndex = 5;
            txtObr5.Text = "*";
            // 
            // txtObr2
            // 
            txtObr2.Anchor = AnchorStyles.None;
            txtObr2.AutoSize = true;
            txtObr2.BackColor = Color.Transparent;
            txtObr2.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr2.Location = new Point(524, 85);
            txtObr2.Name = "txtObr2";
            txtObr2.Size = new Size(12, 15);
            txtObr2.TabIndex = 2;
            txtObr2.Text = "*";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.None;
            txtNumero.AutoSize = true;
            txtNumero.BackColor = Color.Transparent;
            txtNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumero.ForeColor = Color.WhiteSmoke;
            txtNumero.Location = new Point(380, 143);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(58, 17);
            txtNumero.TabIndex = 5;
            txtNumero.Text = "Número";
            // 
            // txtCnpj
            // 
            txtCnpj.Anchor = AnchorStyles.None;
            txtCnpj.AutoSize = true;
            txtCnpj.BackColor = Color.Transparent;
            txtCnpj.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCnpj.ForeColor = Color.WhiteSmoke;
            txtCnpj.Location = new Point(479, 83);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(39, 17);
            txtCnpj.TabIndex = 2;
            txtCnpj.Text = "CNPJ";
            // 
            // inputComplemento
            // 
            inputComplemento.Anchor = AnchorStyles.None;
            inputComplemento.BackColor = Color.WhiteSmoke;
            inputComplemento.ForeColor = Color.FromArgb(56, 56, 56);
            inputComplemento.Location = new Point(480, 163);
            inputComplemento.MaxLength = 200;
            inputComplemento.Name = "inputComplemento";
            inputComplemento.Size = new Size(154, 23);
            inputComplemento.TabIndex = 7;
            // 
            // txtObr1
            // 
            txtObr1.Anchor = AnchorStyles.None;
            txtObr1.AutoSize = true;
            txtObr1.BackColor = Color.Transparent;
            txtObr1.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr1.Location = new Point(396, 85);
            txtObr1.Name = "txtObr1";
            txtObr1.Size = new Size(12, 15);
            txtObr1.TabIndex = 1;
            txtObr1.Text = "*";
            // 
            // inputboxUf
            // 
            inputboxUf.Anchor = AnchorStyles.None;
            inputboxUf.BackColor = Color.WhiteSmoke;
            inputboxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            inputboxUf.Enabled = false;
            inputboxUf.ForeColor = Color.FromArgb(56, 56, 56);
            inputboxUf.FormattingEnabled = true;
            inputboxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            inputboxUf.Location = new Point(459, 222);
            inputboxUf.Name = "inputboxUf";
            inputboxUf.Size = new Size(77, 23);
            inputboxUf.TabIndex = 10;
            inputboxUf.KeyPress += inputCelular_KeyPress;
            // 
            // txtRazao
            // 
            txtRazao.Anchor = AnchorStyles.None;
            txtRazao.AutoSize = true;
            txtRazao.BackColor = Color.Transparent;
            txtRazao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtRazao.ForeColor = Color.WhiteSmoke;
            txtRazao.Location = new Point(307, 83);
            txtRazao.Name = "txtRazao";
            txtRazao.Size = new Size(83, 17);
            txtRazao.TabIndex = 1;
            txtRazao.Text = "Razão social";
            // 
            // txtObr8
            // 
            txtObr8.Anchor = AnchorStyles.None;
            txtObr8.AutoSize = true;
            txtObr8.BackColor = Color.Transparent;
            txtObr8.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr8.Location = new Point(488, 204);
            txtObr8.Name = "txtObr8";
            txtObr8.Size = new Size(12, 15);
            txtObr8.TabIndex = 9;
            txtObr8.Text = "*";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = Color.FromArgb(0, 133, 132);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.WhiteSmoke;
            btnCadastrar.Location = new Point(309, 277);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(115, 35);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.None;
            txtComplemento.AutoSize = true;
            txtComplemento.BackColor = Color.Transparent;
            txtComplemento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtComplemento.ForeColor = Color.WhiteSmoke;
            txtComplemento.Location = new Point(480, 143);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(95, 17);
            txtComplemento.TabIndex = 6;
            txtComplemento.Text = "Complemento";
            // 
            // inputRazaoSocial
            // 
            inputRazaoSocial.Anchor = AnchorStyles.None;
            inputRazaoSocial.BackColor = Color.WhiteSmoke;
            inputRazaoSocial.ForeColor = Color.FromArgb(56, 56, 56);
            inputRazaoSocial.Location = new Point(307, 103);
            inputRazaoSocial.MaxLength = 100;
            inputRazaoSocial.Name = "inputRazaoSocial";
            inputRazaoSocial.Size = new Size(154, 23);
            inputRazaoSocial.TabIndex = 1;
            // 
            // txtUf
            // 
            txtUf.Anchor = AnchorStyles.None;
            txtUf.AutoSize = true;
            txtUf.BackColor = Color.Transparent;
            txtUf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUf.ForeColor = Color.WhiteSmoke;
            txtUf.Location = new Point(458, 202);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(24, 17);
            txtUf.TabIndex = 9;
            txtUf.Text = "UF";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.AutoSize = true;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.ForeColor = Color.WhiteSmoke;
            txtTitulo.Location = new Point(232, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(260, 32);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Cadastrar Fornecedor";
            // 
            // txtObr7
            // 
            txtObr7.Anchor = AnchorStyles.None;
            txtObr7.AutoSize = true;
            txtObr7.BackColor = Color.Transparent;
            txtObr7.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr7.Location = new Point(337, 204);
            txtObr7.Name = "txtObr7";
            txtObr7.Size = new Size(12, 15);
            txtObr7.TabIndex = 8;
            txtObr7.Text = "*";
            // 
            // txtCep
            // 
            txtCep.Anchor = AnchorStyles.None;
            txtCep.AutoSize = true;
            txtCep.BackColor = Color.Transparent;
            txtCep.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCep.ForeColor = Color.WhiteSmoke;
            txtCep.Location = new Point(86, 143);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(31, 17);
            txtCep.TabIndex = 3;
            txtCep.Text = "CEP";
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.None;
            txtCidade.AutoSize = true;
            txtCidade.BackColor = Color.Transparent;
            txtCidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCidade.ForeColor = Color.WhiteSmoke;
            txtCidade.Location = new Point(281, 202);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(50, 17);
            txtCidade.TabIndex = 8;
            txtCidade.Text = "Cidade";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.None;
            txtLogradouro.AutoSize = true;
            txtLogradouro.BackColor = Color.Transparent;
            txtLogradouro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogradouro.ForeColor = Color.WhiteSmoke;
            txtLogradouro.Location = new Point(208, 143);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(80, 17);
            txtLogradouro.TabIndex = 4;
            txtLogradouro.Text = "Logradouro";
            // 
            // inputCidade
            // 
            inputCidade.Anchor = AnchorStyles.None;
            inputCidade.BackColor = Color.WhiteSmoke;
            inputCidade.Enabled = false;
            inputCidade.ForeColor = Color.FromArgb(56, 56, 56);
            inputCidade.Location = new Point(281, 222);
            inputCidade.MaxLength = 100;
            inputCidade.Name = "inputCidade";
            inputCidade.ReadOnly = true;
            inputCidade.Size = new Size(154, 23);
            inputCidade.TabIndex = 9;
            // 
            // txtObr3
            // 
            txtObr3.Anchor = AnchorStyles.None;
            txtObr3.AutoSize = true;
            txtObr3.BackColor = Color.Transparent;
            txtObr3.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr3.Location = new Point(123, 145);
            txtObr3.Name = "txtObr3";
            txtObr3.Size = new Size(12, 15);
            txtObr3.TabIndex = 3;
            txtObr3.Text = "*";
            // 
            // inputBairro
            // 
            inputBairro.Anchor = AnchorStyles.None;
            inputBairro.BackColor = Color.WhiteSmoke;
            inputBairro.Enabled = false;
            inputBairro.ForeColor = Color.FromArgb(56, 56, 56);
            inputBairro.Location = new Point(102, 222);
            inputBairro.MaxLength = 100;
            inputBairro.Name = "inputBairro";
            inputBairro.ReadOnly = true;
            inputBairro.Size = new Size(154, 23);
            inputBairro.TabIndex = 8;
            // 
            // txtObr4
            // 
            txtObr4.Anchor = AnchorStyles.None;
            txtObr4.AutoSize = true;
            txtObr4.BackColor = Color.Transparent;
            txtObr4.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr4.Location = new Point(294, 145);
            txtObr4.Name = "txtObr4";
            txtObr4.Size = new Size(12, 15);
            txtObr4.TabIndex = 4;
            txtObr4.Text = "*";
            // 
            // txtObr6
            // 
            txtObr6.Anchor = AnchorStyles.None;
            txtObr6.AutoSize = true;
            txtObr6.BackColor = Color.Transparent;
            txtObr6.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr6.Location = new Point(153, 204);
            txtObr6.Name = "txtObr6";
            txtObr6.Size = new Size(12, 15);
            txtObr6.TabIndex = 7;
            txtObr6.Text = "*";
            // 
            // inputLogradouro
            // 
            inputLogradouro.Anchor = AnchorStyles.None;
            inputLogradouro.BackColor = Color.WhiteSmoke;
            inputLogradouro.ForeColor = Color.FromArgb(56, 56, 56);
            inputLogradouro.Location = new Point(208, 163);
            inputLogradouro.MaxLength = 255;
            inputLogradouro.Name = "inputLogradouro";
            inputLogradouro.Size = new Size(154, 23);
            inputLogradouro.TabIndex = 5;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.None;
            txtBairro.AutoSize = true;
            txtBairro.BackColor = Color.Transparent;
            txtBairro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBairro.ForeColor = Color.WhiteSmoke;
            txtBairro.Location = new Point(102, 202);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(45, 17);
            txtBairro.TabIndex = 7;
            txtBairro.Text = "Bairro";
            // 
            // CadFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(914, 464);
            Controls.Add(pnlMain);
            ForeColor = Color.FromArgb(56, 56, 56);
            Name = "CadFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Cadastrar Fornecedor";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label txtTitulo;
        private MaskedTextBox inputCnpj;
        private Label txtObr2;
        private Label txtCnpj;
        private Label txtObr1;
        private Label txtRazao;
        private Button btnCadastrar;
        private TextBox inputRazaoSocial;
        private MaskedTextBox inputCep;
        private TextBox inputNumero;
        private Label txtObr5;
        private Label txtNumero;
        private TextBox inputComplemento;
        private ComboBox inputboxUf;
        private Label txtObr8;
        private Label txtComplemento;
        private Label txtUf;
        private Label txtObr7;
        private Label txtCep;
        private Label txtCidade;
        private Label txtLogradouro;
        private TextBox inputCidade;
        private Label txtObr3;
        private TextBox inputBairro;
        private Label txtObr4;
        private Label txtObr6;
        private TextBox inputLogradouro;
        private Label txtBairro;
        private Label txtObr0;
        private Label txtNomeFantasia;
        private TextBox inputNomeFantasia;
        private Label label1;
        private Label txtAtivo;
        private Controls.ToggleButton toggleButton;
        private Button btnPesquisarCep;
    }
}