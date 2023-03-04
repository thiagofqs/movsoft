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
            txtTitulo = new Label();
            inputNascimento = new MaskedTextBox();
            inputboxSexo = new ComboBox();
            inputCpf = new MaskedTextBox();
            inputCelular = new MaskedTextBox();
            txtObr7 = new Label();
            txtCelular = new Label();
            txtObr6 = new Label();
            txtEmail = new Label();
            inputEmail = new TextBox();
            txtObr4 = new Label();
            txtCpf = new Label();
            inputSobrenome = new TextBox();
            txtObr3 = new Label();
            txtObr5 = new Label();
            txtObr2 = new Label();
            txtObr1 = new Label();
            txtSexo = new Label();
            txtNascimento = new Label();
            txtSobrenome = new Label();
            txtNome = new Label();
            btnProximo = new Button();
            inputNome = new TextBox();
            toggleButton = new Controls.ToggleButton();
            txtAtivo = new Label();
            txtObr8 = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.AutoSize = true;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.ForeColor = Color.WhiteSmoke;
            txtTitulo.Location = new Point(213, 25);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(337, 32);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Cadastrar Colaborador (1/2)";
            // 
            // inputNascimento
            // 
            inputNascimento.Anchor = AnchorStyles.None;
            inputNascimento.BackColor = Color.WhiteSmoke;
            inputNascimento.ForeColor = Color.FromArgb(56, 56, 56);
            inputNascimento.Location = new Point(410, 167);
            inputNascimento.Mask = "00/00/0000";
            inputNascimento.Name = "inputNascimento";
            inputNascimento.PromptChar = ' ';
            inputNascimento.Size = new Size(140, 23);
            inputNascimento.TabIndex = 4;
            inputNascimento.TextAlign = HorizontalAlignment.Center;
            inputNascimento.ValidatingType = typeof(DateTime);
            // 
            // inputboxSexo
            // 
            inputboxSexo.Anchor = AnchorStyles.None;
            inputboxSexo.BackColor = Color.WhiteSmoke;
            inputboxSexo.Cursor = Cursors.Hand;
            inputboxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            inputboxSexo.ForeColor = Color.FromArgb(56, 56, 56);
            inputboxSexo.FormattingEnabled = true;
            inputboxSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            inputboxSexo.Location = new Point(178, 167);
            inputboxSexo.Name = "inputboxSexo";
            inputboxSexo.Size = new Size(92, 23);
            inputboxSexo.TabIndex = 2;
            // 
            // inputCpf
            // 
            inputCpf.Anchor = AnchorStyles.None;
            inputCpf.BackColor = Color.WhiteSmoke;
            inputCpf.ForeColor = Color.FromArgb(56, 56, 56);
            inputCpf.Location = new Point(289, 167);
            inputCpf.Mask = "000,000,000-00";
            inputCpf.Name = "inputCpf";
            inputCpf.PromptChar = ' ';
            inputCpf.Size = new Size(99, 23);
            inputCpf.TabIndex = 3;
            inputCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // inputCelular
            // 
            inputCelular.Anchor = AnchorStyles.None;
            inputCelular.BackColor = Color.WhiteSmoke;
            inputCelular.ForeColor = Color.FromArgb(56, 56, 56);
            inputCelular.Location = new Point(348, 225);
            inputCelular.Mask = "(00) 00000-0000";
            inputCelular.Name = "inputCelular";
            inputCelular.PromptChar = ' ';
            inputCelular.Size = new Size(140, 23);
            inputCelular.TabIndex = 6;
            inputCelular.TextAlign = HorizontalAlignment.Center;
            inputCelular.KeyPress += inputCelular_KeyPress;
            // 
            // txtObr7
            // 
            txtObr7.Anchor = AnchorStyles.None;
            txtObr7.AutoSize = true;
            txtObr7.BackColor = Color.Transparent;
            txtObr7.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr7.Location = new Point(396, 207);
            txtObr7.Name = "txtObr7";
            txtObr7.Size = new Size(12, 15);
            txtObr7.TabIndex = 6;
            txtObr7.Text = "*";
            // 
            // txtCelular
            // 
            txtCelular.Anchor = AnchorStyles.None;
            txtCelular.AutoSize = true;
            txtCelular.BackColor = Color.Transparent;
            txtCelular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCelular.ForeColor = Color.WhiteSmoke;
            txtCelular.Location = new Point(348, 205);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(51, 17);
            txtCelular.TabIndex = 6;
            txtCelular.Text = "Celular";
            // 
            // txtObr6
            // 
            txtObr6.Anchor = AnchorStyles.None;
            txtObr6.AutoSize = true;
            txtObr6.BackColor = Color.Transparent;
            txtObr6.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr6.Location = new Point(222, 207);
            txtObr6.Name = "txtObr6";
            txtObr6.Size = new Size(12, 15);
            txtObr6.TabIndex = 5;
            txtObr6.Text = "*";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.AutoSize = true;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.WhiteSmoke;
            txtEmail.Location = new Point(178, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(47, 17);
            txtEmail.TabIndex = 5;
            txtEmail.Text = "E-mail";
            // 
            // inputEmail
            // 
            inputEmail.Anchor = AnchorStyles.None;
            inputEmail.BackColor = Color.WhiteSmoke;
            inputEmail.ForeColor = Color.FromArgb(56, 56, 56);
            inputEmail.Location = new Point(178, 225);
            inputEmail.MaxLength = 255;
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(154, 23);
            inputEmail.TabIndex = 5;
            // 
            // txtObr4
            // 
            txtObr4.Anchor = AnchorStyles.None;
            txtObr4.AutoSize = true;
            txtObr4.BackColor = Color.Transparent;
            txtObr4.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr4.Location = new Point(320, 149);
            txtObr4.Name = "txtObr4";
            txtObr4.Size = new Size(12, 15);
            txtObr4.TabIndex = 3;
            txtObr4.Text = "*";
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.None;
            txtCpf.AutoSize = true;
            txtCpf.BackColor = Color.Transparent;
            txtCpf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCpf.ForeColor = Color.WhiteSmoke;
            txtCpf.Location = new Point(289, 147);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(31, 17);
            txtCpf.TabIndex = 3;
            txtCpf.Text = "CPF";
            // 
            // inputSobrenome
            // 
            inputSobrenome.Anchor = AnchorStyles.None;
            inputSobrenome.BackColor = Color.WhiteSmoke;
            inputSobrenome.ForeColor = Color.FromArgb(56, 56, 56);
            inputSobrenome.Location = new Point(366, 106);
            inputSobrenome.MaxLength = 255;
            inputSobrenome.Name = "inputSobrenome";
            inputSobrenome.Size = new Size(184, 23);
            inputSobrenome.TabIndex = 1;
            // 
            // txtObr3
            // 
            txtObr3.Anchor = AnchorStyles.None;
            txtObr3.AutoSize = true;
            txtObr3.BackColor = Color.Transparent;
            txtObr3.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr3.Location = new Point(213, 151);
            txtObr3.Name = "txtObr3";
            txtObr3.Size = new Size(12, 15);
            txtObr3.TabIndex = 2;
            txtObr3.Text = "*";
            // 
            // txtObr5
            // 
            txtObr5.Anchor = AnchorStyles.None;
            txtObr5.AutoSize = true;
            txtObr5.BackColor = Color.Transparent;
            txtObr5.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr5.Location = new Point(538, 147);
            txtObr5.Name = "txtObr5";
            txtObr5.Size = new Size(12, 15);
            txtObr5.TabIndex = 4;
            txtObr5.Text = "*";
            // 
            // txtObr2
            // 
            txtObr2.Anchor = AnchorStyles.None;
            txtObr2.AutoSize = true;
            txtObr2.BackColor = Color.Transparent;
            txtObr2.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr2.Location = new Point(443, 88);
            txtObr2.Name = "txtObr2";
            txtObr2.Size = new Size(12, 15);
            txtObr2.TabIndex = 1;
            txtObr2.Text = "*";
            // 
            // txtObr1
            // 
            txtObr1.Anchor = AnchorStyles.None;
            txtObr1.AutoSize = true;
            txtObr1.BackColor = Color.Transparent;
            txtObr1.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr1.Location = new Point(320, 88);
            txtObr1.Name = "txtObr1";
            txtObr1.Size = new Size(12, 15);
            txtObr1.TabIndex = 0;
            txtObr1.Text = "*";
            // 
            // txtSexo
            // 
            txtSexo.Anchor = AnchorStyles.None;
            txtSexo.AutoSize = true;
            txtSexo.BackColor = Color.Transparent;
            txtSexo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSexo.ForeColor = Color.WhiteSmoke;
            txtSexo.Location = new Point(178, 149);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(37, 17);
            txtSexo.TabIndex = 2;
            txtSexo.Text = "Sexo";
            // 
            // txtNascimento
            // 
            txtNascimento.Anchor = AnchorStyles.None;
            txtNascimento.AutoSize = true;
            txtNascimento.BackColor = Color.Transparent;
            txtNascimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNascimento.ForeColor = Color.WhiteSmoke;
            txtNascimento.Location = new Point(410, 147);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(131, 17);
            txtNascimento.TabIndex = 4;
            txtNascimento.Text = "Data de nascimento";
            // 
            // txtSobrenome
            // 
            txtSobrenome.Anchor = AnchorStyles.None;
            txtSobrenome.AutoSize = true;
            txtSobrenome.BackColor = Color.Transparent;
            txtSobrenome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSobrenome.ForeColor = Color.WhiteSmoke;
            txtSobrenome.Location = new Point(366, 86);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(78, 17);
            txtSobrenome.TabIndex = 1;
            txtSobrenome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.AutoSize = true;
            txtNome.BackColor = Color.Transparent;
            txtNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNome.ForeColor = Color.WhiteSmoke;
            txtNome.Location = new Point(178, 86);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(136, 17);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome / Nome Social";
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.None;
            btnProximo.BackColor = Color.FromArgb(0, 133, 132);
            btnProximo.Cursor = Cursors.Hand;
            btnProximo.FlatAppearance.BorderSize = 0;
            btnProximo.FlatStyle = FlatStyle.Flat;
            btnProximo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProximo.ForeColor = Color.WhiteSmoke;
            btnProximo.Location = new Point(320, 275);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(115, 35);
            btnProximo.TabIndex = 8;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // inputNome
            // 
            inputNome.Anchor = AnchorStyles.None;
            inputNome.BackColor = Color.WhiteSmoke;
            inputNome.ForeColor = Color.FromArgb(56, 56, 56);
            inputNome.Location = new Point(178, 106);
            inputNome.MaxLength = 100;
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(154, 23);
            inputNome.TabIndex = 0;
            // 
            // toggleButton
            // 
            toggleButton.Anchor = AnchorStyles.None;
            toggleButton.AutoSize = true;
            toggleButton.Checked = true;
            toggleButton.CheckState = CheckState.Checked;
            toggleButton.Cursor = Cursors.Hand;
            toggleButton.FocusToggleColor = Color.Gold;
            toggleButton.Location = new Point(505, 225);
            toggleButton.MinimumSize = new Size(45, 22);
            toggleButton.Name = "toggleButton";
            toggleButton.OffBackColor = Color.Gray;
            toggleButton.OffToggleColor = Color.Gainsboro;
            toggleButton.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButton.OnToggleColor = Color.WhiteSmoke;
            toggleButton.Size = new Size(45, 22);
            toggleButton.TabIndex = 7;
            toggleButton.UseVisualStyleBackColor = true;
            toggleButton.CheckedChanged += toggleButton_CheckedChanged;
            // 
            // txtAtivo
            // 
            txtAtivo.Anchor = AnchorStyles.None;
            txtAtivo.AutoSize = true;
            txtAtivo.BackColor = Color.Transparent;
            txtAtivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAtivo.ForeColor = Color.WhiteSmoke;
            txtAtivo.Location = new Point(505, 205);
            txtAtivo.Name = "txtAtivo";
            txtAtivo.Size = new Size(41, 17);
            txtAtivo.TabIndex = 0;
            txtAtivo.Text = "Ativo";
            txtAtivo.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtObr8
            // 
            txtObr8.Anchor = AnchorStyles.None;
            txtObr8.AutoSize = true;
            txtObr8.BackColor = Color.Transparent;
            txtObr8.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr8.Location = new Point(552, 207);
            txtObr8.Name = "txtObr8";
            txtObr8.Size = new Size(12, 15);
            txtObr8.TabIndex = 0;
            txtObr8.Text = "*";
            // 
            // CadColaboradorPessoal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 101, 75);
            ClientSize = new Size(734, 341);
            Controls.Add(txtObr8);
            Controls.Add(txtAtivo);
            Controls.Add(toggleButton);
            Controls.Add(txtTitulo);
            Controls.Add(inputNascimento);
            Controls.Add(inputboxSexo);
            Controls.Add(inputCpf);
            Controls.Add(inputCelular);
            Controls.Add(txtObr7);
            Controls.Add(txtCelular);
            Controls.Add(txtObr6);
            Controls.Add(txtEmail);
            Controls.Add(inputEmail);
            Controls.Add(txtObr4);
            Controls.Add(txtCpf);
            Controls.Add(inputSobrenome);
            Controls.Add(txtObr3);
            Controls.Add(txtObr5);
            Controls.Add(txtObr2);
            Controls.Add(txtObr1);
            Controls.Add(txtSexo);
            Controls.Add(txtNascimento);
            Controls.Add(txtSobrenome);
            Controls.Add(txtNome);
            Controls.Add(btnProximo);
            Controls.Add(inputNome);
            ForeColor = Color.FromArgb(56, 56, 56);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadColaboradorPessoal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Colaborador";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTitulo;
        private MaskedTextBox inputNascimento;
        private ComboBox inputboxSexo;
        private MaskedTextBox inputCpf;
        private MaskedTextBox inputCelular;
        private Label txtObr7;
        private Label txtCelular;
        private Label txtObr6;
        private Label txtEmail;
        private TextBox inputEmail;
        private Label txtObr4;
        private Label txtCpf;
        private TextBox inputSobrenome;
        private Label txtObr3;
        private Label txtObr5;
        private Label txtObr2;
        private Label txtObr1;
        private Label txtSexo;
        private Label txtNascimento;
        private Label txtSobrenome;
        private Label txtNome;
        private Button btnProximo;
        private TextBox inputNome;
        private Controls.ToggleButton toggleButton;
        private Label txtAtivo;
        private Label txtObr8;
    }
}