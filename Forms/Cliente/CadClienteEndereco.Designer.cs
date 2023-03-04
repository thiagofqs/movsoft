namespace MovSoft
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
            btnVoltar = new Button();
            txtTitulo = new Label();
            btnCadastrar = new Button();
            inputCep = new MaskedTextBox();
            inputNumero = new TextBox();
            txtObr3 = new Label();
            txtNumero = new Label();
            inputComplemento = new TextBox();
            inputboxUf = new ComboBox();
            txtObr6 = new Label();
            txtComplemento = new Label();
            txtUf = new Label();
            txtObr5 = new Label();
            txtCidade = new Label();
            inputCidade = new TextBox();
            inputBairro = new TextBox();
            txtObr4 = new Label();
            txtBairro = new Label();
            inputLogradouro = new TextBox();
            txtObr2 = new Label();
            txtObr1 = new Label();
            txtLogradouro = new Label();
            txtCep = new Label();
            btnPesquisarCep = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.BackColor = Color.FromArgb(0, 133, 132);
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.WhiteSmoke;
            btnVoltar.Location = new Point(235, 270);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(115, 35);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.AutoSize = true;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.ForeColor = Color.WhiteSmoke;
            txtTitulo.Location = new Point(246, 36);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(273, 32);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Cadastrar Cliente (2/2)";
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
            btnCadastrar.Location = new Point(387, 270);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(115, 35);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // inputCep
            // 
            inputCep.Anchor = AnchorStyles.None;
            inputCep.BackColor = Color.WhiteSmoke;
            inputCep.ForeColor = Color.FromArgb(56, 56, 56);
            inputCep.Location = new Point(93, 136);
            inputCep.Mask = "00000-000";
            inputCep.Name = "inputCep";
            inputCep.PromptChar = ' ';
            inputCep.Size = new Size(100, 23);
            inputCep.TabIndex = 0;
            inputCep.KeyPress += inputCep_KeyPress;
            // 
            // inputNumero
            // 
            inputNumero.Anchor = AnchorStyles.None;
            inputNumero.BackColor = Color.WhiteSmoke;
            inputNumero.ForeColor = Color.FromArgb(56, 56, 56);
            inputNumero.Location = new Point(387, 136);
            inputNumero.MaxLength = 5;
            inputNumero.Name = "inputNumero";
            inputNumero.Size = new Size(76, 23);
            inputNumero.TabIndex = 3;
            // 
            // txtObr3
            // 
            txtObr3.Anchor = AnchorStyles.None;
            txtObr3.AutoSize = true;
            txtObr3.BackColor = Color.Transparent;
            txtObr3.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr3.Location = new Point(451, 118);
            txtObr3.Name = "txtObr3";
            txtObr3.Size = new Size(12, 15);
            txtObr3.TabIndex = 2;
            txtObr3.Text = "*";
            // 
            // txtNumero
            // 
            txtNumero.Anchor = AnchorStyles.None;
            txtNumero.AutoSize = true;
            txtNumero.BackColor = Color.Transparent;
            txtNumero.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumero.ForeColor = Color.WhiteSmoke;
            txtNumero.Location = new Point(387, 116);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(58, 17);
            txtNumero.TabIndex = 2;
            txtNumero.Text = "Número";
            // 
            // inputComplemento
            // 
            inputComplemento.Anchor = AnchorStyles.None;
            inputComplemento.BackColor = Color.WhiteSmoke;
            inputComplemento.ForeColor = Color.FromArgb(56, 56, 56);
            inputComplemento.Location = new Point(487, 136);
            inputComplemento.MaxLength = 200;
            inputComplemento.Name = "inputComplemento";
            inputComplemento.Size = new Size(154, 23);
            inputComplemento.TabIndex = 4;
            // 
            // inputboxUf
            // 
            inputboxUf.Anchor = AnchorStyles.None;
            inputboxUf.BackColor = Color.WhiteSmoke;
            inputboxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            inputboxUf.Enabled = false;
            inputboxUf.ForeColor = Color.FromArgb(56, 56, 56);
            inputboxUf.FormattingEnabled = true;
            inputboxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            inputboxUf.Location = new Point(487, 205);
            inputboxUf.Name = "inputboxUf";
            inputboxUf.Size = new Size(77, 23);
            inputboxUf.TabIndex = 7;
            // 
            // txtObr6
            // 
            txtObr6.Anchor = AnchorStyles.None;
            txtObr6.AutoSize = true;
            txtObr6.BackColor = Color.Transparent;
            txtObr6.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr6.Location = new Point(516, 187);
            txtObr6.Name = "txtObr6";
            txtObr6.Size = new Size(12, 15);
            txtObr6.TabIndex = 6;
            txtObr6.Text = "*";
            // 
            // txtComplemento
            // 
            txtComplemento.Anchor = AnchorStyles.None;
            txtComplemento.AutoSize = true;
            txtComplemento.BackColor = Color.Transparent;
            txtComplemento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtComplemento.ForeColor = Color.WhiteSmoke;
            txtComplemento.Location = new Point(487, 116);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(95, 17);
            txtComplemento.TabIndex = 3;
            txtComplemento.Text = "Complemento";
            // 
            // txtUf
            // 
            txtUf.Anchor = AnchorStyles.None;
            txtUf.AutoSize = true;
            txtUf.BackColor = Color.Transparent;
            txtUf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUf.ForeColor = Color.WhiteSmoke;
            txtUf.Location = new Point(486, 185);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(24, 17);
            txtUf.TabIndex = 6;
            txtUf.Text = "UF";
            // 
            // txtObr5
            // 
            txtObr5.Anchor = AnchorStyles.None;
            txtObr5.AutoSize = true;
            txtObr5.BackColor = Color.Transparent;
            txtObr5.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr5.Location = new Point(360, 187);
            txtObr5.Name = "txtObr5";
            txtObr5.Size = new Size(12, 15);
            txtObr5.TabIndex = 5;
            txtObr5.Text = "*";
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.None;
            txtCidade.AutoSize = true;
            txtCidade.BackColor = Color.Transparent;
            txtCidade.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCidade.ForeColor = Color.WhiteSmoke;
            txtCidade.Location = new Point(309, 185);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(50, 17);
            txtCidade.TabIndex = 5;
            txtCidade.Text = "Cidade";
            // 
            // inputCidade
            // 
            inputCidade.Anchor = AnchorStyles.None;
            inputCidade.BackColor = Color.WhiteSmoke;
            inputCidade.Enabled = false;
            inputCidade.ForeColor = Color.FromArgb(56, 56, 56);
            inputCidade.Location = new Point(309, 205);
            inputCidade.MaxLength = 100;
            inputCidade.Name = "inputCidade";
            inputCidade.ReadOnly = true;
            inputCidade.Size = new Size(154, 23);
            inputCidade.TabIndex = 6;
            // 
            // inputBairro
            // 
            inputBairro.Anchor = AnchorStyles.None;
            inputBairro.BackColor = Color.WhiteSmoke;
            inputBairro.Enabled = false;
            inputBairro.ForeColor = Color.FromArgb(56, 56, 56);
            inputBairro.Location = new Point(130, 205);
            inputBairro.MaxLength = 100;
            inputBairro.Name = "inputBairro";
            inputBairro.ReadOnly = true;
            inputBairro.Size = new Size(154, 23);
            inputBairro.TabIndex = 5;
            // 
            // txtObr4
            // 
            txtObr4.Anchor = AnchorStyles.None;
            txtObr4.AutoSize = true;
            txtObr4.BackColor = Color.Transparent;
            txtObr4.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr4.Location = new Point(177, 187);
            txtObr4.Name = "txtObr4";
            txtObr4.Size = new Size(12, 15);
            txtObr4.TabIndex = 4;
            txtObr4.Text = "*";
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.None;
            txtBairro.AutoSize = true;
            txtBairro.BackColor = Color.Transparent;
            txtBairro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtBairro.ForeColor = Color.WhiteSmoke;
            txtBairro.Location = new Point(130, 185);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(45, 17);
            txtBairro.TabIndex = 4;
            txtBairro.Text = "Bairro";
            // 
            // inputLogradouro
            // 
            inputLogradouro.Anchor = AnchorStyles.None;
            inputLogradouro.BackColor = Color.WhiteSmoke;
            inputLogradouro.ForeColor = Color.FromArgb(56, 56, 56);
            inputLogradouro.Location = new Point(215, 136);
            inputLogradouro.MaxLength = 255;
            inputLogradouro.Name = "inputLogradouro";
            inputLogradouro.Size = new Size(154, 23);
            inputLogradouro.TabIndex = 2;
            // 
            // txtObr2
            // 
            txtObr2.Anchor = AnchorStyles.None;
            txtObr2.AutoSize = true;
            txtObr2.BackColor = Color.Transparent;
            txtObr2.ForeColor = Color.FromArgb(255, 51, 56);
            txtObr2.Location = new Point(301, 118);
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
            txtObr1.Location = new Point(130, 118);
            txtObr1.Name = "txtObr1";
            txtObr1.Size = new Size(12, 15);
            txtObr1.TabIndex = 0;
            txtObr1.Text = "*";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.None;
            txtLogradouro.AutoSize = true;
            txtLogradouro.BackColor = Color.Transparent;
            txtLogradouro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLogradouro.ForeColor = Color.WhiteSmoke;
            txtLogradouro.Location = new Point(215, 116);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(80, 17);
            txtLogradouro.TabIndex = 1;
            txtLogradouro.Text = "Logradouro";
            // 
            // txtCep
            // 
            txtCep.Anchor = AnchorStyles.None;
            txtCep.AutoSize = true;
            txtCep.BackColor = Color.Transparent;
            txtCep.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCep.ForeColor = Color.WhiteSmoke;
            txtCep.Location = new Point(93, 116);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(31, 17);
            txtCep.TabIndex = 0;
            txtCep.Text = "CEP";
            // 
            // btnPesquisarCep
            // 
            btnPesquisarCep.BackColor = Color.FromArgb(0, 133, 132);
            btnPesquisarCep.BackgroundImage = Properties.Resources.icon_search;
            btnPesquisarCep.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisarCep.Cursor = Cursors.Hand;
            btnPesquisarCep.FlatAppearance.BorderSize = 0;
            btnPesquisarCep.FlatStyle = FlatStyle.Flat;
            btnPesquisarCep.Location = new Point(169, 137);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(23, 21);
            btnPesquisarCep.TabIndex = 1;
            btnPesquisarCep.UseVisualStyleBackColor = false;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // CadClienteEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 101, 75);
            ClientSize = new Size(734, 341);
            Controls.Add(btnPesquisarCep);
            Controls.Add(btnVoltar);
            Controls.Add(txtTitulo);
            Controls.Add(btnCadastrar);
            Controls.Add(inputCep);
            Controls.Add(inputNumero);
            Controls.Add(txtObr3);
            Controls.Add(txtNumero);
            Controls.Add(inputComplemento);
            Controls.Add(inputboxUf);
            Controls.Add(txtObr6);
            Controls.Add(txtComplemento);
            Controls.Add(txtUf);
            Controls.Add(txtObr5);
            Controls.Add(txtCidade);
            Controls.Add(inputCidade);
            Controls.Add(inputBairro);
            Controls.Add(txtObr4);
            Controls.Add(txtBairro);
            Controls.Add(inputLogradouro);
            Controls.Add(txtObr2);
            Controls.Add(txtObr1);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCep);
            ForeColor = Color.FromArgb(56, 56, 56);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadClienteEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Cadastrar Cliente (2/2)";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnPesquisarCep;
    }
}