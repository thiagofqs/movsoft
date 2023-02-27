using MovSoft.Classes;

namespace MovSoft
{
    public partial class Grupos : Form
    {
        Funcoes funcoes = new();
        public Grupos()
        {
            InitializeComponent();
        }

        private void AbrirCadGrupo()
        {
            CadGrupos frm = new();
            funcoes.AbrirForms(frm, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirCadGrupo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}