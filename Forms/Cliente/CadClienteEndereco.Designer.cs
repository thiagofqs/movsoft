﻿namespace MovSoft
{
    partial class CadClienteEndereco
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.inputCep = new System.Windows.Forms.MaskedTextBox();
            this.inputNumero = new System.Windows.Forms.TextBox();
            this.txtObr3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.Label();
            this.inputComplemento = new System.Windows.Forms.TextBox();
            this.inputboxUf = new System.Windows.Forms.ComboBox();
            this.txtObr6 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.Location = new System.Drawing.Point(235, 270);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 35);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            this.txtTitulo.Text = "Cadastrar Cliente (2/2)";
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
            this.btnCadastrar.Location = new System.Drawing.Point(387, 270);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 35);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // inputCep
            // 
            this.inputCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCep.Location = new System.Drawing.Point(93, 136);
            this.inputCep.Mask = "00000-000";
            this.inputCep.Name = "inputCep";
            this.inputCep.PromptChar = ' ';
            this.inputCep.Size = new System.Drawing.Size(100, 23);
            this.inputCep.TabIndex = 0;
            this.inputCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputCep.Leave += new System.EventHandler(this.inputCep_Leave);
            // 
            // inputNumero
            // 
            this.inputNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNumero.Location = new System.Drawing.Point(387, 136);
            this.inputNumero.MaxLength = 5;
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Size = new System.Drawing.Size(76, 23);
            this.inputNumero.TabIndex = 2;
            // 
            // txtObr3
            // 
            this.txtObr3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr3.AutoSize = true;
            this.txtObr3.BackColor = System.Drawing.Color.Transparent;
            this.txtObr3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr3.Location = new System.Drawing.Point(451, 118);
            this.txtObr3.Name = "txtObr3";
            this.txtObr3.Size = new System.Drawing.Size(12, 15);
            this.txtObr3.TabIndex = 2;
            this.txtObr3.Text = "*";
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumero.AutoSize = true;
            this.txtNumero.BackColor = System.Drawing.Color.Transparent;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumero.Location = new System.Drawing.Point(387, 116);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(58, 17);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.Text = "Número";
            // 
            // inputComplemento
            // 
            this.inputComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputComplemento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputComplemento.Location = new System.Drawing.Point(487, 136);
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
            this.inputboxUf.Enabled = false;
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
            this.inputboxUf.Location = new System.Drawing.Point(487, 205);
            this.inputboxUf.Name = "inputboxUf";
            this.inputboxUf.Size = new System.Drawing.Size(77, 23);
            this.inputboxUf.TabIndex = 6;
            // 
            // txtObr6
            // 
            this.txtObr6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr6.AutoSize = true;
            this.txtObr6.BackColor = System.Drawing.Color.Transparent;
            this.txtObr6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr6.Location = new System.Drawing.Point(516, 187);
            this.txtObr6.Name = "txtObr6";
            this.txtObr6.Size = new System.Drawing.Size(12, 15);
            this.txtObr6.TabIndex = 6;
            this.txtObr6.Text = "*";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplemento.AutoSize = true;
            this.txtComplemento.BackColor = System.Drawing.Color.Transparent;
            this.txtComplemento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtComplemento.Location = new System.Drawing.Point(487, 116);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(95, 17);
            this.txtComplemento.TabIndex = 3;
            this.txtComplemento.Text = "Complemento";
            // 
            // txtUf
            // 
            this.txtUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUf.AutoSize = true;
            this.txtUf.BackColor = System.Drawing.Color.Transparent;
            this.txtUf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUf.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUf.Location = new System.Drawing.Point(486, 185);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(24, 17);
            this.txtUf.TabIndex = 6;
            this.txtUf.Text = "UF";
            // 
            // txtObr5
            // 
            this.txtObr5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr5.AutoSize = true;
            this.txtObr5.BackColor = System.Drawing.Color.Transparent;
            this.txtObr5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr5.Location = new System.Drawing.Point(360, 187);
            this.txtObr5.Name = "txtObr5";
            this.txtObr5.Size = new System.Drawing.Size(12, 15);
            this.txtObr5.TabIndex = 5;
            this.txtObr5.Text = "*";
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.AutoSize = true;
            this.txtCidade.BackColor = System.Drawing.Color.Transparent;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCidade.Location = new System.Drawing.Point(309, 185);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(50, 17);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.Text = "Cidade";
            // 
            // inputCidade
            // 
            this.inputCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCidade.Enabled = false;
            this.inputCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCidade.Location = new System.Drawing.Point(309, 205);
            this.inputCidade.MaxLength = 100;
            this.inputCidade.Name = "inputCidade";
            this.inputCidade.ReadOnly = true;
            this.inputCidade.Size = new System.Drawing.Size(154, 23);
            this.inputCidade.TabIndex = 5;
            // 
            // inputBairro
            // 
            this.inputBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBairro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputBairro.Enabled = false;
            this.inputBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputBairro.Location = new System.Drawing.Point(130, 205);
            this.inputBairro.MaxLength = 100;
            this.inputBairro.Name = "inputBairro";
            this.inputBairro.ReadOnly = true;
            this.inputBairro.Size = new System.Drawing.Size(154, 23);
            this.inputBairro.TabIndex = 4;
            // 
            // txtObr4
            // 
            this.txtObr4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr4.AutoSize = true;
            this.txtObr4.BackColor = System.Drawing.Color.Transparent;
            this.txtObr4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr4.Location = new System.Drawing.Point(177, 187);
            this.txtObr4.Name = "txtObr4";
            this.txtObr4.Size = new System.Drawing.Size(12, 15);
            this.txtObr4.TabIndex = 4;
            this.txtObr4.Text = "*";
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.AutoSize = true;
            this.txtBairro.BackColor = System.Drawing.Color.Transparent;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBairro.Location = new System.Drawing.Point(130, 185);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(45, 17);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.Text = "Bairro";
            // 
            // inputLogradouro
            // 
            this.inputLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputLogradouro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputLogradouro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputLogradouro.Location = new System.Drawing.Point(215, 136);
            this.inputLogradouro.MaxLength = 255;
            this.inputLogradouro.Name = "inputLogradouro";
            this.inputLogradouro.Size = new System.Drawing.Size(154, 23);
            this.inputLogradouro.TabIndex = 1;
            // 
            // txtObr2
            // 
            this.txtObr2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr2.AutoSize = true;
            this.txtObr2.BackColor = System.Drawing.Color.Transparent;
            this.txtObr2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr2.Location = new System.Drawing.Point(301, 118);
            this.txtObr2.Name = "txtObr2";
            this.txtObr2.Size = new System.Drawing.Size(12, 15);
            this.txtObr2.TabIndex = 1;
            this.txtObr2.Text = "*";
            // 
            // txtObr1
            // 
            this.txtObr1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObr1.AutoSize = true;
            this.txtObr1.BackColor = System.Drawing.Color.Transparent;
            this.txtObr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObr1.Location = new System.Drawing.Point(130, 118);
            this.txtObr1.Name = "txtObr1";
            this.txtObr1.Size = new System.Drawing.Size(12, 15);
            this.txtObr1.TabIndex = 0;
            this.txtObr1.Text = "*";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogradouro.AutoSize = true;
            this.txtLogradouro.BackColor = System.Drawing.Color.Transparent;
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLogradouro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLogradouro.Location = new System.Drawing.Point(215, 116);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(80, 17);
            this.txtLogradouro.TabIndex = 1;
            this.txtLogradouro.Text = "Logradouro";
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCep.AutoSize = true;
            this.txtCep.BackColor = System.Drawing.Color.Transparent;
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCep.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCep.Location = new System.Drawing.Point(93, 116);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(31, 17);
            this.txtCep.TabIndex = 0;
            this.txtCep.Text = "CEP";
            // 
            // CadClienteEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(734, 341);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.inputCep);
            this.Controls.Add(this.inputNumero);
            this.Controls.Add(this.txtObr3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.inputComplemento);
            this.Controls.Add(this.inputboxUf);
            this.Controls.Add(this.txtObr6);
            this.Controls.Add(this.txtComplemento);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadClienteEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Cadastrar Cliente (2/2)";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private Label txtTitulo;
        private Button btnCadastrar;
        private MaskedTextBox inputCep;
        private TextBox inputNumero;
        private Label txtObr3;
        private Label txtNumero;
        private TextBox inputComplemento;
        private ComboBox inputboxUf;
        private Label txtObr6;
        private Label txtComplemento;
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
    }
}