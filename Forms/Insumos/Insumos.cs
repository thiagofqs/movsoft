namespace MovSoft.Forms.Grupo
{
    public partial class Insumos : Form
    {
        public Insumos()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void LimparCampos()
        {
            inputNomeComponente.Text = "";
            inputQuantidadeComponentes.Text = "";
            comboBoxUnidadeDeMedida.Text = "";
            inputNomeOpcionais.Text = "";
            comboBoxQuantidadeOpcionais.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tabPageCadastroInsumos.Enabled)
            {
                if (tabPageCadastroInsumos.SelectedIndex == 0 && (inputNomeComponente.Text == "" || inputQuantidadeComponentes.Text == "" || comboBoxUnidadeDeMedida.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    inputNomeComponente.Focus();
                }
                else if (tabPageCadastroInsumos.SelectedIndex == 1 && (inputNomeOpcionais.Text == "" || comboBoxQuantidadeOpcionais.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    inputNomeOpcionais.Focus();
                }
                else
                {
                    tabPageCadastroInsumos.Enabled = false;
                    LimparCampos();
                    btnCancelar.Enabled = false;
                }
            }
            else
            {
                tabPageCadastroInsumos.Enabled = true;
                btnCancelar.Enabled = true;
                inputNomeComponente.Focus();
            }
        }

        private void PesquisarInsumos()
        {
            //dataGridViewGrupos.DataSource = bll.PesquisarInsumos(inputPesquisar.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabPageCadastroInsumos.Enabled = false;
            tabPageCadastroInsumos.SelectedIndex = 0;
            LimparCampos();
            btnCancelar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarInsumos();
        }

        private void inputPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarInsumos();
            }
        }
    }
}