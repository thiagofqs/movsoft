namespace MovSoft.Forms
{
    public partial class VincularComponentes : Form
    {
        public VincularComponentes()
        {
            InitializeComponent();
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa opção está indisponível no momento!", "Opção indisponível", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void MostrarComponentesDisponiveis()
        {
            checkedListBox.DataBindings;
        }
    }
}
