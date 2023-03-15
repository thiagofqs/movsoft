using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft.Forms
{
    public partial class Grupos : Form
    {
        Funcoes funcoes = new();
        GruposBLL bll = new();
        GruposDTO dto = new();
        DataGridViewRow rowData = new();

        public Grupos()
        {
            InitializeComponent();
            CarregarGupos();
            comboBoxFiltro.SelectedIndex = 0;
        }

        public void CarregarGupos()
        {
            dataGridViewGrupos.DataSource = bll.MostrarGrupos();
            foreach (DataGridViewColumn column in dataGridViewGrupos.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void PesquisarGrupos()
        {
            dataGridViewGrupos.DataSource = bll.PesquisarGrupo(inputPesquisar.Text);
        }

        private void inputPesquisarGrupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarGrupos();
            }
        }

        private void LimparCampos()
        {
            inputNomeGrupo.Text = "";
        }

        private void AtribuirDadosDosInputs(bool editar)
        {
            if (editar)
            {
                dto.IdGrupo = (int)Parametros.idGrupo;
            }
            dto.NomeGrupo = inputNomeGrupo.Text;
        }

        private void VoltarAoPadrao()
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewGrupos.Enabled = true;
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void CadastrarGrupo()
        {
            AtribuirDadosDosInputs(false);
            bll.CadastrarGrupo(dto);
            CarregarGupos();
        }

        private void EditarGrupo()
        {
            AtribuirDadosDosInputs(true);
            bll.EditarGrupo(dto);
            CarregarGupos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Enabled)
            {
                if (inputNomeGrupo.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    inputNomeGrupo.Focus();
                }
                else
                {
                    CadastrarGrupo();
                    VoltarAoPadrao();
                }
            }
            else
            {
                dataGridViewGrupos.Enabled = false;
                btnCadastrar.Text = "Salvar";
                pnlCadastro.Enabled = true;
                btnCancelar.Enabled = true;
                inputNomeGrupo.Focus();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarAoPadrao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarGrupos();
        }

        private void inputNomeGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CadastrarGrupo();
                VoltarAoPadrao();
            }
        }

        private void AtribuirDadosAosInputs()
        {
            inputNomeGrupo.Text = Parametros.nomeGrupo;
        }

        private void dataGridViewGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                rowData = dataGridViewGrupos.Rows[e.RowIndex];
                Parametros.idGrupo = int.Parse(rowData.Cells[0].Value.ToString());
                bll.PegarDados((int)Parametros.idGrupo);
                AtribuirDadosAosInputs();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Enabled)
            {
                if (inputNomeGrupo.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    inputNomeGrupo.Focus();
                }
                else
                {
                    EditarGrupo();
                    VoltarAoPadrao();
                }
            }
            else
            {
                btnEditar.Text = "Salvar";
                dataGridViewGrupos.Enabled = false;
                pnlCadastro.Enabled = true;
                btnCancelar.Enabled = true;
                inputNomeGrupo.Focus();
            }

        }
    }
}