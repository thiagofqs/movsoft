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
            inputNome = new TextBox();
            txtTitulo = new Label();
            btnProximo = new Button();
            inputSobrenome = new TextBox();
            inputboxSexo = new ComboBox();
            inputEmail = new TextBox();
            inputNascimento = new MaskedTextBox();
            inputCpf = new MaskedTextBox();
            inputCelular = new MaskedTextBox();
            kryptonLabelNome = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelSobronome = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelSexo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelCpf = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelNascimento = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelEmail = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelCelular = new Krypton.Toolkit.KryptonLabel();
            toggleButtonAtivo = new Controls.ToggleButton();
            kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // inputNome
            // 
            inputNome.Anchor = AnchorStyles.None;
            inputNome.BackColor = Color.WhiteSmoke;
            inputNome.ForeColor = Color.FromArgb(56, 56, 56);
            inputNome.Location = new Point(232, 147);
            inputNome.Margin = new Padding(3, 4, 3, 4);
            inputNome.MaxLength = 100;
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(175, 27);
            inputNome.TabIndex = 0;
            inputNome.Tag = "Nome/Nome Social";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.AutoSize = true;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.ForeColor = Color.WhiteSmoke;
            txtTitulo.Location = new Point(281, 48);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(337, 41);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Cadastrar Cliente (1/2)";
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
            btnProximo.Location = new Point(371, 371);
            btnProximo.Margin = new Padding(3, 4, 3, 4);
            btnProximo.Name = "btnProximo";
            btnProximo.Size = new Size(131, 47);
            btnProximo.TabIndex = 8;
            btnProximo.Text = "Próximo";
            btnProximo.UseVisualStyleBackColor = false;
            btnProximo.Click += btnProximo_Click;
            // 
            // inputSobrenome
            // 
            inputSobrenome.Anchor = AnchorStyles.None;
            inputSobrenome.BackColor = Color.WhiteSmoke;
            inputSobrenome.ForeColor = Color.FromArgb(56, 56, 56);
            inputSobrenome.Location = new Point(432, 147);
            inputSobrenome.Margin = new Padding(3, 4, 3, 4);
            inputSobrenome.MaxLength = 255;
            inputSobrenome.Name = "inputSobrenome";
            inputSobrenome.Size = new Size(199, 27);
            inputSobrenome.TabIndex = 1;
            inputSobrenome.Tag = "Sobrenome";
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
            inputboxSexo.Location = new Point(232, 223);
            inputboxSexo.Margin = new Padding(3, 4, 3, 4);
            inputboxSexo.Name = "inputboxSexo";
            inputboxSexo.Size = new Size(105, 28);
            inputboxSexo.TabIndex = 2;
            inputboxSexo.Tag = "Sexo";
            // 
            // inputEmail
            // 
            inputEmail.Anchor = AnchorStyles.None;
            inputEmail.BackColor = Color.WhiteSmoke;
            inputEmail.ForeColor = Color.FromArgb(56, 56, 56);
            inputEmail.Location = new Point(232, 304);
            inputEmail.Margin = new Padding(3, 4, 3, 4);
            inputEmail.MaxLength = 255;
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(175, 27);
            inputEmail.TabIndex = 5;
            inputEmail.Tag = "E-mail";
            // 
            // inputNascimento
            // 
            inputNascimento.Anchor = AnchorStyles.None;
            inputNascimento.BackColor = Color.WhiteSmoke;
            inputNascimento.ForeColor = Color.FromArgb(56, 56, 56);
            inputNascimento.Location = new Point(482, 223);
            inputNascimento.Margin = new Padding(3, 4, 3, 4);
            inputNascimento.Mask = "00/00/0000";
            inputNascimento.Name = "inputNascimento";
            inputNascimento.PromptChar = ' ';
            inputNascimento.Size = new Size(149, 27);
            inputNascimento.TabIndex = 4;
            inputNascimento.Tag = "Data de Nascimento";
            inputNascimento.TextAlign = HorizontalAlignment.Center;
            inputNascimento.ValidatingType = typeof(DateTime);
            // 
            // inputCpf
            // 
            inputCpf.Anchor = AnchorStyles.None;
            inputCpf.BackColor = Color.WhiteSmoke;
            inputCpf.ForeColor = Color.FromArgb(56, 56, 56);
            inputCpf.Location = new Point(353, 223);
            inputCpf.Margin = new Padding(3, 4, 3, 4);
            inputCpf.Mask = "000,000,000-00";
            inputCpf.Name = "inputCpf";
            inputCpf.PromptChar = ' ';
            inputCpf.Size = new Size(113, 27);
            inputCpf.TabIndex = 3;
            inputCpf.Tag = "CPF";
            inputCpf.TextAlign = HorizontalAlignment.Center;
            // 
            // inputCelular
            // 
            inputCelular.Anchor = AnchorStyles.None;
            inputCelular.BackColor = Color.WhiteSmoke;
            inputCelular.ForeColor = Color.FromArgb(56, 56, 56);
            inputCelular.Location = new Point(432, 304);
            inputCelular.Margin = new Padding(3, 4, 3, 4);
            inputCelular.Mask = "(00) 00000-0000";
            inputCelular.Name = "inputCelular";
            inputCelular.PromptChar = ' ';
            inputCelular.Size = new Size(121, 27);
            inputCelular.TabIndex = 6;
            inputCelular.Tag = "Celular";
            inputCelular.TextAlign = HorizontalAlignment.Center;
            inputCelular.KeyPress += inputCelular_KeyPress;
            // 
            // kryptonLabelNome
            // 
            kryptonLabelNome.Anchor = AnchorStyles.None;
            kryptonLabelNome.Location = new Point(232, 111);
            kryptonLabelNome.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNome.Name = "kryptonLabelNome";
            kryptonLabelNome.Size = new Size(188, 26);
            kryptonLabelNome.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNome.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNome.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNome.TabIndex = 0;
            kryptonLabelNome.Values.ExtraText = "*";
            kryptonLabelNome.Values.Text = "Nome / Nome social";
            // 
            // kryptonLabelSobronome
            // 
            kryptonLabelSobronome.Anchor = AnchorStyles.None;
            kryptonLabelSobronome.Location = new Point(432, 111);
            kryptonLabelSobronome.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelSobronome.Name = "kryptonLabelSobronome";
            kryptonLabelSobronome.Size = new Size(117, 26);
            kryptonLabelSobronome.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelSobronome.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelSobronome.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelSobronome.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelSobronome.TabIndex = 1;
            kryptonLabelSobronome.Values.ExtraText = "*";
            kryptonLabelSobronome.Values.Text = "Sobrenome";
            // 
            // kryptonLabelSexo
            // 
            kryptonLabelSexo.Anchor = AnchorStyles.None;
            kryptonLabelSexo.Location = new Point(232, 187);
            kryptonLabelSexo.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelSexo.Name = "kryptonLabelSexo";
            kryptonLabelSexo.Size = new Size(65, 26);
            kryptonLabelSexo.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelSexo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelSexo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelSexo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelSexo.TabIndex = 2;
            kryptonLabelSexo.Values.ExtraText = "*";
            kryptonLabelSexo.Values.Text = "Sexo";
            // 
            // kryptonLabelCpf
            // 
            kryptonLabelCpf.Anchor = AnchorStyles.None;
            kryptonLabelCpf.Location = new Point(353, 187);
            kryptonLabelCpf.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCpf.Name = "kryptonLabelCpf";
            kryptonLabelCpf.Size = new Size(56, 26);
            kryptonLabelCpf.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCpf.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCpf.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCpf.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCpf.TabIndex = 3;
            kryptonLabelCpf.Values.ExtraText = "*";
            kryptonLabelCpf.Values.Text = "CPF";
            // 
            // kryptonLabelNascimento
            // 
            kryptonLabelNascimento.Anchor = AnchorStyles.None;
            kryptonLabelNascimento.Location = new Point(482, 187);
            kryptonLabelNascimento.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNascimento.Name = "kryptonLabelNascimento";
            kryptonLabelNascimento.Size = new Size(183, 26);
            kryptonLabelNascimento.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNascimento.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNascimento.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNascimento.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNascimento.TabIndex = 4;
            kryptonLabelNascimento.Values.ExtraText = "*";
            kryptonLabelNascimento.Values.Text = "Data de nascimento";
            // 
            // kryptonLabelEmail
            // 
            kryptonLabelEmail.Anchor = AnchorStyles.None;
            kryptonLabelEmail.Location = new Point(232, 268);
            kryptonLabelEmail.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelEmail.Name = "kryptonLabelEmail";
            kryptonLabelEmail.Size = new Size(76, 26);
            kryptonLabelEmail.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelEmail.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelEmail.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelEmail.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelEmail.TabIndex = 5;
            kryptonLabelEmail.Values.ExtraText = "*";
            kryptonLabelEmail.Values.Text = "E-mail";
            // 
            // kryptonLabelCelular
            // 
            kryptonLabelCelular.Anchor = AnchorStyles.None;
            kryptonLabelCelular.Location = new Point(432, 268);
            kryptonLabelCelular.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCelular.Name = "kryptonLabelCelular";
            kryptonLabelCelular.Size = new Size(82, 26);
            kryptonLabelCelular.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCelular.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCelular.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCelular.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCelular.TabIndex = 7;
            kryptonLabelCelular.Values.ExtraText = "*";
            kryptonLabelCelular.Values.Text = "Celular";
            // 
            // toggleButtonAtivo
            // 
            toggleButtonAtivo.Anchor = AnchorStyles.None;
            toggleButtonAtivo.AutoSize = true;
            toggleButtonAtivo.BackColor = Color.Transparent;
            toggleButtonAtivo.Checked = true;
            toggleButtonAtivo.CheckState = CheckState.Checked;
            toggleButtonAtivo.Cursor = Cursors.Hand;
            toggleButtonAtivo.FocusToggleColor = Color.Gold;
            toggleButtonAtivo.Location = new Point(581, 304);
            toggleButtonAtivo.Margin = new Padding(3, 4, 3, 4);
            toggleButtonAtivo.MinimumSize = new Size(51, 31);
            toggleButtonAtivo.Name = "toggleButtonAtivo";
            toggleButtonAtivo.OffBackColor = Color.Gray;
            toggleButtonAtivo.OffToggleColor = Color.Gainsboro;
            toggleButtonAtivo.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButtonAtivo.OnToggleColor = Color.WhiteSmoke;
            toggleButtonAtivo.Size = new Size(51, 31);
            toggleButtonAtivo.TabIndex = 25;
            toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelAtivo
            // 
            kryptonLabelAtivo.Anchor = AnchorStyles.None;
            kryptonLabelAtivo.Location = new Point(581, 268);
            kryptonLabelAtivo.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            kryptonLabelAtivo.Size = new Size(54, 26);
            kryptonLabelAtivo.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelAtivo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelAtivo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.TabIndex = 8;
            kryptonLabelAtivo.Values.Text = "Ativo";
            // 
            // CadClientePessoal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 101, 75);
            ClientSize = new Size(839, 455);
            Controls.Add(kryptonLabelAtivo);
            Controls.Add(toggleButtonAtivo);
            Controls.Add(kryptonLabelCelular);
            Controls.Add(kryptonLabelEmail);
            Controls.Add(kryptonLabelNascimento);
            Controls.Add(kryptonLabelCpf);
            Controls.Add(kryptonLabelSexo);
            Controls.Add(kryptonLabelSobronome);
            Controls.Add(kryptonLabelNome);
            Controls.Add(inputCelular);
            Controls.Add(inputCpf);
            Controls.Add(inputNascimento);
            Controls.Add(inputNome);
            Controls.Add(txtTitulo);
            Controls.Add(inputEmail);
            Controls.Add(btnProximo);
            Controls.Add(inputboxSexo);
            Controls.Add(inputSobrenome);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadClientePessoal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Cadastrar Cliente";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
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