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
        string? filtro = null;
        public Grupos()
        {
            InitializeComponent();
            CarregarGupos();
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
            DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new();
            dataGridViewCheckBoxColumn.HeaderText = "Ativo";
            dataGridViewCheckBoxColumn.Name = "Ativo";
            dataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            dataGridViewGrupos.Columns.Add(dataGridViewCheckBoxColumn);

        }

        public void CarregarGupos()
        {
            dataGridViewGrupos.DataSource = bll.MostrarGrupos(filtro);
            foreach (DataGridViewColumn column in dataGridViewGrupos.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else if(column.Index == 3)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if(comboBoxFiltro.SelectedIndex != 0 && column.Index == 3)
                {
                    column.Visible = false;
                }
                else if(column.Index == 3)
                {
                    column.Visible = true;
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
            if (toggleButton1.Checked)
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
            if (funcoes.VerificarPermissao(5))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificaSeInputEstáVazio(pnlCadastro))
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
                CadastrarGrupo();
                VoltarAoPadrao();
            }
        }

        private void AtribuirDadosAosInputs()
        {
            inputNomeGrupo.Text = Parametros.nomeGrupo;
            if (Parametros.grupoAtivo == "S")
            {
                toggleButton1.Checked = true;
            }
            else
            {
                toggleButton1.Checked = false;
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
                    if (!funcoes.VerificaSeInputEstáVazio(pnlCadastro))
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
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar grupos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            CarregarGupos();
        }

        private void dataGridViewGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (funcoes.VerificarPermissao(4))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificaSeInputEstáVazio(pnlCadastro))
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
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar grupos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dataGridViewGrupos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridViewGrupos.Columns[2].Visible = false;
            if (dataGridViewGrupos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                string cellValue = dataGridViewGrupos.Rows[e.RowIndex].Cells["Ativo"].Value.ToString();

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
    }
}