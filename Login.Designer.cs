namespace MovSoft
{
    partial class Login
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.pnlLogin.Controls.Add(this.inputSenha);
            this.pnlLogin.Controls.Add(this.inputUsuario);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(208, 67);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(400, 350);
            this.pnlLogin.TabIndex = 2;
            // 
            // inputSenha
            // 
            this.inputSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputSenha.Location = new System.Drawing.Point(127, 158);
            this.inputSenha.MaxLength = 20;
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.PlaceholderText = "Senha";
            this.inputSenha.Size = new System.Drawing.Size(154, 23);
            this.inputSenha.TabIndex = 1;
            this.inputSenha.UseSystemPasswordChar = true;
            this.inputSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputSenha_KeyPress);
            // 
            // inputUsuario
            // 
            this.inputUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputUsuario.Location = new System.Drawing.Point(127, 94);
            this.inputUsuario.MaxLength = 20;
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.PlaceholderText = "Usuário";
            this.inputUsuario.Size = new System.Drawing.Size(154, 23);
            this.inputUsuario.TabIndex = 0;
            this.inputUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputUsuario_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Location = new System.Drawing.Point(152, 222);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlLogin;
        private TextBox inputSenha;
        private TextBox inputUsuario;
        private Button btnLogin;
    }
}