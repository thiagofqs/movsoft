namespace MovSoft.Forms
{
    partial class identificação
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.inputPesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnUltimosPedidos = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnAbrirCadastroCliente = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.btnIdentificacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(107, 83);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(725, 299);
            this.dataGridView.TabIndex = 4;
            // 
            // inputPesquisa
            // 
            this.inputPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPesquisa.Location = new System.Drawing.Point(121, 44);
            this.inputPesquisa.Name = "inputPesquisa";
            this.inputPesquisa.Size = new System.Drawing.Size(453, 23);
            this.inputPesquisa.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(107, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(725, 45);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.Location = new System.Drawing.Point(690, 43);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 24);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnPesquisar.BackgroundImage = global::MovSoft.Properties.Resources.icon_search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(550, 45);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(23, 22);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnUltimosPedidos
            // 
            this.btnUltimosPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUltimosPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnUltimosPedidos.FlatAppearance.BorderSize = 0;
            this.btnUltimosPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimosPedidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUltimosPedidos.Location = new System.Drawing.Point(124, 388);
            this.btnUltimosPedidos.Name = "btnUltimosPedidos";
            this.btnUltimosPedidos.Size = new System.Drawing.Size(130, 24);
            this.btnUltimosPedidos.TabIndex = 5;
            this.btnUltimosPedidos.Text = "Ultimos Pedidos";
            this.btnUltimosPedidos.UseVisualStyleBackColor = false;
            this.btnUltimosPedidos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(461, 388);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(124, 24);
            this.btnCadastrarCliente.TabIndex = 7;
            this.btnCadastrarCliente.Text = "Cadastrar CLIENTE";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            // 
            // btnAbrirCadastroCliente
            // 
            this.btnAbrirCadastroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnAbrirCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnAbrirCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCadastroCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirCadastroCliente.Location = new System.Drawing.Point(279, 388);
            this.btnAbrirCadastroCliente.Name = "btnAbrirCadastroCliente";
            this.btnAbrirCadastroCliente.Size = new System.Drawing.Size(155, 24);
            this.btnAbrirCadastroCliente.TabIndex = 6;
            this.btnAbrirCadastroCliente.Text = "Abrir Cadastro CLIENTE";
            this.btnAbrirCadastroCliente.UseVisualStyleBackColor = false;
            this.btnAbrirCadastroCliente.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProdutos.Location = new System.Drawing.Point(236, 428);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(100, 24);
            this.btnProdutos.TabIndex = 9;
            this.btnProdutos.Text = "2 - Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPagamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnPagamentos.FlatAppearance.BorderSize = 0;
            this.btnPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamentos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPagamentos.Location = new System.Drawing.Point(347, 428);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(96, 24);
            this.btnPagamentos.TabIndex = 10;
            this.btnPagamentos.Text = "3 - Pagamento";
            this.btnPagamentos.UseVisualStyleBackColor = false;
            // 
            // btnIdentificacao
            // 
            this.btnIdentificacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIdentificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnIdentificacao.FlatAppearance.BorderSize = 0;
            this.btnIdentificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentificacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIdentificacao.Location = new System.Drawing.Point(124, 428);
            this.btnIdentificacao.Name = "btnIdentificacao";
            this.btnIdentificacao.Size = new System.Drawing.Size(100, 24);
            this.btnIdentificacao.TabIndex = 8;
            this.btnIdentificacao.Text = "1 - Identificação";
            this.btnIdentificacao.UseVisualStyleBackColor = false;
            // 
            // identificação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(914, 464);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.btnIdentificacao);
            this.Controls.Add(this.btnAbrirCadastroCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnUltimosPedidos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.inputPesquisa);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView);
            this.Name = "identificação";
            this.Text = "Identificação";
            this.Load += new System.EventHandler(this.tela1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private TextBox inputPesquisa;
        private DataGridView dataGridView2;
        private Button btnNovo;
        private Button btnPesquisar;
        private Button btnUltimosPedidos;
        private Button btnCadastrarCliente;
        private Button btnAbrirCadastroCliente;
        private Button btnProdutos;
        private Button btnPagamentos;
        private Button btnIdentificacao;
    }
}