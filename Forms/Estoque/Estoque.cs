using MovSoft.Classes;

namespace MovSoft.Forms
{
    public partial class Estoque : Form
    {
        Funcoes funcoes = new();
        public Estoque()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
        }

        private void LimparCampos()
        {
            comboBoxFiltro.Text = "";
            comboBoxProduto.Text = "";
            comboBoxMovimento.Text = "";
            numericUpDownQuantidade.Text = "0";
            numericUpCusto.Text = "0";
        }

        private void VoltarAoPadrao()
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewEstoque.Enabled = true;
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(4))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        //CadastrarGrupo();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    dataGridViewEstoque.Enabled = false;
                    btnCadastrar.Text = "Salvar";
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    comboBoxFiltro.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar estoque", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Enabled)
            {
                if (comboBoxFiltro.Text == "" || comboBoxProduto.Text == "" || comboBoxMovimento.Text == "" || numericUpDownQuantidade.Text == "" || numericUpCusto.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    comboBoxFiltro.Focus();
                }
                else
                {
                    //EditarGrupo();
                    VoltarAoPadrao();
                }
            }
            else
            {
                btnEditar.Text = "Salvar";
                dataGridViewEstoque.Enabled = false;
                pnlCadastro.Enabled = true;
                btnCancelar.Enabled = true;
                comboBoxFiltro.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarAoPadrao();
        }
    }
}
