using Krypton.Toolkit;

namespace MovSoft.Forms
{
    partial class VincularComponentes
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
            checkedListBox = new CheckedListBox();
            btnVincular = new Button();
            btnPesquisar = new Button();
            txtTitulo = new Label();
            dataGridViewVincularComponentes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVincularComponentes).BeginInit();
            SuspendLayout();
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
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top;
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.Location = new Point(345, 21);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(274, 32);
            txtTitulo.TabIndex = 0;
            txtTitulo.Text = "Vincular Componentes";
            // 
            // dataGridViewVincularComponentes
            // 
            dataGridViewVincularComponentes.AllowUserToAddRows = false;
            dataGridViewVincularComponentes.AllowUserToDeleteRows = false;
            dataGridViewVincularComponentes.AllowUserToResizeColumns = false;
            dataGridViewVincularComponentes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewVincularComponentes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVincularComponentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVincularComponentes.BackgroundColor = Color.WhiteSmoke;
            dataGridViewVincularComponentes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewVincularComponentes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewVincularComponentes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewVincularComponentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewVincularComponentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVincularComponentes.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewVincularComponentes.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVincularComponentes.EnableHeadersVisualStyles = false;
            dataGridViewVincularComponentes.GridColor = Color.FromArgb(56, 56, 56);
            dataGridViewVincularComponentes.Location = new Point(198, 250);
            dataGridViewVincularComponentes.Margin = new Padding(3, 4, 3, 4);
            dataGridViewVincularComponentes.Name = "dataGridViewVincularComponentes";
            dataGridViewVincularComponentes.ReadOnly = true;
            dataGridViewVincularComponentes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewVincularComponentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewVincularComponentes.RowHeadersVisible = false;
            dataGridViewVincularComponentes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewVincularComponentes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewVincularComponentes.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(56, 56, 56);
            dataGridViewVincularComponentes.RowTemplate.Height = 25;
            dataGridViewVincularComponentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVincularComponentes.ShowCellErrors = false;
            dataGridViewVincularComponentes.ShowCellToolTips = false;
            dataGridViewVincularComponentes.ShowEditingIcon = false;
            dataGridViewVincularComponentes.ShowRowErrors = false;
            dataGridViewVincularComponentes.Size = new Size(571, 134);
            dataGridViewVincularComponentes.TabIndex = 21;
            dataGridViewVincularComponentes.CellClick += dataGridViewVincularComponentes_CellContentClick;
            dataGridViewVincularComponentes.CellEndEdit += dataGridViewVincularComponentes_CellEndEdit;
            dataGridViewVincularComponentes.CellPainting += dataGridViewVincularComponentes_CellPainting;
            // 
            // VincularComponentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(56, 56, 56);
            ClientSize = new Size(914, 464);
            Controls.Add(dataGridViewVincularComponentes);
            Controls.Add(txtTitulo);
            Controls.Add(btnPesquisar);
            Controls.Add(btnVincular);
            Controls.Add(checkedListBox);
            ForeColor = Color.WhiteSmoke;
            Name = "VincularComponentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovSoft - Vincular Componentes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVincularComponentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox;
        private Button btnVincular;
        private Button btnPesquisar;
        private Label txtTitulo;
        private DataGridView dataGridViewVincularComponentes;
    }
}