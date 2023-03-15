namespace MovSoft.Forms
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
            inputComplemento = new TextBox();
            inputBoxUf = new ComboBox();
            inputCidade = new TextBox();
            inputBairro = new TextBox();
            inputLogradouro = new TextBox();
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
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.None;
            btnVoltar.BackColor = Color.FromArgb(0, 133, 132);
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.WhiteSmoke;
            btnVoltar.Location = new Point(269, 360);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(131, 47);
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
            txtTitulo.Location = new Point(281, 48);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(337, 41);
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
            btnCadastrar.Location = new Point(442, 360);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 47);
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
            inputCep.Location = new Point(106, 181);
            inputCep.Margin = new Padding(3, 4, 3, 4);
            inputCep.Mask = "00000-000";
            inputCep.Name = "inputCep";
            inputCep.PromptChar = ' ';
            inputCep.Size = new Size(114, 27);
            inputCep.TabIndex = 0;
            inputCep.KeyPress += inputCep_KeyPress;
            inputCep.Leave += inputCep_Leave;
            // 
            // inputNumero
            // 
            inputNumero.Anchor = AnchorStyles.None;
            inputNumero.BackColor = Color.WhiteSmoke;
            inputNumero.ForeColor = Color.FromArgb(56, 56, 56);
            inputNumero.Location = new Point(442, 181);
            inputNumero.Margin = new Padding(3, 4, 3, 4);
            inputNumero.MaxLength = 5;
            inputNumero.Name = "inputNumero";
            inputNumero.Size = new Size(86, 27);
            inputNumero.TabIndex = 3;
            // 
            // inputComplemento
            // 
            inputComplemento.Anchor = AnchorStyles.None;
            inputComplemento.BackColor = Color.WhiteSmoke;
            inputComplemento.ForeColor = Color.FromArgb(56, 56, 56);
            inputComplemento.Location = new Point(557, 181);
            inputComplemento.Margin = new Padding(3, 4, 3, 4);
            inputComplemento.MaxLength = 200;
            inputComplemento.Name = "inputComplemento";
            inputComplemento.Size = new Size(175, 27);
            inputComplemento.TabIndex = 4;
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
            inputBoxUf.Location = new Point(557, 273);
            inputBoxUf.Margin = new Padding(3, 4, 3, 4);
            inputBoxUf.Name = "inputBoxUf";
            inputBoxUf.Size = new Size(87, 28);
            inputBoxUf.TabIndex = 7;
            inputBoxUf.KeyPress += inputBoxUf_KeyPress;
            // 
            // inputCidade
            // 
            inputCidade.Anchor = AnchorStyles.None;
            inputCidade.BackColor = Color.WhiteSmoke;
            inputCidade.Enabled = false;
            inputCidade.ForeColor = Color.FromArgb(56, 56, 56);
            inputCidade.Location = new Point(353, 273);
            inputCidade.Margin = new Padding(3, 4, 3, 4);
            inputCidade.MaxLength = 100;
            inputCidade.Name = "inputCidade";
            inputCidade.ReadOnly = true;
            inputCidade.Size = new Size(175, 27);
            inputCidade.TabIndex = 6;
            // 
            // inputBairro
            // 
            inputBairro.Anchor = AnchorStyles.None;
            inputBairro.BackColor = Color.WhiteSmoke;
            inputBairro.Enabled = false;
            inputBairro.ForeColor = Color.FromArgb(56, 56, 56);
            inputBairro.Location = new Point(149, 273);
            inputBairro.Margin = new Padding(3, 4, 3, 4);
            inputBairro.MaxLength = 100;
            inputBairro.Name = "inputBairro";
            inputBairro.ReadOnly = true;
            inputBairro.Size = new Size(175, 27);
            inputBairro.TabIndex = 5;
            // 
            // inputLogradouro
            // 
            inputLogradouro.Anchor = AnchorStyles.None;
            inputLogradouro.BackColor = Color.WhiteSmoke;
            inputLogradouro.ForeColor = Color.FromArgb(56, 56, 56);
            inputLogradouro.Location = new Point(246, 181);
            inputLogradouro.Margin = new Padding(3, 4, 3, 4);
            inputLogradouro.MaxLength = 255;
            inputLogradouro.Name = "inputLogradouro";
            inputLogradouro.Size = new Size(175, 27);
            inputLogradouro.TabIndex = 2;
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
            btnPesquisarCep.Location = new Point(194, 181);
            btnPesquisarCep.Margin = new Padding(3, 4, 3, 4);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(26, 29);
            btnPesquisarCep.TabIndex = 1;
            btnPesquisarCep.TabStop = false;
            btnPesquisarCep.UseVisualStyleBackColor = false;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // kryptonLabelCep
            // 
            kryptonLabelCep.Anchor = AnchorStyles.None;
            kryptonLabelCep.Location = new Point(106, 145);
            kryptonLabelCep.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCep.Name = "kryptonLabelCep";
            kryptonLabelCep.Size = new Size(57, 26);
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
            kryptonLabelLogradouro.Location = new Point(246, 145);
            kryptonLabelLogradouro.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelLogradouro.Name = "kryptonLabelLogradouro";
            kryptonLabelLogradouro.Size = new Size(119, 26);
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
            kryptonLabelNumero.Location = new Point(443, 145);
            kryptonLabelNumero.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNumero.Name = "kryptonLabelNumero";
            kryptonLabelNumero.Size = new Size(92, 26);
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
            kryptonLabelComplemento.Location = new Point(555, 145);
            kryptonLabelComplemento.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelComplemento.Name = "kryptonLabelComplemento";
            kryptonLabelComplemento.Size = new Size(123, 26);
            kryptonLabelComplemento.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelComplemento.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelComplemento.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelComplemento.TabIndex = 3;
            kryptonLabelComplemento.Values.Text = "Complemento";
            // 
            // kryptonLabelBairro
            // 
            kryptonLabelBairro.Anchor = AnchorStyles.None;
            kryptonLabelBairro.Location = new Point(149, 237);
            kryptonLabelBairro.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelBairro.Name = "kryptonLabelBairro";
            kryptonLabelBairro.Size = new Size(75, 26);
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
            kryptonLabelCidade.Location = new Point(353, 237);
            kryptonLabelCidade.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCidade.Name = "kryptonLabelCidade";
            kryptonLabelCidade.Size = new Size(81, 26);
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
            kryptonLabelUf.Location = new Point(555, 237);
            kryptonLabelUf.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelUf.Name = "kryptonLabelUf";
            kryptonLabelUf.Size = new Size(48, 26);
            kryptonLabelUf.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelUf.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUf.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelUf.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUf.TabIndex = 6;
            kryptonLabelUf.Values.ExtraText = "*";
            kryptonLabelUf.Values.Text = "UF";
            // 
            // CadClienteEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(114, 101, 75);
            ClientSize = new Size(839, 455);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox inputComplemento;
        private ComboBox inputBoxUf;
        private TextBox inputCidade;
        private TextBox inputBairro;
        private TextBox inputLogradouro;
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