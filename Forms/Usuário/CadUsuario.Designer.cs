namespace MovSoft.Forms
{
    partial class CadUsuario
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
            pnlContent = new Panel();
            toggleButton1 = new Controls.ToggleButton();
            kryptonLabelConfirmarSenha = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelSenha = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelCargo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelUsuario = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelColaborador = new Krypton.Toolkit.KryptonLabel();
            inputboxColaborador = new ComboBox();
            btnCadastrar = new Button();
            txtTitulo = new Label();
            inputboxCargo = new ComboBox();
            inputConfirmarSenha = new TextBox();
            inputSenha = new TextBox();
            inputUsuario = new TextBox();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = Color.FromArgb(114, 101, 75);
            pnlContent.Controls.Add(toggleButton1);
            pnlContent.Controls.Add(kryptonLabelConfirmarSenha);
            pnlContent.Controls.Add(kryptonLabelSenha);
            pnlContent.Controls.Add(kryptonLabelCargo);
            pnlContent.Controls.Add(kryptonLabelUsuario);
            pnlContent.Controls.Add(kryptonLabelAtivo);
            pnlContent.Controls.Add(kryptonLabelColaborador);
            pnlContent.Controls.Add(inputboxColaborador);
            pnlContent.Controls.Add(btnCadastrar);
            pnlContent.Controls.Add(txtTitulo);
            pnlContent.Controls.Add(inputboxCargo);
            pnlContent.Controls.Add(inputConfirmarSenha);
            pnlContent.Controls.Add(inputSenha);
            pnlContent.Controls.Add(inputUsuario);
            pnlContent.Location = new Point(103, 87);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(839, 455);
            pnlContent.TabIndex = 0;
            // 
            // toggleButton1
            // 
            toggleButton1.Anchor = AnchorStyles.None;
            toggleButton1.AutoSize = true;
            toggleButton1.BackColor = Color.Transparent;
            toggleButton1.Checked = true;
            toggleButton1.CheckState = CheckState.Checked;
            toggleButton1.Cursor = Cursors.Hand;
            toggleButton1.FocusToggleColor = Color.Gold;
            toggleButton1.Location = new Point(551, 261);
            toggleButton1.Margin = new Padding(3, 4, 3, 4);
            toggleButton1.MinimumSize = new Size(51, 31);
            toggleButton1.Name = "toggleButton1";
            toggleButton1.OffBackColor = Color.Gray;
            toggleButton1.OffToggleColor = Color.Gainsboro;
            toggleButton1.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButton1.OnToggleColor = Color.WhiteSmoke;
            toggleButton1.Size = new Size(51, 31);
            toggleButton1.TabIndex = 5;
            toggleButton1.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelConfirmarSenha
            // 
            kryptonLabelConfirmarSenha.Anchor = AnchorStyles.None;
            kryptonLabelConfirmarSenha.Location = new Point(351, 225);
            kryptonLabelConfirmarSenha.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelConfirmarSenha.Name = "kryptonLabelConfirmarSenha";
            kryptonLabelConfirmarSenha.Size = new Size(157, 26);
            kryptonLabelConfirmarSenha.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelConfirmarSenha.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelConfirmarSenha.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelConfirmarSenha.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelConfirmarSenha.TabIndex = 4;
            kryptonLabelConfirmarSenha.Values.ExtraText = "*";
            kryptonLabelConfirmarSenha.Values.Text = "Confirmar senha";
            // 
            // kryptonLabelSenha
            // 
            kryptonLabelSenha.Anchor = AnchorStyles.None;
            kryptonLabelSenha.Location = new Point(144, 225);
            kryptonLabelSenha.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelSenha.Name = "kryptonLabelSenha";
            kryptonLabelSenha.Size = new Size(75, 26);
            kryptonLabelSenha.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelSenha.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelSenha.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelSenha.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelSenha.TabIndex = 3;
            kryptonLabelSenha.Values.ExtraText = "*";
            kryptonLabelSenha.Values.Text = "Senha";
            // 
            // kryptonLabelCargo
            // 
            kryptonLabelCargo.Anchor = AnchorStyles.None;
            kryptonLabelCargo.Location = new Point(551, 143);
            kryptonLabelCargo.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCargo.Name = "kryptonLabelCargo";
            kryptonLabelCargo.Size = new Size(74, 26);
            kryptonLabelCargo.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCargo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCargo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCargo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCargo.TabIndex = 2;
            kryptonLabelCargo.Values.ExtraText = "*";
            kryptonLabelCargo.Values.Text = "Cargo";
            // 
            // kryptonLabelUsuario
            // 
            kryptonLabelUsuario.Anchor = AnchorStyles.None;
            kryptonLabelUsuario.Location = new Point(349, 143);
            kryptonLabelUsuario.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelUsuario.Name = "kryptonLabelUsuario";
            kryptonLabelUsuario.Size = new Size(87, 26);
            kryptonLabelUsuario.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelUsuario.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUsuario.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelUsuario.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUsuario.TabIndex = 1;
            kryptonLabelUsuario.Values.ExtraText = "*";
            kryptonLabelUsuario.Values.Text = "Usuário";
            // 
            // kryptonLabelAtivo
            // 
            kryptonLabelAtivo.Anchor = AnchorStyles.None;
            kryptonLabelAtivo.Location = new Point(551, 227);
            kryptonLabelAtivo.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            kryptonLabelAtivo.Size = new Size(54, 26);
            kryptonLabelAtivo.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelAtivo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelAtivo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.TabIndex = 5;
            kryptonLabelAtivo.Values.Text = "Ativo";
            // 
            // kryptonLabelColaborador
            // 
            kryptonLabelColaborador.Anchor = AnchorStyles.None;
            kryptonLabelColaborador.Location = new Point(142, 140);
            kryptonLabelColaborador.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelColaborador.Name = "kryptonLabelColaborador";
            kryptonLabelColaborador.Size = new Size(125, 26);
            kryptonLabelColaborador.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelColaborador.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelColaborador.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelColaborador.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelColaborador.TabIndex = 0;
            kryptonLabelColaborador.Values.ExtraText = "*";
            kryptonLabelColaborador.Values.Text = "Colaborador";
            // 
            // inputboxColaborador
            // 
            inputboxColaborador.Anchor = AnchorStyles.None;
            inputboxColaborador.AutoCompleteMode = AutoCompleteMode.Append;
            inputboxColaborador.AutoCompleteSource = AutoCompleteSource.CustomSource;
            inputboxColaborador.BackColor = Color.WhiteSmoke;
            inputboxColaborador.ForeColor = Color.FromArgb(56, 56, 56);
            inputboxColaborador.FormattingEnabled = true;
            inputboxColaborador.Location = new Point(143, 175);
            inputboxColaborador.Margin = new Padding(3, 4, 3, 4);
            inputboxColaborador.Name = "inputboxColaborador";
            inputboxColaborador.Size = new Size(174, 28);
            inputboxColaborador.TabIndex = 0;
            inputboxColaborador.Tag = "Colaborador";
            inputboxColaborador.Validating += comboBox1_Validating;
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
            btnCadastrar.Location = new Point(352, 365);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 47);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.AutoSize = true;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.ForeColor = Color.WhiteSmoke;
            txtTitulo.Location = new Point(288, 44);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(269, 41);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Cadastrar Usuário";
            // 
            // inputboxCargo
            // 
            inputboxCargo.Anchor = AnchorStyles.None;
            inputboxCargo.BackColor = Color.WhiteSmoke;
            inputboxCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            inputboxCargo.ForeColor = Color.FromArgb(56, 56, 56);
            inputboxCargo.FormattingEnabled = true;
            inputboxCargo.Location = new Point(553, 175);
            inputboxCargo.Margin = new Padding(3, 4, 3, 4);
            inputboxCargo.Name = "inputboxCargo";
            inputboxCargo.Size = new Size(174, 28);
            inputboxCargo.TabIndex = 2;
            inputboxCargo.Tag = "Cargo";
            // 
            // inputConfirmarSenha
            // 
            inputConfirmarSenha.Anchor = AnchorStyles.None;
            inputConfirmarSenha.BackColor = Color.WhiteSmoke;
            inputConfirmarSenha.ForeColor = Color.FromArgb(56, 56, 56);
            inputConfirmarSenha.Location = new Point(352, 261);
            inputConfirmarSenha.Margin = new Padding(3, 4, 3, 4);
            inputConfirmarSenha.MaxLength = 20;
            inputConfirmarSenha.Name = "inputConfirmarSenha";
            inputConfirmarSenha.Size = new Size(175, 27);
            inputConfirmarSenha.TabIndex = 4;
            inputConfirmarSenha.Tag = "Confirmar Senha";
            inputConfirmarSenha.UseSystemPasswordChar = true;
            inputConfirmarSenha.KeyPress += inputConfirmarSenha_KeyPress;
            // 
            // inputSenha
            // 
            inputSenha.Anchor = AnchorStyles.None;
            inputSenha.BackColor = Color.WhiteSmoke;
            inputSenha.ForeColor = Color.FromArgb(56, 56, 56);
            inputSenha.Location = new Point(144, 261);
            inputSenha.Margin = new Padding(3, 4, 3, 4);
            inputSenha.MaxLength = 20;
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(175, 27);
            inputSenha.TabIndex = 3;
            inputSenha.Tag = "Senha";
            inputSenha.UseSystemPasswordChar = true;
            // 
            // inputUsuario
            // 
            inputUsuario.Anchor = AnchorStyles.None;
            inputUsuario.BackColor = Color.WhiteSmoke;
            inputUsuario.ForeColor = Color.FromArgb(56, 56, 56);
            inputUsuario.Location = new Point(349, 175);
            inputUsuario.Margin = new Padding(3, 4, 3, 4);
            inputUsuario.MaxLength = 20;
            inputUsuario.Name = "inputUsuario";
            inputUsuario.Size = new Size(175, 27);
            inputUsuario.TabIndex = 1;
            inputUsuario.Tag = "Usuário";
            // 
            // CadUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1045, 619);
            Controls.Add(pnlContent);
            ForeColor = Color.FromArgb(56, 56, 56);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Cadastrar Usuário";
            TopMost = true;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContent;
        private ComboBox inputboxCargo;
        private TextBox inputConfirmarSenha;
        private TextBox inputSenha;
        private TextBox inputUsuario;
        private Label txtTitulo;
        private Button btnCadastrar;
        private ComboBox inputboxColaborador;
        private Krypton.Toolkit.KryptonLabel kryptonLabelConfirmarSenha;
        private Krypton.Toolkit.KryptonLabel kryptonLabelSenha;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCargo;
        private Krypton.Toolkit.KryptonLabel kryptonLabelUsuario;
        private Krypton.Toolkit.KryptonLabel kryptonLabelAtivo;
        private Krypton.Toolkit.KryptonLabel kryptonLabelColaborador;
        private Controls.ToggleButton toggleButton1;
    }
}