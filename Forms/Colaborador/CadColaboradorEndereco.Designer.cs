namespace MovSoft.Forms
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
            this.inputComplemento = new System.Windows.Forms.TextBox();
            this.inputBoxUf = new System.Windows.Forms.ComboBox();
            this.inputCidade = new System.Windows.Forms.TextBox();
            this.inputBairro = new System.Windows.Forms.TextBox();
            this.inputLogradouro = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.kryptonLabelCep = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelLogradouro = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelNumero = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelComplemento = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelBairro = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCidade = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelUf = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // inputCep
            // 
            this.inputCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCep.Location = new System.Drawing.Point(104, 125);
            this.inputCep.Mask = "00000-000";
            this.inputCep.Name = "inputCep";
            this.inputCep.PromptChar = ' ';
            this.inputCep.Size = new System.Drawing.Size(100, 23);
            this.inputCep.TabIndex = 0;
            this.inputCep.Tag = "CEP";
            this.inputCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCep_KeyPress);
            // 
            // inputNumero
            // 
            this.inputNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNumero.Location = new System.Drawing.Point(398, 124);
            this.inputNumero.MaxLength = 5;
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Size = new System.Drawing.Size(76, 23);
            this.inputNumero.TabIndex = 3;
            this.inputNumero.Tag = "Número";
            // 
            // inputComplemento
            // 
            this.inputComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputComplemento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputComplemento.Location = new System.Drawing.Point(498, 125);
            this.inputComplemento.MaxLength = 200;
            this.inputComplemento.Name = "inputComplemento";
            this.inputComplemento.Size = new System.Drawing.Size(154, 23);
            this.inputComplemento.TabIndex = 4;
            this.inputComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputComplemento_KeyPress);
            // 
            // inputBoxUf
            // 
            this.inputBoxUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBoxUf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputBoxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputBoxUf.Enabled = false;
            this.inputBoxUf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputBoxUf.FormattingEnabled = true;
            this.inputBoxUf.Items.AddRange(new object[] {
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
            this.inputBoxUf.Location = new System.Drawing.Point(498, 194);
            this.inputBoxUf.Name = "inputBoxUf";
            this.inputBoxUf.Size = new System.Drawing.Size(77, 23);
            this.inputBoxUf.TabIndex = 7;
            this.inputBoxUf.Tag = "UF";
            // 
            // inputCidade
            // 
            this.inputCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCidade.Enabled = false;
            this.inputCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCidade.Location = new System.Drawing.Point(320, 194);
            this.inputCidade.MaxLength = 100;
            this.inputCidade.Name = "inputCidade";
            this.inputCidade.ReadOnly = true;
            this.inputCidade.Size = new System.Drawing.Size(154, 23);
            this.inputCidade.TabIndex = 6;
            this.inputCidade.Tag = "Cidade";
            // 
            // inputBairro
            // 
            this.inputBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBairro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputBairro.Enabled = false;
            this.inputBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputBairro.Location = new System.Drawing.Point(141, 194);
            this.inputBairro.MaxLength = 100;
            this.inputBairro.Name = "inputBairro";
            this.inputBairro.ReadOnly = true;
            this.inputBairro.Size = new System.Drawing.Size(154, 23);
            this.inputBairro.TabIndex = 5;
            this.inputBairro.Tag = "Bairro";
            // 
            // inputLogradouro
            // 
            this.inputLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputLogradouro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputLogradouro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputLogradouro.Location = new System.Drawing.Point(226, 125);
            this.inputLogradouro.MaxLength = 255;
            this.inputLogradouro.Name = "inputLogradouro";
            this.inputLogradouro.Size = new System.Drawing.Size(154, 23);
            this.inputLogradouro.TabIndex = 2;
            this.inputLogradouro.Tag = "Logradouro";
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
            this.btnCadastrar.Location = new System.Drawing.Point(398, 259);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 35);
            this.btnCadastrar.TabIndex = 8;
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
            this.txtTitulo.Location = new System.Drawing.Point(213, 25);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(337, 32);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Cadastrar Colaborador (2/2)";
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
            this.btnVoltar.Location = new System.Drawing.Point(246, 259);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(115, 35);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisarCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnPesquisarCep.BackgroundImage = global::MovSoft.Properties.Resources.icon_search;
            this.btnPesquisarCep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarCep.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCep.Location = new System.Drawing.Point(181, 125);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(23, 22);
            this.btnPesquisarCep.TabIndex = 1;
            this.btnPesquisarCep.TabStop = false;
            this.btnPesquisarCep.UseVisualStyleBackColor = false;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // kryptonLabelCep
            // 
            this.kryptonLabelCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelCep.Location = new System.Drawing.Point(104, 98);
            this.kryptonLabelCep.Name = "kryptonLabelCep";
            this.kryptonLabelCep.Size = new System.Drawing.Size(47, 21);
            this.kryptonLabelCep.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCep.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCep.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCep.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCep.TabIndex = 0;
            this.kryptonLabelCep.Values.ExtraText = "*";
            this.kryptonLabelCep.Values.Text = "CEP";
            // 
            // kryptonLabelLogradouro
            // 
            this.kryptonLabelLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelLogradouro.Location = new System.Drawing.Point(226, 98);
            this.kryptonLabelLogradouro.Name = "kryptonLabelLogradouro";
            this.kryptonLabelLogradouro.Size = new System.Drawing.Size(97, 21);
            this.kryptonLabelLogradouro.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelLogradouro.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelLogradouro.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelLogradouro.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelLogradouro.TabIndex = 1;
            this.kryptonLabelLogradouro.Values.ExtraText = "*";
            this.kryptonLabelLogradouro.Values.Text = "Logradouro";
            // 
            // kryptonLabelNumero
            // 
            this.kryptonLabelNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelNumero.Location = new System.Drawing.Point(398, 97);
            this.kryptonLabelNumero.Name = "kryptonLabelNumero";
            this.kryptonLabelNumero.Size = new System.Drawing.Size(75, 21);
            this.kryptonLabelNumero.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelNumero.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNumero.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelNumero.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNumero.TabIndex = 2;
            this.kryptonLabelNumero.Values.ExtraText = "*";
            this.kryptonLabelNumero.Values.Text = "Número";
            // 
            // kryptonLabelComplemento
            // 
            this.kryptonLabelComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelComplemento.Location = new System.Drawing.Point(497, 97);
            this.kryptonLabelComplemento.Name = "kryptonLabelComplemento";
            this.kryptonLabelComplemento.Size = new System.Drawing.Size(100, 21);
            this.kryptonLabelComplemento.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelComplemento.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelComplemento.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelComplemento.TabIndex = 3;
            this.kryptonLabelComplemento.Values.Text = "Complemento";
            // 
            // kryptonLabelBairro
            // 
            this.kryptonLabelBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelBairro.Location = new System.Drawing.Point(141, 167);
            this.kryptonLabelBairro.Name = "kryptonLabelBairro";
            this.kryptonLabelBairro.Size = new System.Drawing.Size(61, 21);
            this.kryptonLabelBairro.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelBairro.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelBairro.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelBairro.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelBairro.TabIndex = 4;
            this.kryptonLabelBairro.Values.ExtraText = "*";
            this.kryptonLabelBairro.Values.Text = "Bairro";
            // 
            // kryptonLabelCidade
            // 
            this.kryptonLabelCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelCidade.Location = new System.Drawing.Point(320, 167);
            this.kryptonLabelCidade.Name = "kryptonLabelCidade";
            this.kryptonLabelCidade.Size = new System.Drawing.Size(66, 21);
            this.kryptonLabelCidade.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCidade.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCidade.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCidade.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCidade.TabIndex = 5;
            this.kryptonLabelCidade.Values.ExtraText = "*";
            this.kryptonLabelCidade.Values.Text = "Cidade";
            // 
            // kryptonLabelUf
            // 
            this.kryptonLabelUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelUf.Location = new System.Drawing.Point(497, 167);
            this.kryptonLabelUf.Name = "kryptonLabelUf";
            this.kryptonLabelUf.Size = new System.Drawing.Size(39, 21);
            this.kryptonLabelUf.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelUf.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelUf.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelUf.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelUf.TabIndex = 6;
            this.kryptonLabelUf.Values.ExtraText = "*";
            this.kryptonLabelUf.Values.Text = "UF";
            // 
            // CadColaboradorEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(734, 341);
            this.Controls.Add(this.kryptonLabelUf);
            this.Controls.Add(this.kryptonLabelCidade);
            this.Controls.Add(this.kryptonLabelBairro);
            this.Controls.Add(this.kryptonLabelComplemento);
            this.Controls.Add(this.kryptonLabelNumero);
            this.Controls.Add(this.kryptonLabelLogradouro);
            this.Controls.Add(this.kryptonLabelCep);
            this.Controls.Add(this.btnPesquisarCep);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.inputCep);
            this.Controls.Add(this.inputNumero);
            this.Controls.Add(this.inputComplemento);
            this.Controls.Add(this.inputBoxUf);
            this.Controls.Add(this.inputCidade);
            this.Controls.Add(this.inputBairro);
            this.Controls.Add(this.inputLogradouro);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private TextBox inputComplemento;
        private ComboBox inputBoxUf;
        private TextBox inputCidade;
        private TextBox inputBairro;
        private TextBox inputLogradouro;
        private Button btnCadastrar;
        private Label txtTitulo;
        private Button btnVoltar;
        private Button btnPesquisarCep;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCep;
        private Krypton.Toolkit.KryptonLabel kryptonLabelLogradouro;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNumero;
        private Krypton.Toolkit.KryptonLabel kryptonLabelComplemento;
        private Krypton.Toolkit.KryptonLabel kryptonLabelBairro;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCidade;
        private Krypton.Toolkit.KryptonLabel kryptonLabelUf;
    }
}