﻿namespace MovSoft.Forms
{
    partial class VincularOpcionais
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtTitulo = new Label();
            btnPesquisar = new Button();
            btnVincular = new Button();
            checkedListBox = new CheckedListBox();
            dataGridViewVincularOpcionais = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVincularOpcionais).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top;
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.Location = new Point(345, 21);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(229, 32);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Vincular Opcionais";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackColor = Color.Transparent;
            btnPesquisar.BackgroundImage = Properties.Resources.icon_add;
            btnPesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.FromArgb(56, 56, 56);
            btnPesquisar.Location = new Point(775, 74);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(30, 30);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnVincular_Click;
            // 
            // btnVincular
            // 
            btnVincular.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVincular.BackColor = Color.FromArgb(0, 133, 132);
            btnVincular.Cursor = Cursors.Hand;
            btnVincular.FlatAppearance.BorderColor = Color.FromArgb(0, 133, 132);
            btnVincular.FlatAppearance.BorderSize = 0;
            btnVincular.FlatStyle = FlatStyle.Flat;
            btnVincular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVincular.ForeColor = Color.WhiteSmoke;
            btnVincular.Location = new Point(644, 391);
            btnVincular.Name = "btnVincular";
            btnVincular.Size = new Size(125, 34);
            btnVincular.TabIndex = 2;
            btnVincular.Text = "Fechar";
            btnVincular.UseVisualStyleBackColor = false;
            btnVincular.Click += btnVincular_Click_1;
            // 
            // checkedListBox
            // 
            checkedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkedListBox.BackColor = Color.WhiteSmoke;
            checkedListBox.CheckOnClick = true;
            checkedListBox.ColumnWidth = 150;
            checkedListBox.ForeColor = Color.FromArgb(56, 56, 56);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(198, 74);
            checkedListBox.MultiColumn = true;
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(571, 94);
            checkedListBox.TabIndex = 0;
            // 
            // dataGridViewVincularOpcionais
            // 
            dataGridViewVincularOpcionais.AllowUserToAddRows = false;
            dataGridViewVincularOpcionais.AllowUserToDeleteRows = false;
            dataGridViewVincularOpcionais.AllowUserToResizeColumns = false;
            dataGridViewVincularOpcionais.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewVincularOpcionais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVincularOpcionais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVincularOpcionais.BackgroundColor = Color.WhiteSmoke;
            dataGridViewVincularOpcionais.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewVincularOpcionais.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewVincularOpcionais.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewVincularOpcionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewVincularOpcionais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVincularOpcionais.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewVincularOpcionais.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVincularOpcionais.EnableHeadersVisualStyles = false;
            dataGridViewVincularOpcionais.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewVincularOpcionais.Location = new Point(198, 193);
            dataGridViewVincularOpcionais.Name = "dataGridViewVincularOpcionais";
            dataGridViewVincularOpcionais.ReadOnly = true;
            dataGridViewVincularOpcionais.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewVincularOpcionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewVincularOpcionais.RowHeadersVisible = false;
            dataGridViewVincularOpcionais.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewVincularOpcionais.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewVincularOpcionais.RowTemplate.Height = 25;
            dataGridViewVincularOpcionais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVincularOpcionais.ShowCellErrors = false;
            dataGridViewVincularOpcionais.ShowCellToolTips = false;
            dataGridViewVincularOpcionais.ShowEditingIcon = false;
            dataGridViewVincularOpcionais.ShowRowErrors = false;
            dataGridViewVincularOpcionais.Size = new Size(571, 192);
            dataGridViewVincularOpcionais.TabIndex = 3;
            dataGridViewVincularOpcionais.CellClick += dataGridViewVincularOpcionais_CellContentClick;
            dataGridViewVincularOpcionais.CellPainting += dataGridViewVincularOpcionais_CellPainting;
            // 
            // VincularOpcionais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(914, 464);
            Controls.Add(txtTitulo);
            Controls.Add(btnPesquisar);
            Controls.Add(btnVincular);
            Controls.Add(checkedListBox);
            Controls.Add(dataGridViewVincularOpcionais);
            ForeColor = Color.WhiteSmoke;
            Name = "VincularOpcionais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Vincular Opcionais";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVincularOpcionais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTitulo;
        private Button btnPesquisar;
        private Button btnVincular;
        private CheckedListBox checkedListBox;
        private DataGridView dataGridViewVincularOpcionais;
    }
}