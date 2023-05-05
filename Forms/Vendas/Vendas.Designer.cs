namespace MovSoft.Forms
{
    partial class Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelImpressao = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.inputPesquisar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnNovoPedido = new System.Windows.Forms.Button();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImpressao
            // 
            this.panelImpressao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImpressao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelImpressao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panelImpressao.Location = new System.Drawing.Point(505, 103);
            this.panelImpressao.Name = "panelImpressao";
            this.panelImpressao.Size = new System.Drawing.Size(275, 297);
            this.panelImpressao.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::MovSoft.Properties.Resources.icon_search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnPesquisar.Location = new System.Drawing.Point(440, 71);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(23, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // inputPesquisar
            // 
            this.inputPesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.inputPesquisar.Location = new System.Drawing.Point(194, 71);
            this.inputPesquisar.Name = "inputPesquisar";
            this.inputPesquisar.PlaceholderText = "Pesquisar";
            this.inputPesquisar.Size = new System.Drawing.Size(240, 23);
            this.inputPesquisar.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.Location = new System.Drawing.Point(88, 159);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 50);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimir.Location = new System.Drawing.Point(88, 215);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 50);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnNovoPedido
            // 
            this.btnNovoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnNovoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoPedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnNovoPedido.FlatAppearance.BorderSize = 0;
            this.btnNovoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoPedido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovoPedido.Location = new System.Drawing.Point(88, 103);
            this.btnNovoPedido.Name = "btnNovoPedido";
            this.btnNovoPedido.Size = new System.Drawing.Size(100, 50);
            this.btnNovoPedido.TabIndex = 2;
            this.btnNovoPedido.Text = "Novo Pedido";
            this.btnNovoPedido.UseVisualStyleBackColor = false;
            this.btnNovoPedido.Click += new System.EventHandler(this.btnNovoPedido_Click);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            this.dataGridViewPedidos.AllowUserToDeleteRows = false;
            this.dataGridViewPedidos.AllowUserToResizeColumns = false;
            this.dataGridViewPedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPedidos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPedidos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewPedidos.EnableHeadersVisualStyles = false;
            this.dataGridViewPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dataGridViewPedidos.Location = new System.Drawing.Point(194, 103);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            this.dataGridViewPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewPedidos.RowHeadersVisible = false;
            this.dataGridViewPedidos.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewPedidos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewPedidos.RowTemplate.Height = 25;
            this.dataGridViewPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.ShowCellErrors = false;
            this.dataGridViewPedidos.ShowCellToolTips = false;
            this.dataGridViewPedidos.ShowEditingIcon = false;
            this.dataGridViewPedidos.ShowRowErrors = false;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(305, 297);
            this.dataGridViewPedidos.TabIndex = 5;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(931, 503);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnNovoPedido);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.inputPesquisar);
            this.Controls.Add(this.panelImpressao);
            this.Name = "Vendas";
            this.Text = "MovSoft - Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelImpressao;
        private Button btnPesquisar;
        private TextBox inputPesquisar;
        private Button btnEditar;
        private Button btnImprimir;
        private Button btnNovoPedido;
        private DataGridView dataGridViewPedidos;
    }
}