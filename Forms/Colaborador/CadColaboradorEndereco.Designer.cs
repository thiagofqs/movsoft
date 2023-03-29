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
            inputCep = new MaskedTextBox();
            inputNumero = new TextBox();
            inputComplemento = new TextBox();
            inputBoxUf = new ComboBox();
            inputCidade = new TextBox();
            inputBairro = new TextBox();
            inputLogradouro = new TextBox();
            btnCadastrar = new Button();
            txtTitulo = new Label();
            btnVoltar = new Button();
            btnPesquisarCep = new Button();
            kryptonLabelCep = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelLogradouro = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelNumero = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelComplemento = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelBairro = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelCidade = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelUf = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // inputCep
            // 
            inputCep.Anchor = AnchorStyles.None;
            inputCep.BackColor = Color.WhiteSmoke;
            inputCep.ForeColor = Color.FromArgb(56, 56, 56);
            inputCep.Location = new Point(104, 125);
            inputCep.Mask = "00000-000";
            inputCep.Name = "inputCep";
            inputCep.PromptChar = ' ';
            inputCep.Size = new Size(100, 23);
            inputCep.TabIndex = 0;
            inputCep.Tag = "CEP";
            inputCep.KeyPress += inputCep_KeyPress;
            // 
            // inputNumero
            // 
            inputNumero.Anchor = AnchorStyles.None;
            inputNumero.BackColor = Color.WhiteSmoke;
            inputNumero.ForeColor = Color.FromArgb(56, 56, 56);
            inputNumero.Location = new Point(398, 124);
            inputNumero.MaxLength = 5;
            inputNumero.Name = "inputNumero";
            inputNumero.Size = new Size(76, 23);
            inputNumero.TabIndex = 3;
            inputNumero.Tag = "Número";
            // 
            // inputComplemento
            // 
            inputComplemento.Anchor = AnchorStyles.None;
            inputComplemento.BackColor = Color.WhiteSmoke;
            inputComplemento.ForeColor = Color.FromArgb(56, 56, 56);
            inputComplemento.Location = new Point(498, 125);
            inputComplemento.MaxLength = 200;
            inputComplemento.Name = "inputComplemento";
            inputComplemento.Size = new Size(154, 23);
            inputComplemento.TabIndex = 4;
            inputComplemento.KeyPress += inputComplemento_KeyPress;
            // 
            // inputBoxUf
            // 
            inputBoxUf.Anchor = AnchorStyles.None;
            inputBoxUf.BackColor = Color.WhiteSmoke;
            inputBoxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            inputBoxUf.Enabled = false;
            inputBoxUf.ForeColor = Color.FromArgb(56, 56, 56);
            inputBoxUf.FormattingEnabled = true;
            inputBoxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            inputBoxUf.Location = new Point(498, 194);
            inputBoxUf.Name = "inputBoxUf";
            inputBoxUf.Size = new Size(77, 23);
            inputBoxUf.TabIndex = 7;
            inputBoxUf.Tag = "UF";
            // 
            // inputCidade
            // 
            inputCidade.Anchor = AnchorStyles.None;
            inputCidade.BackColor = Color.WhiteSmoke;
            inputCidade.Enabled = false;
            inputCidade.ForeColor = Color.FromArgb(56, 56, 56);
            inputCidade.Location = new Point(320, 194);
            inputCidade.MaxLength = 100;
            inputCidade.Name = "inputCidade";
            inputCidade.Size = new Size(154, 23);
            inputCidade.TabIndex = 6;
            inputCidade.Tag = "Cidade";
            // 
            // inputBairro
            // 
            inputBairro.Anchor = AnchorStyles.None;
            inputBairro.BackColor = Color.WhiteSmoke;
            inputBairro.Enabled = false;
            inputBairro.ForeColor = Color.FromArgb(56, 56, 56);
            inputBairro.Location = new Point(141, 194);
            inputBairro.MaxLength = 100;
            inputBairro.Name = "inputBairro";
            inputBairro.Size = new Size(154, 23);
            inputBairro.TabIndex = 5;
            inputBairro.Tag = "Bairro";
            // 
            // inputLogradouro
            // 
            inputLogradouro.Anchor = AnchorStyles.None;
            inputLogradouro.BackColor = Color.WhiteSmoke;
            inputLogradouro.ForeColor = Color.FromArgb(56, 56, 56);
            inputLogradouro.Location = new Point(226, 125);
            inputLogradouro.MaxLength = 255;
            inputLogradouro.Name = "inputLogradouro";
            inputLogradouro.Size = new Size(154, 23);
            inputLogradouro.TabIndex = 2;
            inputLogradouro.Tag = "Logradouro";
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
            btnCadastrar.Location = new Point(398, 259);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(115, 35);
            btnCadastrar.TabIndex = 8;
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
            txtTitulo.Location = new Point(213, 25);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(337, 32);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Cadastrar Colaborador (2/2)";
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
            btnVoltar.Location = new Point(246, 259);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(115, 35);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnPesquisarCep
            // 
            btnPesquisarCep.Anchor = AnchorStyles.None;
            btnPesquisarCep.BackColor = Color.FromArgb(0, 133, 132);
            btnPesquisarCep.BackgroundImage = Properties.Resources.icon_search;
            btnPesquisarCep.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisarCep.Cursor = Cursors.Hand;
            btnPesquisarCep.FlatAppearance.BorderSize = 0;
            btnPesquisarCep.FlatStyle = FlatStyle.Flat;
            btnPesquisarCep.Location = new Point(181, 125);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(23, 22);
            btnPesquisarCep.TabIndex = 1;
            btnPesquisarCep.TabStop = false;
            btnPesquisarCep.UseVisualStyleBackColor = false;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // kryptonLabelCep
            // 
            kryptonLabelCep.Anchor = AnchorStyles.None;
            kryptonLabelCep.Location = new Point(104, 98);
            kryptonLabelCep.Name = "kryptonLabelCep";
            kryptonLabelCep.Size = new Size(47, 21);
            kryptonLabelCep.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCep.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCep.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCep.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCep.TabIndex = 0;
            kryptonLabelCep.Values.ExtraText = "*";
            kryptonLabelCep.Values.Text = "CEP";
            // 
            // kryptonLabelLogradouro
            // 
            kryptonLabelLogradouro.Anchor = AnchorStyles.None;
            kryptonLabelLogradouro.Location = new Point(226, 98);
            kryptonLabelLogradouro.Name = "kryptonLabelLogradouro";
            kryptonLabelLogradouro.Size = new Size(97, 21);
            kryptonLabelLogradouro.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelLogradouro.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelLogradouro.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelLogradouro.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelLogradouro.TabIndex = 1;
            kryptonLabelLogradouro.Values.ExtraText = "*";
            kryptonLabelLogradouro.Values.Text = "Logradouro";
            // 
            // kryptonLabelNumero
            // 
            kryptonLabelNumero.Anchor = AnchorStyles.None;
            kryptonLabelNumero.Location = new Point(398, 97);
            kryptonLabelNumero.Name = "kryptonLabelNumero";
            kryptonLabelNumero.Size = new Size(75, 21);
            kryptonLabelNumero.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNumero.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNumero.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNumero.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNumero.TabIndex = 2;
            kryptonLabelNumero.Values.ExtraText = "*";
            kryptonLabelNumero.Values.Text = "Número";
            // 
            // kryptonLabelComplemento
            // 
            kryptonLabelComplemento.Anchor = AnchorStyles.None;
            kryptonLabelComplemento.Location = new Point(497, 97);
            kryptonLabelComplemento.Name = "kryptonLabelComplemento";
            kryptonLabelComplemento.Size = new Size(100, 21);
            kryptonLabelComplemento.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelComplemento.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelComplemento.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelComplemento.TabIndex = 3;
            kryptonLabelComplemento.Values.Text = "Complemento";
            // 
            // kryptonLabelBairro
            // 
            kryptonLabelBairro.Anchor = AnchorStyles.None;
            kryptonLabelBairro.Location = new Point(141, 167);
            kryptonLabelBairro.Name = "kryptonLabelBairro";
            kryptonLabelBairro.Size = new Size(61, 21);
            kryptonLabelBairro.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelBairro.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelBairro.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelBairro.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelBairro.TabIndex = 4;
            kryptonLabelBairro.Values.ExtraText = "*";
            kryptonLabelBairro.Values.Text = "Bairro";
            // 
            // kryptonLabelCidade
            // 
            kryptonLabelCidade.Anchor = AnchorStyles.None;
            kryptonLabelCidade.Location = new Point(320, 167);
            kryptonLabelCidade.Name = "kryptonLabelCidade";
            kryptonLabelCidade.Size = new Size(66, 21);
            kryptonLabelCidade.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCidade.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCidade.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCidade.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCidade.TabIndex = 5;
            kryptonLabelCidade.Values.ExtraText = "*";
            kryptonLabelCidade.Values.Text = "Cidade";
            // 
            // kryptonLabelUf
            // 
            kryptonLabelUf.Anchor = AnchorStyles.None;
            kryptonLabelUf.Location = new Point(497, 167);
            kryptonLabelUf.Name = "kryptonLabelUf";
            kryptonLabelUf.Size = new Size(39, 21);
            kryptonLabelUf.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelUf.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUf.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelUf.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUf.TabIndex = 6;
            kryptonLabelUf.Values.ExtraText = "*";
            kryptonLabelUf.Values.Text = "UF";
            // 
            // CadColaboradorEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 101, 75);
            ClientSize = new Size(734, 341);
            Controls.Add(kryptonLabelUf);
            Controls.Add(kryptonLabelCidade);
            Controls.Add(kryptonLabelBairro);
            Controls.Add(kryptonLabelComplemento);
            Controls.Add(kryptonLabelNumero);
            Controls.Add(kryptonLabelLogradouro);
            Controls.Add(kryptonLabelCep);
            Controls.Add(btnPesquisarCep);
            Controls.Add(btnVoltar);
            Controls.Add(txtTitulo);
            Controls.Add(btnCadastrar);
            Controls.Add(inputCep);
            Controls.Add(inputNumero);
            Controls.Add(inputComplemento);
            Controls.Add(inputBoxUf);
            Controls.Add(inputCidade);
            Controls.Add(inputBairro);
            Controls.Add(inputLogradouro);
            ForeColor = Color.FromArgb(56, 56, 56);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CadColaboradorEndereco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Cadastrar Colaborador";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
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