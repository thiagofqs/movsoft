using MovSoft.Classes;

namespace MovSoft.Forms
{
    public partial class Componentes : Form
    {
        Funcoes funcoes = new();

        public Componentes()
        {
            InitializeComponent();
            comboBoxUnidadeDeMedida.SelectedIndex = 0;
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
        }

        private void LimparCampos()
        {
            inputNomeComponente.Text = "";
            comboBoxUnidadeDeMedida.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Enabled)
            {
                if (!funcoes.VerificaSeInputEstáVazio(pnlCadastro))
                {
                    inputNomeComponente.Focus();
                }
                else
                {
                    pnlCadastro.Enabled = false;
                    LimparCampos();
                    btnCancelar.Enabled = false;
                }
            }
            else
            {
                dataGridViewComponentes.Enabled = false;
                btnCadastrar.Text = "Salvar";
                pnlCadastro.Enabled = true;
                btnCancelar.Enabled = true;
                inputNomeComponente.Focus();
            }
        }

        private void VoltarAoPadrao()
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewComponentes.Enabled = true;
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void PesquisarInsumos()
        {
            //dataGridViewGrupos.DataSource = bll.PesquisarInsumos(inputPesquisar.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewComponentes.Enabled = true;
            pnlCadastro.Enabled = false;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Enabled)
            {
                if (inputNomeComponente.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    inputNomeComponente.Focus();
                }
                else
                {
                    //EditarGrupo();
                    VoltarAoPadrao();
                }
            }
            else
            {
                dataGridViewComponentes.Enabled = false;
                btnCadastrar.Text = "Salvar";
                pnlCadastro.Enabled = true;
                btnCancelar.Enabled = true;
                inputNomeComponente.Focus();
            }
        }

        private void dataGridViewComponentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                /*rowData = dataGridViewGrupos.Rows[e.RowIndex];
                Parametros.idGrupo = int.Parse(rowData.Cells[0].Value.ToString());
                bll.PegarDados((int)Parametros.idGrupo);
                AtribuirDadosAosInputs();*/
            }
        }
    }
}