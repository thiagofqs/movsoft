namespace MovSoft.Forms
{
    partial class CadFornecedor
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
            pnlMain = new Panel();
            kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            toggleButtonAtivo = new Controls.ToggleButton();
            kryptonLabelUf = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelCidade = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelBairro = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelComplemento = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelNumero = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelLogradouro = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelCep = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelCnpj = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelRazaoSocial = new Krypton.Toolkit.KryptonLabel();
            kryptonLabelNomeFantasia = new Krypton.Toolkit.KryptonLabel();
            btnPesquisarCep = new Button();
            inputNomeFantasia = new TextBox();
            inputCep = new MaskedTextBox();
            inputCnpj = new MaskedTextBox();
            inputNumero = new TextBox();
            inputComplemento = new TextBox();
            inputBoxUf = new ComboBox();
            btnCadastrar = new Button();
            inputRazaoSocial = new TextBox();
            txtTitulo = new Label();
            inputCidade = new TextBox();
            inputBairro = new TextBox();
            inputLogradouro = new TextBox();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.BackColor = Color.FromArgb(114, 101, 75);
            pnlMain.Controls.Add(kryptonLabelAtivo);
            pnlMain.Controls.Add(toggleButtonAtivo);
            pnlMain.Controls.Add(kryptonLabelUf);
            pnlMain.Controls.Add(kryptonLabelCidade);
            pnlMain.Controls.Add(kryptonLabelBairro);
            pnlMain.Controls.Add(kryptonLabelComplemento);
            pnlMain.Controls.Add(kryptonLabelNumero);
            pnlMain.Controls.Add(kryptonLabelLogradouro);
            pnlMain.Controls.Add(kryptonLabelCep);
            pnlMain.Controls.Add(kryptonLabelCnpj);
            pnlMain.Controls.Add(kryptonLabelRazaoSocial);
            pnlMain.Controls.Add(kryptonLabelNomeFantasia);
            pnlMain.Controls.Add(btnPesquisarCep);
            pnlMain.Controls.Add(inputNomeFantasia);
            pnlMain.Controls.Add(inputCep);
            pnlMain.Controls.Add(inputCnpj);
            pnlMain.Controls.Add(inputNumero);
            pnlMain.Controls.Add(inputComplemento);
            pnlMain.Controls.Add(inputBoxUf);
            pnlMain.Controls.Add(btnCadastrar);
            pnlMain.Controls.Add(inputRazaoSocial);
            pnlMain.Controls.Add(txtTitulo);
            pnlMain.Controls.Add(inputCidade);
            pnlMain.Controls.Add(inputBairro);
            pnlMain.Controls.Add(inputLogradouro);
            pnlMain.Location = new Point(103, 87);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(839, 455);
            pnlMain.TabIndex = 0;
            // 
            // kryptonLabelAtivo
            // 
            kryptonLabelAtivo.Anchor = AnchorStyles.None;
            kryptonLabelAtivo.Location = new Point(650, 260);
            kryptonLabelAtivo.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            kryptonLabelAtivo.Size = new Size(54, 26);
            kryptonLabelAtivo.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelAtivo.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelAtivo.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelAtivo.TabIndex = 10;
            kryptonLabelAtivo.Values.Text = "Ativo";
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
            toggleButtonAtivo.Location = new Point(650, 296);
            toggleButtonAtivo.Margin = new Padding(3, 4, 3, 4);
            toggleButtonAtivo.MinimumSize = new Size(51, 31);
            toggleButtonAtivo.Name = "toggleButtonAtivo";
            toggleButtonAtivo.OffBackColor = Color.Gray;
            toggleButtonAtivo.OffToggleColor = Color.Gainsboro;
            toggleButtonAtivo.OnBackColor = Color.FromArgb(0, 133, 132);
            toggleButtonAtivo.OnToggleColor = Color.WhiteSmoke;
            toggleButtonAtivo.Size = new Size(51, 31);
            toggleButtonAtivo.TabIndex = 11;
            toggleButtonAtivo.UseVisualStyleBackColor = false;
            // 
            // kryptonLabelUf
            // 
            kryptonLabelUf.Anchor = AnchorStyles.None;
            kryptonLabelUf.Location = new Point(525, 260);
            kryptonLabelUf.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelUf.Name = "kryptonLabelUf";
            kryptonLabelUf.Size = new Size(48, 26);
            kryptonLabelUf.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelUf.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUf.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelUf.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelUf.TabIndex = 9;
            kryptonLabelUf.Values.ExtraText = "*";
            kryptonLabelUf.Values.Text = "UF";
            // 
            // kryptonLabelCidade
            // 
            kryptonLabelCidade.Anchor = AnchorStyles.None;
            kryptonLabelCidade.Location = new Point(321, 260);
            kryptonLabelCidade.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCidade.Name = "kryptonLabelCidade";
            kryptonLabelCidade.Size = new Size(81, 26);
            kryptonLabelCidade.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCidade.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCidade.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCidade.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCidade.TabIndex = 8;
            kryptonLabelCidade.Values.ExtraText = "*";
            kryptonLabelCidade.Values.Text = "Cidade";
            // 
            // kryptonLabelBairro
            // 
            kryptonLabelBairro.Anchor = AnchorStyles.None;
            kryptonLabelBairro.Location = new Point(117, 260);
            kryptonLabelBairro.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelBairro.Name = "kryptonLabelBairro";
            kryptonLabelBairro.Size = new Size(75, 26);
            kryptonLabelBairro.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelBairro.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelBairro.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelBairro.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelBairro.TabIndex = 7;
            kryptonLabelBairro.Values.ExtraText = "*";
            kryptonLabelBairro.Values.Text = "Bairro";
            // 
            // kryptonLabelComplemento
            // 
            kryptonLabelComplemento.Anchor = AnchorStyles.None;
            kryptonLabelComplemento.Location = new Point(549, 181);
            kryptonLabelComplemento.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelComplemento.Name = "kryptonLabelComplemento";
            kryptonLabelComplemento.Size = new Size(123, 26);
            kryptonLabelComplemento.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelComplemento.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelComplemento.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelComplemento.TabIndex = 6;
            kryptonLabelComplemento.Values.Text = "Complemento";
            // 
            // kryptonLabelNumero
            // 
            kryptonLabelNumero.Anchor = AnchorStyles.None;
            kryptonLabelNumero.Location = new Point(434, 181);
            kryptonLabelNumero.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNumero.Name = "kryptonLabelNumero";
            kryptonLabelNumero.Size = new Size(92, 26);
            kryptonLabelNumero.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNumero.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNumero.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNumero.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNumero.TabIndex = 5;
            kryptonLabelNumero.Values.ExtraText = "*";
            kryptonLabelNumero.Values.Text = "Número";
            // 
            // kryptonLabelLogradouro
            // 
            kryptonLabelLogradouro.Anchor = AnchorStyles.None;
            kryptonLabelLogradouro.Location = new Point(238, 181);
            kryptonLabelLogradouro.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelLogradouro.Name = "kryptonLabelLogradouro";
            kryptonLabelLogradouro.Size = new Size(119, 26);
            kryptonLabelLogradouro.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelLogradouro.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelLogradouro.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelLogradouro.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelLogradouro.TabIndex = 4;
            kryptonLabelLogradouro.Values.ExtraText = "*";
            kryptonLabelLogradouro.Values.Text = "Logradouro";
            // 
            // kryptonLabelCep
            // 
            kryptonLabelCep.Anchor = AnchorStyles.None;
            kryptonLabelCep.Location = new Point(98, 181);
            kryptonLabelCep.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCep.Name = "kryptonLabelCep";
            kryptonLabelCep.Size = new Size(57, 26);
            kryptonLabelCep.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCep.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCep.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCep.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCep.TabIndex = 3;
            kryptonLabelCep.Values.ExtraText = "*";
            kryptonLabelCep.Values.Text = "CEP";
            // 
            // kryptonLabelCnpj
            // 
            kryptonLabelCnpj.Anchor = AnchorStyles.None;
            kryptonLabelCnpj.Location = new Point(547, 101);
            kryptonLabelCnpj.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelCnpj.Name = "kryptonLabelCnpj";
            kryptonLabelCnpj.Size = new Size(68, 26);
            kryptonLabelCnpj.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelCnpj.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCnpj.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelCnpj.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelCnpj.TabIndex = 2;
            kryptonLabelCnpj.Values.ExtraText = "*";
            kryptonLabelCnpj.Values.Text = "CNPJ";
            // 
            // kryptonLabelRazaoSocial
            // 
            kryptonLabelRazaoSocial.Anchor = AnchorStyles.None;
            kryptonLabelRazaoSocial.Location = new Point(351, 101);
            kryptonLabelRazaoSocial.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelRazaoSocial.Name = "kryptonLabelRazaoSocial";
            kryptonLabelRazaoSocial.Size = new Size(123, 26);
            kryptonLabelRazaoSocial.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelRazaoSocial.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelRazaoSocial.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelRazaoSocial.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelRazaoSocial.TabIndex = 1;
            kryptonLabelRazaoSocial.Values.ExtraText = "*";
            kryptonLabelRazaoSocial.Values.Text = "Razão social";
            // 
            // kryptonLabelNomeFantasia
            // 
            kryptonLabelNomeFantasia.Anchor = AnchorStyles.None;
            kryptonLabelNomeFantasia.Location = new Point(150, 101);
            kryptonLabelNomeFantasia.Margin = new Padding(3, 4, 3, 4);
            kryptonLabelNomeFantasia.Name = "kryptonLabelNomeFantasia";
            kryptonLabelNomeFantasia.Size = new Size(142, 26);
            kryptonLabelNomeFantasia.StateNormal.LongText.Color1 = Color.FromArgb(255, 51, 56);
            kryptonLabelNomeFantasia.StateNormal.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNomeFantasia.StateNormal.ShortText.Color1 = Color.WhiteSmoke;
            kryptonLabelNomeFantasia.StateNormal.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabelNomeFantasia.TabIndex = 0;
            kryptonLabelNomeFantasia.Values.ExtraText = "*";
            kryptonLabelNomeFantasia.Values.Text = "Nome fantasia";
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
            btnPesquisarCep.Location = new Point(186, 217);
            btnPesquisarCep.Margin = new Padding(3, 4, 3, 4);
            btnPesquisarCep.Name = "btnPesquisarCep";
            btnPesquisarCep.Size = new Size(26, 29);
            btnPesquisarCep.TabIndex = 4;
            btnPesquisarCep.TabStop = false;
            btnPesquisarCep.UseVisualStyleBackColor = false;
            btnPesquisarCep.Click += btnPesquisarCep_Click;
            // 
            // inputNomeFantasia
            // 
            inputNomeFantasia.Anchor = AnchorStyles.None;
            inputNomeFantasia.BackColor = Color.WhiteSmoke;
            inputNomeFantasia.ForeColor = Color.FromArgb(56, 56, 56);
            inputNomeFantasia.Location = new Point(150, 137);
            inputNomeFantasia.Margin = new Padding(3, 4, 3, 4);
            inputNomeFantasia.MaxLength = 100;
            inputNomeFantasia.Name = "inputNomeFantasia";
            inputNomeFantasia.Size = new Size(175, 27);
            inputNomeFantasia.TabIndex = 0;
            inputNomeFantasia.Tag = "Nome Fantasia";
            // 
            // inputCep
            // 
            inputCep.Anchor = AnchorStyles.None;
            inputCep.BackColor = Color.WhiteSmoke;
            inputCep.ForeColor = Color.FromArgb(56, 56, 56);
            inputCep.Location = new Point(98, 217);
            inputCep.Margin = new Padding(3, 4, 3, 4);
            inputCep.Mask = "00000-000";
            inputCep.Name = "inputCep";
            inputCep.PromptChar = ' ';
            inputCep.Size = new Size(114, 27);
            inputCep.TabIndex = 3;
            inputCep.Tag = "CEP";
            inputCep.KeyPress += inputCep_KeyPress;
            inputCep.Leave += inputCep_Leave;
            // 
            // inputCnpj
            // 
            inputCnpj.Anchor = AnchorStyles.None;
            inputCnpj.BackColor = Color.WhiteSmoke;
            inputCnpj.ForeColor = Color.FromArgb(56, 56, 56);
            inputCnpj.Location = new Point(547, 137);
            inputCnpj.Margin = new Padding(3, 4, 3, 4);
            inputCnpj.Mask = "00,000,000/0000-00";
            inputCnpj.Name = "inputCnpj";
            inputCnpj.PromptChar = ' ';
            inputCnpj.Size = new Size(125, 27);
            inputCnpj.TabIndex = 2;
            inputCnpj.Tag = "CNPJ";
            inputCnpj.TextAlign = HorizontalAlignment.Center;
            // 
            // inputNumero
            // 
            inputNumero.Anchor = AnchorStyles.None;
            inputNumero.BackColor = Color.WhiteSmoke;
            inputNumero.ForeColor = Color.FromArgb(56, 56, 56);
            inputNumero.Location = new Point(434, 217);
            inputNumero.Margin = new Padding(3, 4, 3, 4);
            inputNumero.MaxLength = 5;
            inputNumero.Name = "inputNumero";
            inputNumero.Size = new Size(86, 27);
            inputNumero.TabIndex = 6;
            inputNumero.Tag = "Número";
            // 
            // inputComplemento
            // 
            inputComplemento.Anchor = AnchorStyles.None;
            inputComplemento.BackColor = Color.WhiteSmoke;
            inputComplemento.ForeColor = Color.FromArgb(56, 56, 56);
            inputComplemento.Location = new Point(549, 217);
            inputComplemento.Margin = new Padding(3, 4, 3, 4);
            inputComplemento.MaxLength = 200;
            inputComplemento.Name = "inputComplemento";
            inputComplemento.Size = new Size(175, 27);
            inputComplemento.TabIndex = 7;
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
            inputBoxUf.Location = new Point(525, 296);
            inputBoxUf.Margin = new Padding(3, 4, 3, 4);
            inputBoxUf.Name = "inputBoxUf";
            inputBoxUf.Size = new Size(87, 28);
            inputBoxUf.TabIndex = 10;
            inputBoxUf.Tag = "UF";
            inputBoxUf.KeyPress += inputBoxUf_KeyPress;
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
            btnCadastrar.Location = new Point(353, 369);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(131, 47);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // inputRazaoSocial
            // 
            inputRazaoSocial.Anchor = AnchorStyles.None;
            inputRazaoSocial.BackColor = Color.WhiteSmoke;
            inputRazaoSocial.ForeColor = Color.FromArgb(56, 56, 56);
            inputRazaoSocial.Location = new Point(351, 137);
            inputRazaoSocial.Margin = new Padding(3, 4, 3, 4);
            inputRazaoSocial.MaxLength = 100;
            inputRazaoSocial.Name = "inputRazaoSocial";
            inputRazaoSocial.Size = new Size(175, 27);
            inputRazaoSocial.TabIndex = 1;
            inputRazaoSocial.Tag = "Razão Social";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.AutoSize = true;
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.ForeColor = Color.WhiteSmoke;
            txtTitulo.Location = new Point(265, 36);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(320, 41);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Cadastrar Fornecedor";
            // 
            // inputCidade
            // 
            inputCidade.Anchor = AnchorStyles.None;
            inputCidade.BackColor = Color.WhiteSmoke;
            inputCidade.Enabled = false;
            inputCidade.ForeColor = Color.FromArgb(56, 56, 56);
            inputCidade.Location = new Point(321, 296);
            inputCidade.Margin = new Padding(3, 4, 3, 4);
            inputCidade.MaxLength = 100;
            inputCidade.Name = "inputCidade";
            inputCidade.ReadOnly = true;
            inputCidade.Size = new Size(175, 27);
            inputCidade.TabIndex = 9;
            inputCidade.Tag = "Cidade";
            // 
            // inputBairro
            // 
            inputBairro.Anchor = AnchorStyles.None;
            inputBairro.BackColor = Color.WhiteSmoke;
            inputBairro.Enabled = false;
            inputBairro.ForeColor = Color.FromArgb(56, 56, 56);
            inputBairro.Location = new Point(117, 296);
            inputBairro.Margin = new Padding(3, 4, 3, 4);
            inputBairro.MaxLength = 100;
            inputBairro.Name = "inputBairro";
            inputBairro.ReadOnly = true;
            inputBairro.Size = new Size(175, 27);
            inputBairro.TabIndex = 8;
            inputBairro.Tag = "Bairro";
            // 
            // inputLogradouro
            // 
            inputLogradouro.Anchor = AnchorStyles.None;
            inputLogradouro.BackColor = Color.WhiteSmoke;
            inputLogradouro.ForeColor = Color.FromArgb(56, 56, 56);
            inputLogradouro.Location = new Point(238, 217);
            inputLogradouro.Margin = new Padding(3, 4, 3, 4);
            inputLogradouro.MaxLength = 255;
            inputLogradouro.Name = "inputLogradouro";
            inputLogradouro.Size = new Size(175, 27);
            inputLogradouro.TabIndex = 5;
            inputLogradouro.Tag = "Logradouro";
            // 
            // CadFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(1045, 619);
            Controls.Add(pnlMain);
            ForeColor = Color.FromArgb(56, 56, 56);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadFornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Cadastrar Fornecedor";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label txtTitulo;
        private MaskedTextBox inputCnpj;
        private Button btnCadastrar;
        private TextBox inputRazaoSocial;
        private MaskedTextBox inputCep;
        private TextBox inputNumero;
        private TextBox inputComplemento;
        private ComboBox inputBoxUf;
        private TextBox inputCidade;
        private TextBox inputBairro;
        private TextBox inputLogradouro;
        private TextBox inputNomeFantasia;
        private Button btnPesquisarCep;
        private Krypton.Toolkit.KryptonLabel kryptonLabelComplemento;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNumero;
        private Krypton.Toolkit.KryptonLabel kryptonLabelLogradouro;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCep;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCnpj;
        private Krypton.Toolkit.KryptonLabel kryptonLabelRazaoSocial;
        private Krypton.Toolkit.KryptonLabel kryptonLabelNomeFantasia;
        private Krypton.Toolkit.KryptonLabel kryptonLabelBairro;
        private Krypton.Toolkit.KryptonLabel kryptonLabelUf;
        private Krypton.Toolkit.KryptonLabel kryptonLabelCidade;
        private Controls.ToggleButton toggleButtonAtivo;
        private Krypton.Toolkit.KryptonLabel kryptonLabelAtivo;
    }
}