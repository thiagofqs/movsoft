namespace MovSoft.Forms
{
    public partial class VincularOpcionais : Form
    {
        public VincularOpcionais()
        {
            InitializeComponent();
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa opção está indisponível no momento!", "Opção indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
