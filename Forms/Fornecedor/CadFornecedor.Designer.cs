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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.kryptonLabelAtivo = new Krypton.Toolkit.KryptonLabel();
            this.toggleButtonAtivo = new MovSoft.Controls.ToggleButton();
            this.kryptonLabelUf = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCidade = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelBairro = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelComplemento = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelNumero = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelLogradouro = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCep = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelCnpj = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelRazaoSocial = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabelNomeFantasia = new Krypton.Toolkit.KryptonLabel();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.inputNomeFantasia = new System.Windows.Forms.TextBox();
            this.inputCep = new System.Windows.Forms.MaskedTextBox();
            this.inputCnpj = new System.Windows.Forms.MaskedTextBox();
            this.inputNumero = new System.Windows.Forms.TextBox();
            this.inputComplemento = new System.Windows.Forms.TextBox();
            this.inputBoxUf = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.inputRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.inputCidade = new System.Windows.Forms.TextBox();
            this.inputBairro = new System.Windows.Forms.TextBox();
            this.inputLogradouro = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.pnlMain.Controls.Add(this.kryptonLabelAtivo);
            this.pnlMain.Controls.Add(this.toggleButtonAtivo);
            this.pnlMain.Controls.Add(this.kryptonLabelUf);
            this.pnlMain.Controls.Add(this.kryptonLabelCidade);
            this.pnlMain.Controls.Add(this.kryptonLabelBairro);
            this.pnlMain.Controls.Add(this.kryptonLabelComplemento);
            this.pnlMain.Controls.Add(this.kryptonLabelNumero);
            this.pnlMain.Controls.Add(this.kryptonLabelLogradouro);
            this.pnlMain.Controls.Add(this.kryptonLabelCep);
            this.pnlMain.Controls.Add(this.kryptonLabelCnpj);
            this.pnlMain.Controls.Add(this.kryptonLabelRazaoSocial);
            this.pnlMain.Controls.Add(this.kryptonLabelNomeFantasia);
            this.pnlMain.Controls.Add(this.btnPesquisarCep);
            this.pnlMain.Controls.Add(this.inputNomeFantasia);
            this.pnlMain.Controls.Add(this.inputCep);
            this.pnlMain.Controls.Add(this.inputCnpj);
            this.pnlMain.Controls.Add(this.inputNumero);
            this.pnlMain.Controls.Add(this.inputComplemento);
            this.pnlMain.Controls.Add(this.inputBoxUf);
            this.pnlMain.Controls.Add(this.btnCadastrar);
            this.pnlMain.Controls.Add(this.inputRazaoSocial);
            this.pnlMain.Controls.Add(this.txtTitulo);
            this.pnlMain.Controls.Add(this.inputCidade);
            this.pnlMain.Controls.Add(this.inputBairro);
            this.pnlMain.Controls.Add(this.inputLogradouro);
            this.pnlMain.Location = new System.Drawing.Point(90, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(734, 341);
            this.pnlMain.TabIndex = 0;
            // 
            // kryptonLabelAtivo
            // 
            this.kryptonLabelAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelAtivo.Location = new System.Drawing.Point(569, 195);
            this.kryptonLabelAtivo.Name = "kryptonLabelAtivo";
            this.kryptonLabelAtivo.Size = new System.Drawing.Size(45, 21);
            this.kryptonLabelAtivo.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelAtivo.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelAtivo.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelAtivo.TabIndex = 10;
            this.kryptonLabelAtivo.Values.Text = "Ativo";
            // 
            // toggleButtonAtivo
            // 
            this.toggleButtonAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toggleButtonAtivo.AutoSize = true;
            this.toggleButtonAtivo.BackColor = System.Drawing.Color.Transparent;
            this.toggleButtonAtivo.Checked = true;
            this.toggleButtonAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonAtivo.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButtonAtivo.Location = new System.Drawing.Point(569, 222);
            this.toggleButtonAtivo.MinimumSize = new System.Drawing.Size(45, 23);
            this.toggleButtonAtivo.Name = "toggleButtonAtivo";
            this.toggleButtonAtivo.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonAtivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonAtivo.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButtonAtivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonAtivo.Size = new System.Drawing.Size(45, 23);
            this.toggleButtonAtivo.TabIndex = 11;
            this.toggleButtonAtivo.UseVisualStyleBackColor = false;
            this.toggleButtonAtivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toggleButton_KeyPress);
            // 
            // kryptonLabelUf
            // 
            this.kryptonLabelUf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelUf.Location = new System.Drawing.Point(459, 195);
            this.kryptonLabelUf.Name = "kryptonLabelUf";
            this.kryptonLabelUf.Size = new System.Drawing.Size(39, 21);
            this.kryptonLabelUf.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelUf.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelUf.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelUf.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelUf.TabIndex = 9;
            this.kryptonLabelUf.Values.ExtraText = "*";
            this.kryptonLabelUf.Values.Text = "UF";
            // 
            // kryptonLabelCidade
            // 
            this.kryptonLabelCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelCidade.Location = new System.Drawing.Point(281, 195);
            this.kryptonLabelCidade.Name = "kryptonLabelCidade";
            this.kryptonLabelCidade.Size = new System.Drawing.Size(66, 21);
            this.kryptonLabelCidade.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCidade.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCidade.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCidade.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCidade.TabIndex = 8;
            this.kryptonLabelCidade.Values.ExtraText = "*";
            this.kryptonLabelCidade.Values.Text = "Cidade";
            // 
            // kryptonLabelBairro
            // 
            this.kryptonLabelBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelBairro.Location = new System.Drawing.Point(102, 195);
            this.kryptonLabelBairro.Name = "kryptonLabelBairro";
            this.kryptonLabelBairro.Size = new System.Drawing.Size(61, 21);
            this.kryptonLabelBairro.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelBairro.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelBairro.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelBairro.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelBairro.TabIndex = 7;
            this.kryptonLabelBairro.Values.ExtraText = "*";
            this.kryptonLabelBairro.Values.Text = "Bairro";
            // 
            // kryptonLabelComplemento
            // 
            this.kryptonLabelComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelComplemento.Location = new System.Drawing.Point(480, 136);
            this.kryptonLabelComplemento.Name = "kryptonLabelComplemento";
            this.kryptonLabelComplemento.Size = new System.Drawing.Size(100, 21);
            this.kryptonLabelComplemento.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelComplemento.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelComplemento.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelComplemento.TabIndex = 6;
            this.kryptonLabelComplemento.Values.Text = "Complemento";
            // 
            // kryptonLabelNumero
            // 
            this.kryptonLabelNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelNumero.Location = new System.Drawing.Point(380, 136);
            this.kryptonLabelNumero.Name = "kryptonLabelNumero";
            this.kryptonLabelNumero.Size = new System.Drawing.Size(75, 21);
            this.kryptonLabelNumero.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelNumero.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNumero.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelNumero.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNumero.TabIndex = 5;
            this.kryptonLabelNumero.Values.ExtraText = "*";
            this.kryptonLabelNumero.Values.Text = "Número";
            // 
            // kryptonLabelLogradouro
            // 
            this.kryptonLabelLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelLogradouro.Location = new System.Drawing.Point(208, 136);
            this.kryptonLabelLogradouro.Name = "kryptonLabelLogradouro";
            this.kryptonLabelLogradouro.Size = new System.Drawing.Size(97, 21);
            this.kryptonLabelLogradouro.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelLogradouro.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelLogradouro.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelLogradouro.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelLogradouro.TabIndex = 4;
            this.kryptonLabelLogradouro.Values.ExtraText = "*";
            this.kryptonLabelLogradouro.Values.Text = "Logradouro";
            // 
            // kryptonLabelCep
            // 
            this.kryptonLabelCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelCep.Location = new System.Drawing.Point(86, 136);
            this.kryptonLabelCep.Name = "kryptonLabelCep";
            this.kryptonLabelCep.Size = new System.Drawing.Size(47, 21);
            this.kryptonLabelCep.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCep.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCep.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCep.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCep.TabIndex = 3;
            this.kryptonLabelCep.Values.ExtraText = "*";
            this.kryptonLabelCep.Values.Text = "CEP";
            // 
            // kryptonLabelCnpj
            // 
            this.kryptonLabelCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelCnpj.Location = new System.Drawing.Point(479, 76);
            this.kryptonLabelCnpj.Name = "kryptonLabelCnpj";
            this.kryptonLabelCnpj.Size = new System.Drawing.Size(56, 21);
            this.kryptonLabelCnpj.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelCnpj.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCnpj.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelCnpj.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelCnpj.TabIndex = 2;
            this.kryptonLabelCnpj.Values.ExtraText = "*";
            this.kryptonLabelCnpj.Values.Text = "CNPJ";
            // 
            // kryptonLabelRazaoSocial
            // 
            this.kryptonLabelRazaoSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelRazaoSocial.Location = new System.Drawing.Point(307, 76);
            this.kryptonLabelRazaoSocial.Name = "kryptonLabelRazaoSocial";
            this.kryptonLabelRazaoSocial.Size = new System.Drawing.Size(100, 21);
            this.kryptonLabelRazaoSocial.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelRazaoSocial.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelRazaoSocial.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelRazaoSocial.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelRazaoSocial.TabIndex = 1;
            this.kryptonLabelRazaoSocial.Values.ExtraText = "*";
            this.kryptonLabelRazaoSocial.Values.Text = "Razão social";
            // 
            // kryptonLabelNomeFantasia
            // 
            this.kryptonLabelNomeFantasia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kryptonLabelNomeFantasia.Location = new System.Drawing.Point(131, 76);
            this.kryptonLabelNomeFantasia.Name = "kryptonLabelNomeFantasia";
            this.kryptonLabelNomeFantasia.Size = new System.Drawing.Size(115, 21);
            this.kryptonLabelNomeFantasia.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.kryptonLabelNomeFantasia.StateNormal.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNomeFantasia.StateNormal.ShortText.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonLabelNomeFantasia.StateNormal.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabelNomeFantasia.TabIndex = 0;
            this.kryptonLabelNomeFantasia.Values.ExtraText = "*";
            this.kryptonLabelNomeFantasia.Values.Text = "Nome fantasia";
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
            this.btnPesquisarCep.Location = new System.Drawing.Point(163, 163);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(23, 22);
            this.btnPesquisarCep.TabIndex = 4;
            this.btnPesquisarCep.TabStop = false;
            this.btnPesquisarCep.UseVisualStyleBackColor = false;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // inputNomeFantasia
            // 
            this.inputNomeFantasia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNomeFantasia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNomeFantasia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeFantasia.Location = new System.Drawing.Point(131, 103);
            this.inputNomeFantasia.MaxLength = 100;
            this.inputNomeFantasia.Name = "inputNomeFantasia";
            this.inputNomeFantasia.Size = new System.Drawing.Size(154, 23);
            this.inputNomeFantasia.TabIndex = 0;
            this.inputNomeFantasia.Tag = "Nome Fantasia";
            // 
            // inputCep
            // 
            this.inputCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCep.Location = new System.Drawing.Point(86, 163);
            this.inputCep.Mask = "00000-000";
            this.inputCep.Name = "inputCep";
            this.inputCep.PromptChar = ' ';
            this.inputCep.Size = new System.Drawing.Size(100, 23);
            this.inputCep.TabIndex = 3;
            this.inputCep.Tag = "CEP";
            this.inputCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputCep_KeyPress);
            // 
            // inputCnpj
            // 
            this.inputCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCnpj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCnpj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCnpj.Location = new System.Drawing.Point(479, 103);
            this.inputCnpj.Mask = "00,000,000/0000-00";
            this.inputCnpj.Name = "inputCnpj";
            this.inputCnpj.PromptChar = ' ';
            this.inputCnpj.Size = new System.Drawing.Size(110, 23);
            this.inputCnpj.TabIndex = 2;
            this.inputCnpj.Tag = "CNPJ";
            this.inputCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputNumero
            // 
            this.inputNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNumero.Location = new System.Drawing.Point(380, 163);
            this.inputNumero.MaxLength = 5;
            this.inputNumero.Name = "inputNumero";
            this.inputNumero.Size = new System.Drawing.Size(76, 23);
            this.inputNumero.TabIndex = 6;
            this.inputNumero.Tag = "Número";
            // 
            // inputComplemento
            // 
            this.inputComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputComplemento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputComplemento.Location = new System.Drawing.Point(480, 163);
            this.inputComplemento.MaxLength = 200;
            this.inputComplemento.Name = "inputComplemento";
            this.inputComplemento.Size = new System.Drawing.Size(154, 23);
            this.inputComplemento.TabIndex = 7;
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
            this.inputBoxUf.Location = new System.Drawing.Point(459, 222);
            this.inputBoxUf.Name = "inputBoxUf";
            this.inputBoxUf.Size = new System.Drawing.Size(77, 23);
            this.inputBoxUf.TabIndex = 10;
            this.inputBoxUf.Tag = "UF";
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
            this.btnCadastrar.Location = new System.Drawing.Point(309, 277);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 35);
            this.btnCadastrar.TabIndex = 12;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // inputRazaoSocial
            // 
            this.inputRazaoSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputRazaoSocial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputRazaoSocial.Location = new System.Drawing.Point(307, 103);
            this.inputRazaoSocial.MaxLength = 100;
            this.inputRazaoSocial.Name = "inputRazaoSocial";
            this.inputRazaoSocial.Size = new System.Drawing.Size(154, 23);
            this.inputRazaoSocial.TabIndex = 1;
            this.inputRazaoSocial.Tag = "Razão Social";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitulo.Location = new System.Drawing.Point(232, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(260, 32);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "Cadastrar Fornecedor";
            // 
            // inputCidade
            // 
            this.inputCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputCidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputCidade.Enabled = false;
            this.inputCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputCidade.Location = new System.Drawing.Point(281, 222);
            this.inputCidade.MaxLength = 100;
            this.inputCidade.Name = "inputCidade";
            this.inputCidade.ReadOnly = true;
            this.inputCidade.Size = new System.Drawing.Size(154, 23);
            this.inputCidade.TabIndex = 9;
            this.inputCidade.Tag = "Cidade";
            // 
            // inputBairro
            // 
            this.inputBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputBairro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputBairro.Enabled = false;
            this.inputBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputBairro.Location = new System.Drawing.Point(102, 222);
            this.inputBairro.MaxLength = 100;
            this.inputBairro.Name = "inputBairro";
            this.inputBairro.ReadOnly = true;
            this.inputBairro.Size = new System.Drawing.Size(154, 23);
            this.inputBairro.TabIndex = 8;
            this.inputBairro.Tag = "Bairro";
            // 
            // inputLogradouro
            // 
            this.inputLogradouro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputLogradouro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputLogradouro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputLogradouro.Location = new System.Drawing.Point(208, 163);
            this.inputLogradouro.MaxLength = 255;
            this.inputLogradouro.Name = "inputLogradouro";
            this.inputLogradouro.Size = new System.Drawing.Size(154, 23);
            this.inputLogradouro.TabIndex = 5;
            this.inputLogradouro.Tag = "Logradouro";
            // 
            // CadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(914, 464);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Name = "CadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Cadastrar Fornecedor";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

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