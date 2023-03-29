using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft.Forms
{
    public partial class Componentes : Form
    {
        Funcoes funcoes = new();
        ComponentesBLL bll = new();
        ComponentesDTO dto = new();
        DataGridViewRow rowData = new();
        GeralBLL bllGeral = new();
        string? filtro = null;
        char cadastrarOuEditar; //Cadastrar = 'C' | Editar = 'E'

        public Componentes()
        {
            InitializeComponent();
            CarregarComponentes();
            comboBoxFiltro.SelectedIndex = 0;
            comboBoxUnidadeDeMedida.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
            funcoes.CriarColunaComCheckbox(dataGridViewComponentes);
        }

        private void LimparCampos()
        {
            inputNomeComponente.Text = "";
            comboBoxUnidadeDeMedida.Text = "";
            toggleButtonAtivo.Checked = true;
        }

        public void CarregarComponentes()
        {
            dataGridViewComponentes.DataSource = bll.MostrarComponentes(filtro);
            foreach (DataGridViewColumn column in dataGridViewComponentes.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else if (column.Name == "AtivoCheckBox")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }
                else if (column.Name == "Ativo")
                {
                    column.Visible = false;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (comboBoxFiltro.SelectedIndex != 0 && column.Name == "AtivoCheckBox")
                {
                    column.Visible = false;
                }
                else if (column.Name == "AtivoCheckBox")
                {
                    column.Visible = true;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(4))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        CadastrarComponente();
                        VoltarAoPadrao();
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
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar componentes", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void PesquisarComponentes()
        {
            comboBoxFiltro.SelectedIndex = 0;
            dataGridViewComponentes.DataSource = bll.PesquisarComponente(inputPesquisar.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarAoPadrao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarComponentes();
        }

        private void inputPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarComponentes();
            }
        }

        private void AtribuirDadosDosInputs(bool editar)
        {
            if (editar)
            {
                dto.IdComponente = (int)Parametros.idComponente;
            }
            if (toggleButtonAtivo.Checked)
            {
                dto.Ativo = "S";
            }
            else
            {
                dto.Ativo = "N";
            }
            dto.NomeComponente = inputNomeComponente.Text;
            dto.UnidadeMedida = comboBoxUnidadeDeMedida.Text;
        }

        private void CadastrarComponente()
        {
            AtribuirDadosDosInputs(false);
            bll.CadastrarComponentes(dto);
            CarregarComponentes();
        }

        private void EditarComponente()
        {
            AtribuirDadosDosInputs(true);
            bll.EditarComponente(dto);
            CarregarComponentes();
        }

        private void Editar()
        {
            if (pnlCadastro.Enabled)
            {
                if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                {
                    EditarComponente();
                    VoltarAoPadrao();
                }
            }
            else
            {
                dataGridViewComponentes.Enabled = false;
                btnEditar.Text = "Salvar";
                pnlCadastro.Enabled = true;
                btnCancelar.Enabled = true;
                inputNomeComponente.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void AtribuirDadosAosInputs()
        {
            inputNomeComponente.Text = Parametros.nomeComponente;
            comboBoxUnidadeDeMedida.Text = Parametros.unidadeMedidaComponente;
            if (Parametros.componenteAtivo == "S")
            {
                toggleButtonAtivo.Checked = true;
            }
            else
            {
                toggleButtonAtivo.Checked = false;
            }
        }

        private void dataGridViewComponentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewComponentes.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                string cellValue = dataGridViewComponentes.Rows[e.RowIndex].Cells["AtivoCheckBox"].Value.ToString();

                if (cellValue == "S")
                {
                    e.Value = true;
                }
                else
                {
                    e.Value = false;
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewComponentes.Columns[e.ColumnIndex].Name == "AtivoCheckBox")
            {
                rowData = dataGridViewComponentes.Rows[e.RowIndex];
                DataGridViewCheckBoxCell chk = dataGridViewComponentes.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                string valor = chk.Value.ToString();
                if (valor == "S")
                {
                    bllGeral.AtivarDesativar("componentes", "id_componente", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesativar("componentes", "id_componente", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarComponentes();
            }
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarComponentes();
        }

        private void dataGridViewComponentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                rowData = dataGridViewComponentes.Rows[e.RowIndex];
                Parametros.idComponente = int.Parse(rowData.Cells[0].Value.ToString());
                bll.PegarDados((int)Parametros.idComponente);
                AtribuirDadosAosInputs();
            }
        }
    }
}