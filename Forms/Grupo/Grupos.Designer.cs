namespace MovSoft
{
    partial class Grupos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputPesquisarGrupos = new System.Windows.Forms.TextBox();
            this.dataGridViewGrupos = new System.Windows.Forms.DataGridView();
            this.btnAtualizarGrupos = new System.Windows.Forms.Button();
            this.btnCadGrupos = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtnDesabilitado = new System.Windows.Forms.RadioButton();
            this.radioBtnHabilitado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPesquisarGrupos
            // 
            this.inputPesquisarGrupos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inputPesquisarGrupos.Location = new System.Drawing.Point(198, 66);
            this.inputPesquisarGrupos.Name = "inputPesquisarGrupos";
            this.inputPesquisarGrupos.PlaceholderText = "Pesquisar";
            this.inputPesquisarGrupos.Size = new System.Drawing.Size(240, 23);
            this.inputPesquisarGrupos.TabIndex = 0;
            // 
            // dataGridViewGrupos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGrupos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewGrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupos.Location = new System.Drawing.Point(198, 95);
            this.dataGridViewGrupos.Name = "dataGridViewGrupos";
            this.dataGridViewGrupos.RowTemplate.Height = 25;
            this.dataGridViewGrupos.Size = new System.Drawing.Size(561, 321);
            this.dataGridViewGrupos.TabIndex = 3;
            // 
            // btnAtualizarGrupos
            // 
            this.btnAtualizarGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizarGrupos.AutoSize = true;
            this.btnAtualizarGrupos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizarGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarGrupos.Location = new System.Drawing.Point(696, 66);
            this.btnAtualizarGrupos.Name = "btnAtualizarGrupos";
            this.btnAtualizarGrupos.Size = new System.Drawing.Size(63, 25);
            this.btnAtualizarGrupos.TabIndex = 2;
            this.btnAtualizarGrupos.Text = "Atualizar";
            this.btnAtualizarGrupos.UseVisualStyleBackColor = false;
            // 
            // btnCadGrupos
            // 
            this.btnCadGrupos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadGrupos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadGrupos.FlatAppearance.BorderSize = 0;
            this.btnCadGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadGrupos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadGrupos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadGrupos.Location = new System.Drawing.Point(576, 422);
            this.btnCadGrupos.Name = "btnCadGrupos";
            this.btnCadGrupos.Size = new System.Drawing.Size(183, 34);
            this.btnCadGrupos.TabIndex = 4;
            this.btnCadGrupos.Text = "Cadastrar Grupo";
            this.btnCadGrupos.UseVisualStyleBackColor = false;
            this.btnCadGrupos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnSearch.BackgroundImage = global::MovSoft.Properties.Resources.icon_search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(444, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(198, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
            // 
            // radioBtnDesabilitado
            // 
            this.radioBtnDesabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnDesabilitado.AutoSize = true;
            this.radioBtnDesabilitado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioBtnDesabilitado.Location = new System.Drawing.Point(348, 432);
            this.radioBtnDesabilitado.Name = "radioBtnDesabilitado";
            this.radioBtnDesabilitado.Size = new System.Drawing.Size(90, 19);
            this.radioBtnDesabilitado.TabIndex = 6;
            this.radioBtnDesabilitado.Text = "Desabilitado";
            this.radioBtnDesabilitado.UseVisualStyleBackColor = true;
            // 
            // radioBtnHabilitado
            // 
            this.radioBtnHabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioBtnHabilitado.AutoSize = true;
            this.radioBtnHabilitado.Checked = true;
            this.radioBtnHabilitado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioBtnHabilitado.Location = new System.Drawing.Point(262, 432);
            this.radioBtnHabilitado.Name = "radioBtnHabilitado";
            this.radioBtnHabilitado.Size = new System.Drawing.Size(80, 19);
            this.radioBtnHabilitado.TabIndex = 5;
            this.radioBtnHabilitado.Text = "Habilitado";
            this.radioBtnHabilitado.UseVisualStyleBackColor = true;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBtnDesabilitado);
            this.Controls.Add(this.radioBtnHabilitado);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCadGrupos);
            this.Controls.Add(this.btnAtualizarGrupos);
            this.Controls.Add(this.dataGridViewGrupos);
            this.Controls.Add(this.inputPesquisarGrupos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovSoft - Lista de Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputPesquisarGrupos;
        private DataGridView dataGridViewGrupos;
        private Button btnAtualizarGrupos;
        private Button btnCadGrupos;
        private Button btnSearch;
        private Label label1;
        private RadioButton radioBtnDesabilitado;
        private RadioButton radioBtnHabilitado;
    }
}