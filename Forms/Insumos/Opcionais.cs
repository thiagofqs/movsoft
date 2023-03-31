using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft.Forms
{
    public partial class Opcionais : Form
    {
        Funcoes funcoes = new Funcoes();
        OpcionaisBLL bll = new();
        OpcionaisDTO dto = new();
        DataGridViewRow rowData = new();
        GeralBLL bllGeral = new();
        string? filtro = null;
        char cadastrarOuEditar; //Cadastrar = 'C' | Editar = 'E'

        public Opcionais()
        {
            InitializeComponent();
            CarregarOpcionais();
            comboBoxFiltro.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
            funcoes.CriarColunaComCheckbox(dataGridViewOpcionais);
        }

        public void CarregarOpcionais()
        {
            dataGridViewOpcionais.DataSource = bll.MostrarOpcionais(filtro);
            dataGridViewOpcionais.Columns[2].HeaderText = "Quantidade Marcações";
            foreach (DataGridViewColumn column in dataGridViewOpcionais.Columns)
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

        private void AtribuirDadosDosInputs(bool editar)
        {
            if (editar)
            {
                dto.IdOpcional = (int)Parametros.idGrupo;
            }
            if (toggleButtonAtivo.Checked)
            {
                dto.Ativo = "S";
            }
            else
            {
                dto.Ativo = "N";
            }
            dto.Opcional = inputNomeOpcional.Text;
            dto.QuantidadeMarcacoes = (int)numericUpDownOpcionais.Value;
        }

        private void AtribuirDadosAosInputs()
        {
            inputNomeOpcional.Text = Parametros.nomeOpcional;
            numericUpDownOpcionais.Value = (int)Parametros.quantidadeMarcacoes;
            if (Parametros.opcionalAtivo == "S")
            {
                toggleButtonAtivo.Checked = true;
            }
            else
            {
                toggleButtonAtivo.Checked = false;
            }
        }

        private void CadastrarOpcional()
        {
            AtribuirDadosDosInputs(false);
            bll.CadastrarOpcional(dto);
            CarregarOpcionais();
        }

        private void EditarOpcional()
        {
            AtribuirDadosDosInputs(true);
            bll.EditarOpcional(dto);
            CarregarOpcionais();
        }

        private void PesquisarOpcionais()
        {
            comboBoxFiltro.SelectedIndex = 0;
            dataGridViewOpcionais.DataSource = bll.PesquisarOpcional(inputPesquisar.Text);
        }

        private void LimparCampos()
        {
            inputNomeOpcional.Text = "";
            numericUpDownOpcionais.Text = "0";
            toggleButtonAtivo.Checked = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(4))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        CadastrarOpcional();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'C';
                    dataGridViewOpcionais.Enabled = false;
                    btnCadastrar.Text = "Salvar";
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeOpcional.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar opcionais", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarAoPadrao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarOpcionais();
        }

        private void inputPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarOpcionais();
            }
        }

        private void VoltarAoPadrao()
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewOpcionais.Enabled = true;
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(5))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        EditarOpcional();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'E';
                    btnEditar.Text = "Salvar";
                    dataGridViewOpcionais.Enabled = false;
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeOpcional.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para editar opcionais", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void dataGridViewOpcionais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (funcoes.VerificarPermissao(4))
                {
                    if (pnlCadastro.Enabled)
                    {
                        if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                        {
                            EditarOpcional();
                            VoltarAoPadrao();
                        }
                    }
                    else
                    {
                        cadastrarOuEditar = 'E';
                        btnEditar.Text = "Salvar";
                        dataGridViewOpcionais.Enabled = false;
                        pnlCadastro.Enabled = true;
                        btnCancelar.Enabled = true;
                        inputNomeOpcional.Focus();
                    }
                }
                else
                {
                    MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar grupos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btnAdicionarOpcoes_Click(object sender, EventArgs e)
        {
            Opcoes frm = new((int)Parametros.idOpcional);
            funcoes.AbrirForms(frm, 2, 1);
        }

        private void dataGridViewOpcionais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                rowData = dataGridViewOpcionais.Rows[e.RowIndex];
                Parametros.idGrupo = int.Parse(rowData.Cells[0].Value.ToString());
                bll.PegarDados((int)Parametros.idGrupo);
                AtribuirDadosAosInputs();
            }
        }

        private void dataGridViewOpcionais_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewOpcionais.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                string cellValue = dataGridViewOpcionais.Rows[e.RowIndex].Cells["AtivoCheckBox"].Value.ToString();
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

        private void dataGridViewOpcionais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOpcionais.Columns[e.ColumnIndex].Name == "AtivoCheckBox")
            {
                rowData = dataGridViewOpcionais.Rows[e.RowIndex];
                DataGridViewCheckBoxCell chk = dataGridViewOpcionais.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                string valor = chk.Value.ToString();
                if (valor == "S")
                {
                    bllGeral.AtivarDesativar("opcionais", "id_opcional", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesativar("opcionais", "id_opcional", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarOpcionais();
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
            CarregarOpcionais();
        }
    }
}