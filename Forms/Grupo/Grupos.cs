using MovSoft.Classes;

namespace MovSoft
{
    public partial class Grupos : Form
    {
        Funcoes funcoes = new();
        public Grupos()
        {
            InitializeComponent();
            PosicionarObrs();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void PosicionarObrs()
        {
            funcoes.PosicionarObrFilho(txtNomeGrupo, txtObr1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}