using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using System.Windows.Forms;

namespace MovSoft
{
    public partial class Grupos : Form
    {
        Funcoes funcoes = new();
        GruposBLL bll = new();
        GruposDTO dto = new();

        public Grupos()
        {
            InitializeComponent();
            CarregarGupos();
            PosicionarObrs();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void PosicionarObrs()
        {
            funcoes.PosicionarObrFilho(txtNomeGrupo, txtObr1);
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

        private void AtribuirDadosDosInputs()
        {
            dto.NomeGrupo = inputNomeGrupo.Text;
        }

        private void VoltarAoPadrao()
        {
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCancelar.Enabled = false;
        }

        private void CadastrarGrupo()
        {
            AtribuirDadosDosInputs();
            bll.CadastrarGrupo(dto);
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
    }
}