using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft.Forms
{
    public partial class Opcoes : Form
    {
        Funcoes funcoes = new();
        OpcoesBLL bll = new();
        OpcoesDTO dto = new();
        DataGridViewRow rowData = new();
        GeralBLL bllGeral = new();
        string? filtro = null;
        char cadastrarOuEditar; //Cadastrar = 'C' | Editar = 'E'

        public Opcoes()
        {
            InitializeComponent();
            CarregarOpcoes();
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
            funcoes.CriarColunaComCheckbox(dataGridViewOpcoes);
        }

        public void CarregarOpcoes()
        {
            dataGridViewOpcoes.DataSource = bll.MostrarOpcoes(filtro, 1);
            foreach (DataGridViewColumn column in dataGridViewOpcoes.Columns)
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

        private void PesquisarOpcoes()
        {
            comboBoxFiltro.SelectedIndex = 0;
            dataGridViewOpcoes.DataSource = bll.PesquisarOpcao(inputPesquisar.Text);
        }

        private void LimparCampos()
        {
            inputNomeOpcao.Text = "";
            numericUpDownPreco.Text = "0,00";
            toggleButtonAtivo.Checked = true;
        }

        private void VoltarAoPadrao()
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewOpcoes.Enabled = true;
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void AtribuirDadosDosInputs(bool editar)
        {
            if (editar)
            {
                dto.IdOpcao = (int)Parametros.idGrupo;
            }
            if (toggleButtonAtivo.Checked)
            {
                dto.Ativo = "S";
            }
            else
            {
                dto.Ativo = "N";
            }
            dto.Opcao = inputNomeOpcao.Text;
            dto.UnidadeMedida = comboBoxUnidadeDeMedida.Text;
            dto.Preco = (float)numericUpDownPreco.Value;
        }

        private void AtribuirDadosAosInputs()
        {
            inputNomeOpcao.Text = Parametros.nomeOpcao;
            comboBoxUnidadeDeMedida.Text = Parametros.unidadeMedidaComponente;
            numericUpDownPreco.Value = (decimal)Parametros.precoOpcao;
            if (Parametros.opcaoAtivo == "S")
            {
                toggleButtonAtivo.Checked = true;
            }
            else
            {
                toggleButtonAtivo.Checked = false;
            }
        }

        private void CadastrarOpcao()
        {
            AtribuirDadosDosInputs(false);
            bll.CadastrarOpcoes(dto);
            CarregarOpcoes();
        }

        private void EditarOpcao()
        {
            AtribuirDadosDosInputs(true);
            bll.EditarOpcao(dto);
            CarregarOpcoes();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(5))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        CadastrarOpcao();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'C';
                    dataGridViewOpcoes.Enabled = false;
                    btnCadastrar.Text = "Salvar";
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeOpcao.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar opções", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                        EditarOpcao();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'E';
                    btnEditar.Text = "Salvar";
                    dataGridViewOpcoes.Enabled = false;
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeOpcao.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para editar opções", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarAoPadrao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarOpcoes();
        }

        private void inputPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarOpcoes();
            }
        }

        private void dataGridViewOpcoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewOpcoes.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                string cellValue = dataGridViewOpcoes.Rows[e.RowIndex].Cells["AtivoCheckBox"].Value.ToString();
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

        private void dataGridViewOpcoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                rowData = dataGridViewOpcoes.Rows[e.RowIndex];
                Parametros.idOpcao = int.Parse(rowData.Cells[0].Value.ToString());
                bll.PegarDados((int)Parametros.idOpcao);
                AtribuirDadosAosInputs();
            }
        }

        private void dataGridViewOpcoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOpcoes.Columns[e.ColumnIndex].Name == "AtivoCheckBox")
            {
                rowData = dataGridViewOpcoes.Rows[e.RowIndex];
                DataGridViewCheckBoxCell chk = dataGridViewOpcoes.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                string valor = chk.Value.ToString();
                if (valor == "S")
                {
                    bllGeral.AtivarDesativar("opcoes", "id_opcao", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesativar("opcoes", "id_opcao", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarOpcoes();
            }
        }

        private void dataGridViewOpcoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (funcoes.VerificarPermissao(4))
                {
                    if (pnlCadastro.Enabled)
                    {
                        if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                        {
                            EditarOpcao();
                            VoltarAoPadrao();
                        }
                    }
                    else
                    {
                        cadastrarOuEditar = 'E';
                        btnEditar.Text = "Salvar";
                        dataGridViewOpcoes.Enabled = false;
                        pnlCadastro.Enabled = true;
                        btnCancelar.Enabled = true;
                        inputNomeOpcao.Focus();
                    }
                }
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
            CarregarOpcoes();
        }
    }
}
