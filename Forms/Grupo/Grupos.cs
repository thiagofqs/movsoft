using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using System.Windows.Forms;

namespace MovSoft.Forms
{
    public partial class Grupos : Form
    {
        Funcoes funcoes = new();
        GruposBLL bll = new();
        GruposDTO dto = new();
        DataGridViewRow rowData = new();
        GeralBLL bllGeral = new();
        string? filtro = null;
        char cadastrarOuEditar; //Cadastrar = 'C' | Editar = 'E'

        public Grupos()
        {
            InitializeComponent();
            CarregarGrupos();
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
            funcoes.CriarColunaComCheckbox(dataGridViewGrupos);
        }

        public void CarregarGrupos()
        {
            dataGridViewGrupos.DataSource = bll.MostrarGrupos(filtro);
            foreach (DataGridViewColumn column in dataGridViewGrupos.Columns)
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
                if (comboBoxFiltro.SelectedIndex != 0 && column.Index == 3)
                {
                    column.Visible = false;
                }
                else if (column.Index == 3)
                {
                    column.Visible = true;
                }
            }
        }

        private void PesquisarGrupos()
        {
            comboBoxFiltro.SelectedIndex = 0;
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
            toggleButtonAtivo.Checked = true;
        }

        private void AtribuirDadosDosInputs(bool editar)
        {
            if (editar)
            {
                dto.IdGrupo = (int)Parametros.idGrupo;
            }
            if (toggleButtonAtivo.Checked)
            {
                dto.Ativo = "S";
            }
            else
            {
                dto.Ativo = "N";
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
            CarregarGrupos();
        }

        private void EditarGrupo()
        {
            AtribuirDadosDosInputs(true);
            bll.EditarGrupo(dto);
            CarregarGrupos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(5))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        CadastrarGrupo();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'C';
                    dataGridViewGrupos.Enabled = false;
                    btnCadastrar.Text = "Salvar";
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeGrupo.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar grupos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                {
                    if (cadastrarOuEditar == 'C')
                    {
                        CadastrarGrupo();
                    }
                    else if (cadastrarOuEditar == 'E')
                    {
                        EditarGrupo();
                    }
                    VoltarAoPadrao();
                }
            }
        }

        private void AtribuirDadosAosInputs()
        {
            inputNomeGrupo.Text = Parametros.nomeGrupo;
            if (Parametros.grupoAtivo == "S")
            {
                toggleButtonAtivo.Checked = true;
            }
            else
            {
                toggleButtonAtivo.Checked = false;
            }
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
            if (funcoes.VerificarPermissao(4))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        EditarGrupo();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'E';
                    btnEditar.Text = "Salvar";
                    dataGridViewGrupos.Enabled = false;
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeGrupo.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para editar grupos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltro.SelectedIndex == 0)
            {
                filtro = null;
            }
            else if (comboBoxFiltro.SelectedIndex == 1)
            {
                filtro = "S";
            }
            else
            {
                filtro = "N";
            }
            CarregarGrupos();
        }

        private void dataGridViewGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (funcoes.VerificarPermissao(4))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        EditarGrupo();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'E';
                    btnEditar.Text = "Salvar";
                    dataGridViewGrupos.Enabled = false;
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeGrupo.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar grupos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dataGridViewGrupos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewGrupos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                string cellValue = dataGridViewGrupos.Rows[e.RowIndex].Cells["AtivoCheckBox"].Value.ToString();

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

        private void dataGridViewGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewGrupos.Columns[e.ColumnIndex].Name == "AtivoCheckBox")
            {
                rowData = dataGridViewGrupos.Rows[e.RowIndex];
                DataGridViewCheckBoxCell chk = dataGridViewGrupos.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                string valor = chk.Value.ToString();
                if (valor == "S")
                {
                    bllGeral.AtivarDesetivar("grupos", "id_grupo", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesetivar("grupos", "id_grupo", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarGrupos();
            }
        }
    }
}