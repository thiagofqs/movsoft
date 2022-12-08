namespace MovSoft
{
    partial class CadColaboradorEndereco
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
            this.inputCep = new System.Windows.Forms.MaskedTextBox();
            this.inputNumero = new System.Windows.Forms.TextBox();
            this.txtObr3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputComplemento = new System.Windows.Forms.TextBox();
            this.inputboxUf = new System.Windows.Forms.ComboBox();
            this.txtObr6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.Label();
            this.txtObr5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.Label();
            this.inputCidade = new System.Windows.Forms.TextBox();
            this.inputBairro = new System.Windows.Forms.TextBox();
            this.txtObr4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.Label();
            this.inputLogradouro = new System.Windows.Forms.TextBox();
            this.txtObr2 = new System.Windows.Forms.Label();
            this.txtObr1 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputCep
            // 
            this.inputCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCep.Location = new System.Drawing.Point(104, 110);
            this.inputCep.Mask = "00000-000";
            this.inputCep.Name = "inputCep";
            this.inputCep.PromptChar = ' ';
            this.inputCep.Size = new System.Drawing.Size(100, 23);
            this.inputCep.TabIndex = 0;
            this.inputCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputNumero
            // 
            this.inputNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNumero.Location = new System.Drawing.Point(398, 110);
            this.inputNumero.MaxLength = 10;
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Size = new System.Drawing.Size(76, 23);
            this.inputNumero.TabIndex = 2;
            // 
            // txtObr3
            // 
            this.txtObr3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr3.AutoSize = true;
            this.txtObr3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr3.Location = new System.Drawing.Point(462, 92);
            this.txtObr3.Name = "txtObr3";
            this.txtObr3.Size = new System.Drawing.Size(12, 15);
            this.txtObr3.TabIndex = 46;
            this.txtObr3.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(398, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Número";
            // 
            // inputComplemento
            // 
            this.inputComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputComplemento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputComplemento.Location = new System.Drawing.Point(498, 110);
            this.inputComplemento.MaxLength = 200;
            this.inputComplemento.Name = "inputComplemento";
            this.inputComplemento.Size = new System.Drawing.Size(154, 23);
            this.inputComplemento.TabIndex = 3;
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
            this.inputboxUf.Location = new System.Drawing.Point(498, 179);
            this.inputboxUf.Name = "inputboxUf";
            this.inputboxUf.Size = new System.Drawing.Size(77, 23);
            this.inputboxUf.TabIndex = 6;
            // 
            // txtObr6
            // 
            this.txtObr6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr6.AutoSize = true;
            this.txtObr6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr6.Location = new System.Drawing.Point(527, 161);
            this.txtObr6.Name = "txtObr6";
            this.txtObr6.Size = new System.Drawing.Size(12, 15);
            this.txtObr6.TabIndex = 43;
            this.txtObr6.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(498, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Complemento";
            // 
            // txtUf
            // 
            this.txtUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUf.AutoSize = true;
            this.txtUf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUf.Location = new System.Drawing.Point(497, 159);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(24, 17);
            this.txtUf.TabIndex = 44;
            this.txtUf.Text = "UF";
            // 
            // txtObr5
            // 
            this.txtObr5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr5.AutoSize = true;
            this.txtObr5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr5.Location = new System.Drawing.Point(371, 161);
            this.txtObr5.Name = "txtObr5";
            this.txtObr5.Size = new System.Drawing.Size(12, 15);
            this.txtObr5.TabIndex = 41;
            this.txtObr5.Text = "*";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.AutoSize = true;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCidade.Location = new System.Drawing.Point(320, 159);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(50, 17);
            this.txtCidade.TabIndex = 42;
            this.txtCidade.Text = "Cidade";
            // 
            // inputCidade
            // 
            this.inputCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCidade.Location = new System.Drawing.Point(320, 179);
            this.inputCidade.MaxLength = 100;
            this.inputCidade.Name = "inputCidade";
            this.inputCidade.Size = new System.Drawing.Size(154, 23);
            this.inputCidade.TabIndex = 5;
            // 
            // inputBairro
            // 
            this.inputBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBairro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputBairro.Location = new System.Drawing.Point(141, 179);
            this.inputBairro.MaxLength = 100;
            this.inputBairro.Name = "inputBairro";
            this.inputBairro.Size = new System.Drawing.Size(154, 23);
            this.inputBairro.TabIndex = 4;
            // 
            // txtObr4
            // 
            this.txtObr4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr4.AutoSize = true;
            this.txtObr4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr4.Location = new System.Drawing.Point(188, 161);
            this.txtObr4.Name = "txtObr4";
            this.txtObr4.Size = new System.Drawing.Size(12, 15);
            this.txtObr4.TabIndex = 39;
            this.txtObr4.Text = "*";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.AutoSize = true;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBairro.Location = new System.Drawing.Point(141, 159);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(45, 17);
            this.txtBairro.TabIndex = 40;
            this.txtBairro.Text = "Bairro";
            // 
            // inputLogradouro
            // 
            this.inputLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputLogradouro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputLogradouro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputLogradouro.Location = new System.Drawing.Point(226, 110);
            this.inputLogradouro.MaxLength = 255;
            this.inputLogradouro.Name = "inputLogradouro";
            this.inputLogradouro.Size = new System.Drawing.Size(154, 23);
            this.inputLogradouro.TabIndex = 1;
            // 
            // txtObr2
            // 
            this.txtObr2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr2.AutoSize = true;
            this.txtObr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr2.Location = new System.Drawing.Point(312, 92);
            this.txtObr2.Name = "txtObr2";
            this.txtObr2.Size = new System.Drawing.Size(12, 15);
            this.txtObr2.TabIndex = 36;
            this.txtObr2.Text = "*";
            // 
            // txtObr1
            // 
            this.txtObr1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr1.AutoSize = true;
            this.txtObr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr1.Location = new System.Drawing.Point(141, 92);
            this.txtObr1.Name = "txtObr1";
            this.txtObr1.Size = new System.Drawing.Size(12, 15);
            this.txtObr1.TabIndex = 29;
            this.txtObr1.Text = "*";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogradouro.AutoSize = true;
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogradouro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogradouro.Location = new System.Drawing.Point(226, 90);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(80, 17);
            this.txtLogradouro.TabIndex = 38;
            this.txtLogradouro.Text = "Logradouro";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCep.AutoSize = true;
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCep.Location = new System.Drawing.Point(104, 90);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(31, 17);
            this.txtCep.TabIndex = 31;
            this.txtCep.Text = "CEP";
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
            this.btnCadastrar.Location = new System.Drawing.Point(398, 244);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 35);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.Location = new System.Drawing.Point(200, 10);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(337, 32);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Cadastrar Colaborador (2/2)";
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.FlatAppearance.BorderSize = 0;
            this.botaoVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botaoVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.botaoVoltar.Location = new System.Drawing.Point(246, 244);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(115, 35);
            this.botaoVoltar.TabIndex = 8;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = false;
            this.botaoVoltar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.botaoVoltar_MouseClick);
            // 
            // CadColaboradorEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(734, 311);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.inputCep);
            this.Controls.Add(this.inputNumero);
            this.Controls.Add(this.txtObr3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputComplemento);
            this.Controls.Add(this.inputboxUf);
            this.Controls.Add(this.txtObr6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtObr5);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.inputCidade);
            this.Controls.Add(this.inputBairro);
            this.Controls.Add(this.txtObr4);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.inputLogradouro);
            this.Controls.Add(this.txtObr2);
            this.Controls.Add(this.txtObr1);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtCep);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadColaboradorEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Cadastrar Colaborador";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox inputCep;
        private TextBox inputNumero;
        private Label txtObr3;
        private Label label4;
        private TextBox inputComplemento;
        private ComboBox inputboxUf;
        private Label txtObr6;
        private Label label2;
        private Label txtUf;
        private Label txtObr5;
        private Label txtCidade;
        private TextBox inputCidade;
        private TextBox inputBairro;
        private Label txtObr4;
        private Label txtBairro;
        private TextBox inputLogradouro;
        private Label txtObr2;
        private Label txtObr1;
        private Label txtLogradouro;
        private Label txtCep;
        private Button btnCadastrar;
        private Label txtTitulo;
        private Button botaoVoltar;
    }
}