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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputPesquisarGrupos = new System.Windows.Forms.TextBox();
            this.dataGridViewGrupos = new System.Windows.Forms.DataGridView();
            this.btnAtualizarGrupos = new System.Windows.Forms.Button();
            this.btnCadGrupos = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewGrupos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupos.Location = new System.Drawing.Point(198, 95);
            this.dataGridViewGrupos.Name = "dataGridViewGrupos";
            this.dataGridViewGrupos.RowTemplate.Height = 25;
            this.dataGridViewGrupos.Size = new System.Drawing.Size(561, 291);
            this.dataGridViewGrupos.TabIndex = 1;
            // 
            // btnAtualizarGrupos
            // 
            this.btnAtualizarGrupos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizarGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarGrupos.Location = new System.Drawing.Point(684, 66);
            this.btnAtualizarGrupos.Name = "btnAtualizarGrupos";
            this.btnAtualizarGrupos.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarGrupos.TabIndex = 1;
            this.btnAtualizarGrupos.Text = "Atualizar";
            this.btnAtualizarGrupos.UseVisualStyleBackColor = false;
            // 
            // btnCadGrupos
            // 
            this.btnCadGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadGrupos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(132)))));
            this.btnCadGrupos.FlatAppearance.BorderSize = 0;
            this.btnCadGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadGrupos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadGrupos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadGrupos.Location = new System.Drawing.Point(545, 392);
            this.btnCadGrupos.Name = "btnCadGrupos";
            this.btnCadGrupos.Size = new System.Drawing.Size(214, 34);
            this.btnCadGrupos.TabIndex = 2;
            this.btnCadGrupos.Text = "Cadastrar Grupo";
            this.btnCadGrupos.UseVisualStyleBackColor = false;
            this.btnCadGrupos.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(930, 473);
            this.Controls.Add(this.btnCadGrupos);
            this.Controls.Add(this.btnAtualizarGrupos);
            this.Controls.Add(this.dataGridViewGrupos);
            this.Controls.Add(this.inputPesquisarGrupos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grupos";
            this.Text = "Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputPesquisarGrupos;
        private DataGridView dataGridViewGrupos;
        private Button btnAtualizarGrupos;
        private Button btnCadGrupos;
    }
}