namespace MovSoft
{
    partial class CadColaboradorPessoal
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
            this.txtTitulo = new System.Windows.Forms.Label();
            this.inputNascimento = new System.Windows.Forms.MaskedTextBox();
            this.inputboxSexo = new System.Windows.Forms.ComboBox();
            this.inputCpf = new System.Windows.Forms.MaskedTextBox();
            this.inputCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtObr7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObr6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.txtObr5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.Label();
            this.inputSobrenome = new System.Windows.Forms.TextBox();
            this.txtObr4 = new System.Windows.Forms.Label();
            this.txtObr3 = new System.Windows.Forms.Label();
            this.txtObr2 = new System.Windows.Forms.Label();
            this.txtObr1 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.Location = new System.Drawing.Point(182, 10);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(337, 32);
            this.txtTitulo.TabIndex = 118;
            this.txtTitulo.Text = "Cadastrar Colaborador (1/2)";
            // 
            // inputNascimento
            // 
            this.inputNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNascimento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNascimento.Location = new System.Drawing.Point(409, 152);
            this.inputNascimento.Mask = "00/00/0000";
            this.inputNascimento.Name = "inputNascimento";
            this.inputNascimento.PromptChar = ' ';
            this.inputNascimento.Size = new System.Drawing.Size(110, 23);
            this.inputNascimento.TabIndex = 110;
            this.inputNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // inputboxSexo
            // 
            this.inputboxSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputboxSexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputboxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputboxSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputboxSexo.FormattingEnabled = true;
            this.inputboxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.inputboxSexo.Location = new System.Drawing.Point(177, 152);
            this.inputboxSexo.Name = "inputboxSexo";
            this.inputboxSexo.Size = new System.Drawing.Size(92, 23);
            this.inputboxSexo.TabIndex = 102;
            // 
            // inputCpf
            // 
            this.inputCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCpf.Location = new System.Drawing.Point(288, 152);
            this.inputCpf.Mask = "000,000,000-00";
            this.inputCpf.Name = "inputCpf";
            this.inputCpf.PromptChar = ' ';
            this.inputCpf.Size = new System.Drawing.Size(99, 23);
            this.inputCpf.TabIndex = 105;
            this.inputCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputCelular
            // 
            this.inputCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCelular.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCelular.Location = new System.Drawing.Point(409, 210);
            this.inputCelular.Mask = "(00) 00000-0000";
            this.inputCelular.Name = "inputCelular";
            this.inputCelular.PromptChar = ' ';
            this.inputCelular.Size = new System.Drawing.Size(110, 23);
            this.inputCelular.TabIndex = 113;
            this.inputCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCelular_KeyPress);
            // 
            // txtObr7
            // 
            this.txtObr7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr7.AutoSize = true;
            this.txtObr7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr7.Location = new System.Drawing.Point(457, 192);
            this.txtObr7.Name = "txtObr7";
            this.txtObr7.Size = new System.Drawing.Size(12, 15);
            this.txtObr7.TabIndex = 117;
            this.txtObr7.Text = "*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(409, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Celular";
            // 
            // txtObr6
            // 
            this.txtObr6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr6.AutoSize = true;
            this.txtObr6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr6.Location = new System.Drawing.Point(221, 192);
            this.txtObr6.Name = "txtObr6";
            this.txtObr6.Size = new System.Drawing.Size(12, 15);
            this.txtObr6.TabIndex = 114;
            this.txtObr6.Text = "*";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(177, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(47, 17);
            this.txtEmail.TabIndex = 112;
            this.txtEmail.Text = "E-mail";
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputEmail.Location = new System.Drawing.Point(177, 210);
            this.inputEmail.MaxLength = 255;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(154, 23);
            this.inputEmail.TabIndex = 111;
            // 
            // txtObr5
            // 
            this.txtObr5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr5.AutoSize = true;
            this.txtObr5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr5.Location = new System.Drawing.Point(319, 134);
            this.txtObr5.Name = "txtObr5";
            this.txtObr5.Size = new System.Drawing.Size(12, 15);
            this.txtObr5.TabIndex = 109;
            this.txtObr5.Text = "*";
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCpf.AutoSize = true;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCpf.Location = new System.Drawing.Point(288, 132);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(31, 17);
            this.txtCpf.TabIndex = 108;
            this.txtCpf.Text = "CPF";
            // 
            // inputSobrenome
            // 
            this.inputSobrenome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputSobrenome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputSobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputSobrenome.Location = new System.Drawing.Point(365, 91);
            this.inputSobrenome.MaxLength = 255;
            this.inputSobrenome.Name = "inputSobrenome";
            this.inputSobrenome.Size = new System.Drawing.Size(154, 23);
            this.inputSobrenome.TabIndex = 101;
            // 
            // txtObr4
            // 
            this.txtObr4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr4.AutoSize = true;
            this.txtObr4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr4.Location = new System.Drawing.Point(212, 136);
            this.txtObr4.Name = "txtObr4";
            this.txtObr4.Size = new System.Drawing.Size(12, 15);
            this.txtObr4.TabIndex = 107;
            this.txtObr4.Text = "*";
            // 
            // txtObr3
            // 
            this.txtObr3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr3.AutoSize = true;
            this.txtObr3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr3.Location = new System.Drawing.Point(546, 136);
            this.txtObr3.Name = "txtObr3";
            this.txtObr3.Size = new System.Drawing.Size(12, 15);
            this.txtObr3.TabIndex = 104;
            this.txtObr3.Text = "*";
            // 
            // txtObr2
            // 
            this.txtObr2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr2.AutoSize = true;
            this.txtObr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr2.Location = new System.Drawing.Point(442, 73);
            this.txtObr2.Name = "txtObr2";
            this.txtObr2.Size = new System.Drawing.Size(12, 15);
            this.txtObr2.TabIndex = 100;
            this.txtObr2.Text = "*";
            // 
            // txtObr1
            // 
            this.txtObr1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr1.AutoSize = true;
            this.txtObr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr1.Location = new System.Drawing.Point(319, 73);
            this.txtObr1.Name = "txtObr1";
            this.txtObr1.Size = new System.Drawing.Size(12, 15);
            this.txtObr1.TabIndex = 98;
            this.txtObr1.Text = "*";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmarSenha.AutoSize = true;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(177, 134);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(37, 17);
            this.txtConfirmarSenha.TabIndex = 106;
            this.txtConfirmarSenha.Text = "Sexo";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNascimento.AutoSize = true;
            this.txtNascimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNascimento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNascimento.Location = new System.Drawing.Point(409, 132);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(131, 17);
            this.txtNascimento.TabIndex = 103;
            this.txtNascimento.Text = "Data de nascimento";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSobrenome.AutoSize = true;
            this.txtSobrenome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSobrenome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSobrenome.Location = new System.Drawing.Point(365, 71);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(78, 17);
            this.txtSobrenome.TabIndex = 99;
            this.txtSobrenome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.Location = new System.Drawing.Point(177, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(136, 17);
            this.txtNome.TabIndex = 97;
            this.txtNome.Text = "Nome / Nome Social";
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
            this.btnProximo.Location = new System.Drawing.Point(293, 265);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(115, 35);
            this.btnProximo.TabIndex = 115;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // inputNome
            // 
            this.inputNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNome.Location = new System.Drawing.Point(177, 91);
            this.inputNome.MaxLength = 100;
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(154, 23);
            this.inputNome.TabIndex = 96;
            // 
            // CadColaboradorPessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(734, 311);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.inputNascimento);
            this.Controls.Add(this.inputboxSexo);
            this.Controls.Add(this.inputCpf);
            this.Controls.Add(this.inputCelular);
            this.Controls.Add(this.txtObr7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObr6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.txtObr5);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.inputSobrenome);
            this.Controls.Add(this.txtObr4);
            this.Controls.Add(this.txtObr3);
            this.Controls.Add(this.txtObr2);
            this.Controls.Add(this.txtObr1);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.inputNome);
            this.Name = "CadColaboradorPessoal";
            this.Text = "Cadastro de Colaborador";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtTitulo;
        private MaskedTextBox inputNascimento;
        private ComboBox inputboxSexo;
        private MaskedTextBox inputCpf;
        private MaskedTextBox inputCelular;
        private Label txtObr7;
        private Label label3;
        private Label txtObr6;
        private Label txtEmail;
        private TextBox inputEmail;
        private Label txtObr5;
        private Label txtCpf;
        private TextBox inputSobrenome;
        private Label txtObr4;
        private Label txtObr3;
        private Label txtObr2;
        private Label txtObr1;
        private Label txtConfirmarSenha;
        private Label txtNascimento;
        private Label txtSobrenome;
        private Label txtNome;
        private Button btnProximo;
        private TextBox inputNome;
    }
}