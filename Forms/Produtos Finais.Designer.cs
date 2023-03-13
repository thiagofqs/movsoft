namespace MovSoft.Forms
{
    partial class Produtos_Finais
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
            this.tabControlGeral = new System.Windows.Forms.TabControl();
            this.Geral = new System.Windows.Forms.TabPage();
            this.tabControlPreco = new System.Windows.Forms.TabPage();
            this.dataGridViewProdutosFinais = new System.Windows.Forms.DataGridView();
            this.inputNomeComponente = new System.Windows.Forms.TextBox();
            this.txtObg1 = new System.Windows.Forms.Label();
            this.txtNomeComponentes = new System.Windows.Forms.Label();
            this.toggleButtonAtivoComponentes = new MovSoft.Controls.ToggleButton();
            this.txtAtivo = new System.Windows.Forms.Label();
            this.toggleButton1 = new MovSoft.Controls.ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleButton2 = new MovSoft.Controls.ToggleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtComtroleDeEstoque = new System.Windows.Forms.Label();
            this.toggleButton3 = new MovSoft.Controls.ToggleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeGeral = new System.Windows.Forms.Label();
            this.tabControlGeral.SuspendLayout();
            this.Geral.SuspendLayout();
            this.tabControlPreco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosFinais)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGeral
            // 
            this.tabControlGeral.Controls.Add(this.Geral);
            this.tabControlGeral.Controls.Add(this.tabControlPreco);
            this.tabControlGeral.Location = new System.Drawing.Point(198, 36);
            this.tabControlGeral.Name = "tabControlGeral";
            this.tabControlGeral.SelectedIndex = 0;
            this.tabControlGeral.Size = new System.Drawing.Size(561, 162);
            this.tabControlGeral.TabIndex = 0;
            // 
            // Geral
            // 
            this.Geral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.Geral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Geral.Controls.Add(this.toggleButton2);
            this.Geral.Controls.Add(this.label4);
            this.Geral.Controls.Add(this.textBox2);
            this.Geral.Controls.Add(this.label5);
            this.Geral.Controls.Add(this.TxtComtroleDeEstoque);
            this.Geral.Controls.Add(this.toggleButton3);
            this.Geral.Controls.Add(this.label7);
            this.Geral.Controls.Add(this.textBox3);
            this.Geral.Controls.Add(this.label8);
            this.Geral.Controls.Add(this.txtNomeGeral);
            this.Geral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.Geral.Location = new System.Drawing.Point(4, 24);
            this.Geral.Name = "Geral";
            this.Geral.Padding = new System.Windows.Forms.Padding(3);
            this.Geral.Size = new System.Drawing.Size(553, 134);
            this.Geral.TabIndex = 0;
            this.Geral.Text = "Geral";
            // 
            // tabControlPreco
            // 
            this.tabControlPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(101)))), ((int)(((byte)(75)))));
            this.tabControlPreco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabControlPreco.Controls.Add(this.toggleButton1);
            this.tabControlPreco.Controls.Add(this.label1);
            this.tabControlPreco.Controls.Add(this.textBox1);
            this.tabControlPreco.Controls.Add(this.label2);
            this.tabControlPreco.Controls.Add(this.label3);
            this.tabControlPreco.Controls.Add(this.toggleButtonAtivoComponentes);
            this.tabControlPreco.Controls.Add(this.txtAtivo);
            this.tabControlPreco.Controls.Add(this.inputNomeComponente);
            this.tabControlPreco.Controls.Add(this.txtObg1);
            this.tabControlPreco.Controls.Add(this.txtNomeComponentes);
            this.tabControlPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.tabControlPreco.Location = new System.Drawing.Point(4, 24);
            this.tabControlPreco.Name = "tabControlPreco";
            this.tabControlPreco.Padding = new System.Windows.Forms.Padding(3);
            this.tabControlPreco.Size = new System.Drawing.Size(553, 134);
            this.tabControlPreco.TabIndex = 1;
            this.tabControlPreco.Text = "Preço";
            this.tabControlPreco.Click += new System.EventHandler(this.tabControlPreco_Click);
            // 
            // dataGridViewProdutosFinais
            // 
            this.dataGridViewProdutosFinais.AllowUserToAddRows = false;
            this.dataGridViewProdutosFinais.AllowUserToDeleteRows = false;
            this.dataGridViewProdutosFinais.AllowUserToResizeColumns = false;
            this.dataGridViewProdutosFinais.AllowUserToResizeRows = false;
            this.dataGridViewProdutosFinais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutosFinais.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProdutosFinais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProdutosFinais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewProdutosFinais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProdutosFinais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosFinais.EnableHeadersVisualStyles = false;
            this.dataGridViewProdutosFinais.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dataGridViewProdutosFinais.Location = new System.Drawing.Point(198, 272);
            this.dataGridViewProdutosFinais.Name = "dataGridViewProdutosFinais";
            this.dataGridViewProdutosFinais.ReadOnly = true;
            this.dataGridViewProdutosFinais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProdutosFinais.RowHeadersVisible = false;
            this.dataGridViewProdutosFinais.RowTemplate.Height = 25;
            this.dataGridViewProdutosFinais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutosFinais.ShowCellErrors = false;
            this.dataGridViewProdutosFinais.ShowCellToolTips = false;
            this.dataGridViewProdutosFinais.ShowEditingIcon = false;
            this.dataGridViewProdutosFinais.ShowRowErrors = false;
            this.dataGridViewProdutosFinais.Size = new System.Drawing.Size(430, 142);
            this.dataGridViewProdutosFinais.TabIndex = 1;
            // 
            // inputNomeComponente
            // 
            this.inputNomeComponente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputNomeComponente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputNomeComponente.Location = new System.Drawing.Point(28, 33);
            this.inputNomeComponente.Name = "inputNomeComponente";
            this.inputNomeComponente.Size = new System.Drawing.Size(179, 23);
            this.inputNomeComponente.TabIndex = 12;
            // 
            // txtObg1
            // 
            this.txtObg1.AutoSize = true;
            this.txtObg1.BackColor = System.Drawing.Color.Transparent;
            this.txtObg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtObg1.Location = new System.Drawing.Point(79, 15);
            this.txtObg1.Name = "txtObg1";
            this.txtObg1.Size = new System.Drawing.Size(12, 15);
            this.txtObg1.TabIndex = 14;
            this.txtObg1.Text = "*";
            // 
            // txtNomeComponentes
            // 
            this.txtNomeComponentes.AutoSize = true;
            this.txtNomeComponentes.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeComponentes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeComponentes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeComponentes.Location = new System.Drawing.Point(28, 13);
            this.txtNomeComponentes.Name = "txtNomeComponentes";
            this.txtNomeComponentes.Size = new System.Drawing.Size(45, 17);
            this.txtNomeComponentes.TabIndex = 13;
            this.txtNomeComponentes.Text = "Nome";
            // 
            // toggleButtonAtivoComponentes
            // 
            this.toggleButtonAtivoComponentes.AutoSize = true;
            this.toggleButtonAtivoComponentes.Checked = true;
            this.toggleButtonAtivoComponentes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButtonAtivoComponentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButtonAtivoComponentes.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButtonAtivoComponentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toggleButtonAtivoComponentes.Location = new System.Drawing.Point(330, 34);
            this.toggleButtonAtivoComponentes.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonAtivoComponentes.Name = "toggleButtonAtivoComponentes";
            this.toggleButtonAtivoComponentes.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonAtivoComponentes.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonAtivoComponentes.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButtonAtivoComponentes.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonAtivoComponentes.Size = new System.Drawing.Size(45, 22);
            this.toggleButtonAtivoComponentes.TabIndex = 16;
            this.toggleButtonAtivoComponentes.UseVisualStyleBackColor = true;
            // 
            // txtAtivo
            // 
            this.txtAtivo.AutoSize = true;
            this.txtAtivo.BackColor = System.Drawing.Color.Transparent;
            this.txtAtivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAtivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAtivo.Location = new System.Drawing.Point(330, 14);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.Size = new System.Drawing.Size(41, 17);
            this.txtAtivo.TabIndex = 15;
            this.txtAtivo.Text = "Ativo";
            this.txtAtivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // toggleButton1
            // 
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Checked = true;
            this.toggleButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton1.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toggleButton1.Location = new System.Drawing.Point(330, 89);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton1.Size = new System.Drawing.Size(45, 22);
            this.toggleButton1.TabIndex = 21;
            this.toggleButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(330, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ativo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox1.Location = new System.Drawing.Point(28, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 23);
            this.textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(79, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome";
            // 
            // toggleButton2
            // 
            this.toggleButton2.AutoSize = true;
            this.toggleButton2.Checked = true;
            this.toggleButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton2.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toggleButton2.Location = new System.Drawing.Point(332, 87);
            this.toggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton2.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButton2.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton2.Size = new System.Drawing.Size(45, 22);
            this.toggleButton2.TabIndex = 31;
            this.toggleButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(332, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ativo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox2.Location = new System.Drawing.Point(30, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 23);
            this.textBox2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(146, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "*";
            // 
            // TxtComtroleDeEstoque
            // 
            this.TxtComtroleDeEstoque.AutoSize = true;
            this.TxtComtroleDeEstoque.BackColor = System.Drawing.Color.Transparent;
            this.TxtComtroleDeEstoque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtComtroleDeEstoque.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtComtroleDeEstoque.Location = new System.Drawing.Point(30, 57);
            this.TxtComtroleDeEstoque.Name = "TxtComtroleDeEstoque";
            this.TxtComtroleDeEstoque.Size = new System.Drawing.Size(45, 17);
            this.TxtComtroleDeEstoque.TabIndex = 28;
            this.TxtComtroleDeEstoque.Text = "Nome";
            // 
            // toggleButton3
            // 
            this.toggleButton3.AutoSize = true;
            this.toggleButton3.Checked = true;
            this.toggleButton3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleButton3.FocusToggleColor = System.Drawing.Color.Gold;
            this.toggleButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toggleButton3.Location = new System.Drawing.Point(332, 32);
            this.toggleButton3.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButton3.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButton3.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.toggleButton3.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButton3.Size = new System.Drawing.Size(45, 22);
            this.toggleButton3.TabIndex = 26;
            this.toggleButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(332, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ativo";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox3.Location = new System.Drawing.Point(30, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 23);
            this.textBox3.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.label8.Location = new System.Drawing.Point(81, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "*";
            // 
            // txtNomeGeral
            // 
            this.txtNomeGeral.AutoSize = true;
            this.txtNomeGeral.BackColor = System.Drawing.Color.Transparent;
            this.txtNomeGeral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeGeral.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNomeGeral.Location = new System.Drawing.Point(30, 11);
            this.txtNomeGeral.Name = "txtNomeGeral";
            this.txtNomeGeral.Size = new System.Drawing.Size(45, 17);
            this.txtNomeGeral.TabIndex = 23;
            this.txtNomeGeral.Text = "Nome";
            // 
            // Produtos_Finais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.dataGridViewProdutosFinais);
            this.Controls.Add(this.tabControlGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos_Finais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos Finais";
            this.tabControlGeral.ResumeLayout(false);
            this.Geral.ResumeLayout(false);
            this.Geral.PerformLayout();
            this.tabControlPreco.ResumeLayout(false);
            this.tabControlPreco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosFinais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlGeral;
        private TabPage Geral;
        private TabPage tabControlPreco;
        private DataGridView dataGridViewProdutosFinais;
        private TextBox inputNomeComponente;
        private Label txtObg1;
        private Label txtNomeComponentes;
        private Controls.ToggleButton toggleButton2;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label TxtComtroleDeEstoque;
        private Controls.ToggleButton toggleButton3;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private Label txtNomeGeral;
        private Controls.ToggleButton toggleButton1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Controls.ToggleButton toggleButtonAtivoComponentes;
        private Label txtAtivo;
    }
}