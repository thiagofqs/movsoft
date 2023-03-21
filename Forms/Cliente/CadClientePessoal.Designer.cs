namespace MovSoft.Forms
{
    partial class CadClientePessoal
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
            this.inputNome = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.inputSobrenome = new System.Windows.Forms.TextBox();
            this.inputboxSexo = new System.Windows.Forms.ComboBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.inputNascimento = new System.Windows.Forms.MaskedTextBox();
            this.inputCpf = new System.Windows.Forms.MaskedTextBox();
            this.inputCelular = new System.Windows.Forms.MaskedTextBox();
            this.kryptonLabelNome = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelSobronome = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelSexo = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCpf = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelNascimento = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelEmail = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCelular = new Krypton.Toolkit.KryptonLabel();
            this.toggleButtonAtivo = new MovSoft.Controls.ToggleButton();
            this.kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // inputNome
            // 
            this.inputNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNome.Location = new System.Drawing.Point(203, 110);
            this.inputNome.MaxLength = 100;
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(154, 23);
            this.inputNome.TabIndex = 0;
            this.inputNome.Tag = "Nome/Nome Social";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.Location = new System.Drawing.Point(246, 36);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(273, 32);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Cadastrar Cliente (1/2)";
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
            this.btnProximo.Location = new System.Drawing.Point(325, 278);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(115, 35);
            this.btnProximo.TabIndex = 8;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // inputSobrenome
            // 
            this.inputSobrenome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputSobrenome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputSobrenome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputSobrenome.Location = new System.Drawing.Point(378, 110);
            this.inputSobrenome.MaxLength = 255;
            this.inputSobrenome.Name = "inputSobrenome";
            this.inputSobrenome.Size = new System.Drawing.Size(175, 23);
            this.inputSobrenome.TabIndex = 1;
            this.inputSobrenome.Tag = "Sobrenome";
            // 
            // inputboxSexo
            // 
            this.inputboxSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputboxSexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputboxSexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputboxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputboxSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputboxSexo.FormattingEnabled = true;
            this.inputboxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.inputboxSexo.Location = new System.Drawing.Point(203, 167);
            this.inputboxSexo.Name = "inputboxSexo";
            this.inputboxSexo.Size = new System.Drawing.Size(92, 23);
            this.inputboxSexo.TabIndex = 2;
            this.inputboxSexo.Tag = "Sexo";
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputEmail.Location = new System.Drawing.Point(203, 228);
            this.inputEmail.MaxLength = 255;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(154, 23);
            this.inputEmail.TabIndex = 5;
            this.inputEmail.Tag = "E-mail";
            // 
            // inputNascimento
            // 
            this.inputNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNascimento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNascimento.Location = new System.Drawing.Point(422, 167);
            this.inputNascimento.Mask = "00/00/0000";
            this.inputNascimento.Name = "inputNascimento";
            this.inputNascimento.PromptChar = ' ';
            this.inputNascimento.Size = new System.Drawing.Size(131, 23);
            this.inputNascimento.TabIndex = 4;
            this.inputNascimento.Tag = "Data de Nascimento";
            this.inputNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // inputCpf
            // 
            this.inputCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCpf.Location = new System.Drawing.Point(309, 167);
            this.inputCpf.Mask = "000,000,000-00";
            this.inputCpf.Name = "inputCpf";
            this.inputCpf.PromptChar = ' ';
            this.inputCpf.Size = new System.Drawing.Size(99, 23);
            this.inputCpf.TabIndex = 3;
            this.inputCpf.Tag = "";
            this.inputCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputCelular
            // 
            this.inputCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCelular.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCelular.Location = new System.Drawing.Point(378, 228);
            this.inputCelular.Mask = "(00) 00000-0000";
            this.inputCelular.Name = "inputCelular";
            this.inputCelular.PromptChar = ' ';
            this.inputCelular.Size = new System.Drawing.Size(106, 23);
            this.inputCelular.TabIndex = 6;
            this.inputCelular.Tag = "Celular";
            this.inputCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCelular_KeyPress);
            // 
            // kryptonLabelNome
            // 
            this.kryptonLabelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelNome.Location = new System.Drawing.Point(203, 83);
            this.kryptonLabelNome.Name = "kryptonLabelNome";
            this.kryptonLabelNome.Size = new System.Drawing.Size(152, 21);
            this.kryptonLabelNome.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelNome.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNome.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelNome.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNome.TabIndex = 0;
            this.kryptonLabelNome.Values.ExtraText = "*";
            this.kryptonLabelNome.Values.Text = "Nome / Nome social";
            // 
            // kryptonLabelSobronome
            // 
            this.kryptonLabelSobronome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelSobronome.Location = new System.Drawing.Point(378, 83);
            this.kryptonLabelSobronome.Name = "kryptonLabelSobronome";
            this.kryptonLabelSobronome.Size = new System.Drawing.Size(95, 21);
            this.kryptonLabelSobronome.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelSobronome.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelSobronome.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelSobronome.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelSobronome.TabIndex = 1;
            this.kryptonLabelSobronome.Values.ExtraText = "*";
            this.kryptonLabelSobronome.Values.Text = "Sobrenome";
            // 
            // kryptonLabelSexo
            // 
            this.kryptonLabelSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelSexo.Location = new System.Drawing.Point(203, 140);
            this.kryptonLabelSexo.Name = "kryptonLabelSexo";
            this.kryptonLabelSexo.Size = new System.Drawing.Size(53, 21);
            this.kryptonLabelSexo.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelSexo.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelSexo.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelSexo.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelSexo.TabIndex = 2;
            this.kryptonLabelSexo.Values.ExtraText = "*";
            this.kryptonLabelSexo.Values.Text = "Sexo";
            // 
            // kryptonLabelCpf
            // 
            this.kryptonLabelCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelCpf.Location = new System.Drawing.Point(309, 140);
            this.kryptonLabelCpf.Name = "kryptonLabelCpf";
            this.kryptonLabelCpf.Size = new System.Drawing.Size(34, 21);
            this.kryptonLabelCpf.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCpf.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCpf.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCpf.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCpf.TabIndex = 3;
            this.kryptonLabelCpf.Values.Text = "CPF";
            // 
            // kryptonLabelNascimento
            // 
            this.kryptonLabelNascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelNascimento.Location = new System.Drawing.Point(422, 140);
            this.kryptonLabelNascimento.Name = "kryptonLabelNascimento";
            this.kryptonLabelNascimento.Size = new System.Drawing.Size(148, 21);
            this.kryptonLabelNascimento.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelNascimento.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNascimento.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelNascimento.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNascimento.TabIndex = 4;
            this.kryptonLabelNascimento.Values.ExtraText = "*";
            this.kryptonLabelNascimento.Values.Text = "Data de nascimento";
            // 
            // kryptonLabelEmail
            // 
            this.kryptonLabelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelEmail.Location = new System.Drawing.Point(203, 201);
            this.kryptonLabelEmail.Name = "kryptonLabelEmail";
            this.kryptonLabelEmail.Size = new System.Drawing.Size(62, 21);
            this.kryptonLabelEmail.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelEmail.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelEmail.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelEmail.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelEmail.TabIndex = 5;
            this.kryptonLabelEmail.Values.ExtraText = "*";
            this.kryptonLabelEmail.Values.Text = "E-mail";
            // 
            // kryptonLabelCelular
            // 
            this.kryptonLabelCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelCelular.Location = new System.Drawing.Point(378, 201);
            this.kryptonLabelCelular.Name = "kryptonLabelCelular";
            this.kryptonLabelCelular.Size = new System.Drawing.Size(67, 21);
            this.kryptonLabelCelular.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCelular.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCelular.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCelular.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCelular.TabIndex = 7;
            this.kryptonLabelCelular.Values.ExtraText = "*";
            this.kryptonLabelCelular.Values.Text = "Celular";
            // 
            // toggleButtonAtivo
            // 
            this.toggleButtonAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toggleButtonAtivo.AutoSize = true;
            this.toggleButtonAtivo.BackColor = System.Drawing.Color.Transparent;
            this.toggleButtonAtivo.Checked = true;
            this.toggleButtonAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonAtivo.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButtonAtivo.Location = new System.Drawing.Point(508, 228);
            this.toggleButtonAtivo.MinimumSize = new System.Drawing.Size(45, 23);
            this.toggleButtonAtivo.Name = "toggleButtonAtivo";
            this.toggleButtonAtivo.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonAtivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonAtivo.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButtonAtivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonAtivo.Size = new System.Drawing.Size(45, 23);
            this.toggleButtonAtivo.TabIndex = 25;
            this.toggleButtonAtivo.UseVisualStyleBackColor = false;
            this.toggleButtonAtivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toggleButton_KeyPress);
            // 
            // kryptonLabelAtivo
            // 
            this.kryptonLabelAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelAtivo.Location = new System.Drawing.Point(508, 201);
            this.kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            this.kryptonLabelAtivo.Size = new System.Drawing.Size(45, 21);
            this.kryptonLabelAtivo.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelAtivo.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelAtivo.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.TabIndex = 8;
            this.kryptonLabelAtivo.Values.Text = "Ativo";
            // 
            // CadClientePessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(734, 341);
            this.Controls.Add(this.kryptonLabelAtivo);
            this.Controls.Add(this.toggleButtonAtivo);
            this.Controls.Add(this.kryptonLabelCelular);
            this.Controls.Add(this.kryptonLabelEmail);
            this.Controls.Add(this.kryptonLabelNascimento);
            this.Controls.Add(this.kryptonLabelCpf);
            this.Controls.Add(this.kryptonLabelSexo);
            this.Controls.Add(this.kryptonLabelSobronome);
            this.Controls.Add(this.kryptonLabelNome);
            this.Controls.Add(this.inputCelular);
            this.Controls.Add(this.inputCpf);
            this.Controls.Add(this.inputNascimento);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.inputboxSexo);
            this.Controls.Add(this.inputSobrenome);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadClientePessoal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Cadastrar Cliente";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputNome;
        private Label txtTitulo;
        private Button btnProximo;
        private TextBox inputSobrenome;
        private ComboBox inputboxSexo;
        private TextBox inputEmail;
        private MaskedTextBox inputNascimento;
        private MaskedTextBox inputCpf;
        private MaskedTextBox inputCelular;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNome;
        private Krypton.Toolkit.KryptonLabel kryptonLabelSobronome;
        private Krypton.Toolkit.KryptonLabel kryptonLabelSexo;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCpf;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNascimento;
        private Krypton.Toolkit.KryptonLabel kryptonLabelEmail;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCelular;
        private Controls.ToggleButton toggleButtonAtivo;
        private Krypton.Toolkit.KryptonLabel kryptonLabelAtivo;
    }
}