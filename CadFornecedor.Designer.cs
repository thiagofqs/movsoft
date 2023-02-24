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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.inputCep = new System.Windows.Forms.MaskedTextBox();
            this.inputCpf = new System.Windows.Forms.MaskedTextBox();
            this.inputNumero = new System.Windows.Forms.TextBox();
            this.txtObr5 = new System.Windows.Forms.Label();
            this.txtObr2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.Label();
            this.inputComplemento = new System.Windows.Forms.TextBox();
            this.txtObr1 = new System.Windows.Forms.Label();
            this.inputboxUf = new System.Windows.Forms.ComboBox();
            this.txtRazao = new System.Windows.Forms.Label();
            this.txtObr8 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtComplemento = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtObr7 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.Label();
            this.inputCidade = new System.Windows.Forms.TextBox();
            this.txtObr3 = new System.Windows.Forms.Label();
            this.inputBairro = new System.Windows.Forms.TextBox();
            this.txtObr4 = new System.Windows.Forms.Label();
            this.txtObr6 = new System.Windows.Forms.Label();
            this.inputLogradouro = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.pnlMain.Controls.Add(this.inputCep);
            this.pnlMain.Controls.Add(this.inputCpf);
            this.pnlMain.Controls.Add(this.inputNumero);
            this.pnlMain.Controls.Add(this.txtObr5);
            this.pnlMain.Controls.Add(this.txtObr2);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.txtCnpj);
            this.pnlMain.Controls.Add(this.inputComplemento);
            this.pnlMain.Controls.Add(this.txtObr1);
            this.pnlMain.Controls.Add(this.inputboxUf);
            this.pnlMain.Controls.Add(this.txtRazao);
            this.pnlMain.Controls.Add(this.txtObr8);
            this.pnlMain.Controls.Add(this.btnProximo);
            this.pnlMain.Controls.Add(this.txtComplemento);
            this.pnlMain.Controls.Add(this.inputNome);
            this.pnlMain.Controls.Add(this.txtUf);
            this.pnlMain.Controls.Add(this.txtTitulo);
            this.pnlMain.Controls.Add(this.txtObr7);
            this.pnlMain.Controls.Add(this.txtCep);
            this.pnlMain.Controls.Add(this.txtCidade);
            this.pnlMain.Controls.Add(this.txtLogradouro);
            this.pnlMain.Controls.Add(this.inputCidade);
            this.pnlMain.Controls.Add(this.txtObr3);
            this.pnlMain.Controls.Add(this.inputBairro);
            this.pnlMain.Controls.Add(this.txtObr4);
            this.pnlMain.Controls.Add(this.txtObr6);
            this.pnlMain.Controls.Add(this.inputLogradouro);
            this.pnlMain.Controls.Add(this.txtBairro);
            this.pnlMain.Location = new System.Drawing.Point(90, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(734, 311);
            this.pnlMain.TabIndex = 0;
            // 
            // inputCep
            // 
            this.inputCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCep.Location = new System.Drawing.Point(86, 148);
            this.inputCep.Mask = "00000-000";
            this.inputCep.Name = "inputCep";
            this.inputCep.PromptChar = ' ';
            this.inputCep.Size = new System.Drawing.Size(100, 23);
            this.inputCep.TabIndex = 2;
            this.inputCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputCep.DragLeave += new System.EventHandler(this.inputCep_Leave);
            // 
            // inputCpf
            // 
            this.inputCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCpf.Location = new System.Drawing.Point(380, 89);
            this.inputCpf.Mask = "00,000,000/0000-00";
            this.inputCpf.Name = "inputCpf";
            this.inputCpf.PromptChar = ' ';
            this.inputCpf.Size = new System.Drawing.Size(110, 23);
            this.inputCpf.TabIndex = 1;
            this.inputCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputNumero
            // 
            this.inputNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNumero.Location = new System.Drawing.Point(380, 148);
            this.inputNumero.MaxLength = 5;
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Size = new System.Drawing.Size(76, 23);
            this.inputNumero.TabIndex = 4;
            // 
            // txtObr5
            // 
            this.txtObr5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr5.AutoSize = true;
            this.txtObr5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr5.Location = new System.Drawing.Point(444, 130);
            this.txtObr5.Name = "txtObr5";
            this.txtObr5.Size = new System.Drawing.Size(12, 15);
            this.txtObr5.TabIndex = 4;
            this.txtObr5.Text = "*";
            // 
            // txtObr2
            // 
            this.txtObr2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr2.AutoSize = true;
            this.txtObr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr2.Location = new System.Drawing.Point(425, 71);
            this.txtObr2.Name = "txtObr2";
            this.txtObr2.Size = new System.Drawing.Size(12, 15);
            this.txtObr2.TabIndex = 1;
            this.txtObr2.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(380, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCnpj.AutoSize = true;
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCnpj.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCnpj.Location = new System.Drawing.Point(380, 69);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(39, 17);
            this.txtCnpj.TabIndex = 1;
            this.txtCnpj.Text = "CNPJ";
            // 
            // inputComplemento
            // 
            this.inputComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputComplemento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputComplemento.Location = new System.Drawing.Point(480, 148);
            this.inputComplemento.MaxLength = 200;
            this.inputComplemento.Name = "inputComplemento";
            this.inputComplemento.Size = new System.Drawing.Size(154, 23);
            this.inputComplemento.TabIndex = 5;
            // 
            // txtObr1
            // 
            this.txtObr1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr1.AutoSize = true;
            this.txtObr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr1.Location = new System.Drawing.Point(297, 71);
            this.txtObr1.Name = "txtObr1";
            this.txtObr1.Size = new System.Drawing.Size(12, 15);
            this.txtObr1.TabIndex = 0;
            this.txtObr1.Text = "*";
            // 
            // inputboxUf
            // 
            this.inputboxUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputboxUf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputboxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputboxUf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputboxUf.FormattingEnabled = true;
            this.inputboxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.inputboxUf.Location = new System.Drawing.Point(480, 207);
            this.inputboxUf.Name = "inputboxUf";
            this.inputboxUf.Size = new System.Drawing.Size(77, 23);
            this.inputboxUf.TabIndex = 8;
            this.inputboxUf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCelular_KeyPress);
            // 
            // txtRazao
            // 
            this.txtRazao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRazao.AutoSize = true;
            this.txtRazao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRazao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtRazao.Location = new System.Drawing.Point(208, 69);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(83, 17);
            this.txtRazao.TabIndex = 0;
            this.txtRazao.Text = "Razão social";
            // 
            // txtObr8
            // 
            this.txtObr8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr8.AutoSize = true;
            this.txtObr8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr8.Location = new System.Drawing.Point(509, 189);
            this.txtObr8.Name = "txtObr8";
            this.txtObr8.Size = new System.Drawing.Size(12, 15);
            this.txtObr8.TabIndex = 8;
            this.txtObr8.Text = "*";
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnProximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProximo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProximo.Location = new System.Drawing.Point(309, 262);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(115, 35);
            this.btnProximo.TabIndex = 9;
            this.btnProximo.Text = "Cadastrar";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplemento.AutoSize = true;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtComplemento.Location = new System.Drawing.Point(480, 128);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(95, 17);
            this.txtComplemento.TabIndex = 5;
            this.txtComplemento.Text = "Complemento";
            // 
            // inputNome
            // 
            this.inputNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNome.Location = new System.Drawing.Point(208, 89);
            this.inputNome.MaxLength = 100;
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(154, 23);
            this.inputNome.TabIndex = 0;
            // 
            // txtUf
            // 
            this.txtUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUf.AutoSize = true;
            this.txtUf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUf.Location = new System.Drawing.Point(479, 187);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(24, 17);
            this.txtUf.TabIndex = 8;
            this.txtUf.Text = "UF";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.Location = new System.Drawing.Point(232, 12);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(260, 32);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Cadastrar Fornecedor";
            // 
            // txtObr7
            // 
            this.txtObr7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr7.AutoSize = true;
            this.txtObr7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr7.Location = new System.Drawing.Point(353, 189);
            this.txtObr7.Name = "txtObr7";
            this.txtObr7.Size = new System.Drawing.Size(12, 15);
            this.txtObr7.TabIndex = 7;
            this.txtObr7.Text = "*";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCep.AutoSize = true;
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCep.Location = new System.Drawing.Point(86, 128);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(31, 17);
            this.txtCep.TabIndex = 2;
            this.txtCep.Text = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.AutoSize = true;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCidade.Location = new System.Drawing.Point(302, 187);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(50, 17);
            this.txtCidade.TabIndex = 7;
            this.txtCidade.Text = "Cidade";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogradouro.AutoSize = true;
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogradouro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogradouro.Location = new System.Drawing.Point(208, 128);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(80, 17);
            this.txtLogradouro.TabIndex = 3;
            this.txtLogradouro.Text = "Logradouro";
            // 
            // inputCidade
            // 
            this.inputCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCidade.Location = new System.Drawing.Point(302, 207);
            this.inputCidade.MaxLength = 100;
            this.inputCidade.Name = "inputCidade";
            this.inputCidade.Size = new System.Drawing.Size(154, 23);
            this.inputCidade.TabIndex = 7;
            // 
            // txtObr3
            // 
            this.txtObr3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr3.AutoSize = true;
            this.txtObr3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr3.Location = new System.Drawing.Point(123, 130);
            this.txtObr3.Name = "txtObr3";
            this.txtObr3.Size = new System.Drawing.Size(12, 15);
            this.txtObr3.TabIndex = 2;
            this.txtObr3.Text = "*";
            // 
            // inputBairro
            // 
            this.inputBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBairro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputBairro.Location = new System.Drawing.Point(123, 207);
            this.inputBairro.MaxLength = 100;
            this.inputBairro.Name = "inputBairro";
            this.inputBairro.Size = new System.Drawing.Size(154, 23);
            this.inputBairro.TabIndex = 6;
            // 
            // txtObr4
            // 
            this.txtObr4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr4.AutoSize = true;
            this.txtObr4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr4.Location = new System.Drawing.Point(294, 130);
            this.txtObr4.Name = "txtObr4";
            this.txtObr4.Size = new System.Drawing.Size(12, 15);
            this.txtObr4.TabIndex = 3;
            this.txtObr4.Text = "*";
            // 
            // txtObr6
            // 
            this.txtObr6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr6.AutoSize = true;
            this.txtObr6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr6.Location = new System.Drawing.Point(170, 189);
            this.txtObr6.Name = "txtObr6";
            this.txtObr6.Size = new System.Drawing.Size(12, 15);
            this.txtObr6.TabIndex = 6;
            this.txtObr6.Text = "*";
            // 
            // inputLogradouro
            // 
            this.inputLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputLogradouro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputLogradouro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputLogradouro.Location = new System.Drawing.Point(208, 148);
            this.inputLogradouro.MaxLength = 255;
            this.inputLogradouro.Name = "inputLogradouro";
            this.inputLogradouro.Size = new System.Drawing.Size(154, 23);
            this.inputLogradouro.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.AutoSize = true;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBairro.Location = new System.Drawing.Point(123, 187);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(45, 17);
            this.txtBairro.TabIndex = 6;
            this.txtBairro.Text = "Bairro";
            // 
            // CadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(914, 434);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Name = "CadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Cadastrar Fornecedor";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlMain;
        private Label txtTitulo;
        private MaskedTextBox inputCpf;
        private Label txtObr2;
        private Label txtCnpj;
        private Label txtObr1;
        private Label txtRazao;
        private Button btnProximo;
        private TextBox inputNome;
        private MaskedTextBox inputCep;
        private TextBox inputNumero;
        private Label txtObr5;
        private Label label4;
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
    }
}