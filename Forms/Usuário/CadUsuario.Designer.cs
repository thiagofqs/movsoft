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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.toggleButton1 = new MovSoft.Controls.ToggleButton();
            this.kryptonLabelConfirmarSenha = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelSenha = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCargo = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelUsuario = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelColaborador = new Krypton.Toolkit.KryptonLabel();
            this.inputboxColaborador = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.inputboxCargo = new System.Windows.Forms.ComboBox();
            this.inputConfirmarSenha = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.pnlContent.Controls.Add(this.toggleButton1);
            this.pnlContent.Controls.Add(this.kryptonLabelConfirmarSenha);
            this.pnlContent.Controls.Add(this.kryptonLabelSenha);
            this.pnlContent.Controls.Add(this.kryptonLabelCargo);
            this.pnlContent.Controls.Add(this.kryptonLabelUsuario);
            this.pnlContent.Controls.Add(this.kryptonLabelAtivo);
            this.pnlContent.Controls.Add(this.kryptonLabelColaborador);
            this.pnlContent.Controls.Add(this.inputboxColaborador);
            this.pnlContent.Controls.Add(this.btnCadastrar);
            this.pnlContent.Controls.Add(this.txtTitulo);
            this.pnlContent.Controls.Add(this.inputboxCargo);
            this.pnlContent.Controls.Add(this.inputConfirmarSenha);
            this.pnlContent.Controls.Add(this.inputSenha);
            this.pnlContent.Controls.Add(this.inputUsuario);
            this.pnlContent.Location = new System.Drawing.Point(90, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(734, 341);
            this.pnlContent.TabIndex = 0;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.toggleButton1.Checked = true;
            this.toggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton1.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButton1.Location = new System.Drawing.Point(442, 99);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 23);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 23);
            this.toggleButton1.TabIndex = 1;
            this.toggleButton1.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelConfirmarSenha
            // 
            this.kryptonLabelConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelConfirmarSenha.Location = new System.Drawing.Point(390, 197);
            this.kryptonLabelConfirmarSenha.Name = "kryptonLabelConfirmarSenha";
            this.kryptonLabelConfirmarSenha.Size = new System.Drawing.Size(127, 21);
            this.kryptonLabelConfirmarSenha.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelConfirmarSenha.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelConfirmarSenha.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelConfirmarSenha.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelConfirmarSenha.TabIndex = 5;
            this.kryptonLabelConfirmarSenha.Values.ExtraText = "*";
            this.kryptonLabelConfirmarSenha.Values.Text = "Confirmar senha";
            // 
            // kryptonLabelSenha
            // 
            this.kryptonLabelSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelSenha.Location = new System.Drawing.Point(191, 197);
            this.kryptonLabelSenha.Name = "kryptonLabelSenha";
            this.kryptonLabelSenha.Size = new System.Drawing.Size(61, 21);
            this.kryptonLabelSenha.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelSenha.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelSenha.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelSenha.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelSenha.TabIndex = 4;
            this.kryptonLabelSenha.Values.ExtraText = "*";
            this.kryptonLabelSenha.Values.Text = "Senha";
            // 
            // kryptonLabelCargo
            // 
            this.kryptonLabelCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelCargo.Location = new System.Drawing.Point(390, 137);
            this.kryptonLabelCargo.Name = "kryptonLabelCargo";
            this.kryptonLabelCargo.Size = new System.Drawing.Size(60, 21);
            this.kryptonLabelCargo.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCargo.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCargo.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCargo.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCargo.TabIndex = 3;
            this.kryptonLabelCargo.Values.ExtraText = "*";
            this.kryptonLabelCargo.Values.Text = "Cargo";
            // 
            // kryptonLabelUsuario
            // 
            this.kryptonLabelUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelUsuario.Location = new System.Drawing.Point(191, 137);
            this.kryptonLabelUsuario.Name = "kryptonLabelUsuario";
            this.kryptonLabelUsuario.Size = new System.Drawing.Size(71, 21);
            this.kryptonLabelUsuario.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelUsuario.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelUsuario.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelUsuario.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelUsuario.TabIndex = 2;
            this.kryptonLabelUsuario.Values.ExtraText = "*";
            this.kryptonLabelUsuario.Values.Text = "Usuário";
            // 
            // kryptonLabelAtivo
            // 
            this.kryptonLabelAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelAtivo.Location = new System.Drawing.Point(442, 73);
            this.kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            this.kryptonLabelAtivo.Size = new System.Drawing.Size(45, 21);
            this.kryptonLabelAtivo.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelAtivo.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelAtivo.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.TabIndex = 1;
            this.kryptonLabelAtivo.Values.Text = "Ativo";
            // 
            // kryptonLabelColaborador
            // 
            this.kryptonLabelColaborador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelColaborador.Location = new System.Drawing.Point(191, 73);
            this.kryptonLabelColaborador.Name = "kryptonLabelColaborador";
            this.kryptonLabelColaborador.Size = new System.Drawing.Size(101, 21);
            this.kryptonLabelColaborador.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelColaborador.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelColaborador.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelColaborador.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelColaborador.TabIndex = 0;
            this.kryptonLabelColaborador.Values.ExtraText = "*";
            this.kryptonLabelColaborador.Values.Text = "Colaborador";
            // 
            // inputboxColaborador
            // 
            this.inputboxColaborador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputboxColaborador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.inputboxColaborador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputboxColaborador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputboxColaborador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputboxColaborador.FormattingEnabled = true;
            this.inputboxColaborador.Location = new System.Drawing.Point(192, 99);
            this.inputboxColaborador.Name = "inputboxColaborador";
            this.inputboxColaborador.Size = new System.Drawing.Size(153, 23);
            this.inputboxColaborador.TabIndex = 0;
            this.inputboxColaborador.Tag = "Colaborador";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(308, 274);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 35);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.Location = new System.Drawing.Point(252, 33);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(218, 32);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Cadastrar Usuário";
            // 
            // inputboxCargo
            // 
            this.inputboxCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputboxCargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputboxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputboxCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputboxCargo.FormattingEnabled = true;
            this.inputboxCargo.Location = new System.Drawing.Point(392, 161);
            this.inputboxCargo.Name = "inputboxCargo";
            this.inputboxCargo.Size = new System.Drawing.Size(153, 23);
            this.inputboxCargo.TabIndex = 3;
            this.inputboxCargo.Tag = "Cargo";
            // 
            // inputConfirmarSenha
            // 
            this.inputConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputConfirmarSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputConfirmarSenha.Location = new System.Drawing.Point(391, 224);
            this.inputConfirmarSenha.MaxLength = 20;
            this.inputConfirmarSenha.Name = "inputConfirmarSenha";
            this.inputConfirmarSenha.Size = new System.Drawing.Size(154, 23);
            this.inputConfirmarSenha.TabIndex = 5;
            this.inputConfirmarSenha.Tag = "Confirmar Senha";
            this.inputConfirmarSenha.UseSystemPasswordChar = true;
            this.inputConfirmarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputConfirmarSenha_KeyPress);
            // 
            // inputSenha
            // 
            this.inputSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputSenha.Location = new System.Drawing.Point(191, 224);
            this.inputSenha.MaxLength = 20;
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(154, 23);
            this.inputSenha.TabIndex = 4;
            this.inputSenha.Tag = "Senha";
            this.inputSenha.UseSystemPasswordChar = true;
            // 
            // inputUsuario
            // 
            this.inputUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputUsuario.Location = new System.Drawing.Point(191, 161);
            this.inputUsuario.MaxLength = 20;
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(154, 23);
            this.inputUsuario.TabIndex = 2;
            this.inputUsuario.Tag = "Usuário";
            // 
            // CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(914, 464);
            this.Controls.Add(this.pnlContent);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Name = "CadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Cadastrar Usuário";
            this.TopMost = true;
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

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