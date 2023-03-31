using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft.Forms
{
    public partial class ProdutosFinais : Form
    {
        Funcoes funcoes = new();
        ProdutosBLL bll = new();
        ProdutosDTO dto = new();
        DataGridViewRow rowData = new();
        GeralBLL bllGeral = new();
        string? filtro = null;
        char cadastrarOuEditar; //Cadastrar = 'C' | Editar = 'E'

        public ProdutosFinais()
        {
            InitializeComponent();
            CarregarProdutos();
            comboBoxFiltro.SelectedIndex = 0;
            comboBoxUnidadeDeMedida.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, tabControlProdutos);
            funcoes.CriarColunaComCheckbox(dataGridViewProdutosFinais);
        }

        public void CarregarProdutos()
        {
            dataGridViewProdutosFinais.DataSource = bll.MostrarProdutos(filtro, Parametros.nomeGrupo);
            dataGridViewProdutosFinais.Columns[3].HeaderText = "Preço";
            dataGridViewProdutosFinais.Columns[3].DefaultCellStyle.Format = "C";
            foreach (DataGridViewColumn column in dataGridViewProdutosFinais.Columns)
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

        private void PesquisarProdutos()
        {
            comboBoxFiltro.SelectedIndex = 0;
            dataGridViewProdutosFinais.DataSource = bll.PesquisarProdutos(inputPesquisar.Text);
        }

        private void LimparCampos()
        {
            inputNomeProduto.Text = "";
            numericUpDownPreco.Text = "0,00";
            toggleButtonAtivo.Checked = true;
        }

        private void VoltarAoPadrao()
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewProdutosFinais.Enabled = true;
            tabControlProdutos.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void AtribuirDadosDosInputs(bool editar)
        {
            if (editar)
            {
                dto.Id_produto = (int)Parametros.idProduto;
            }
            if (toggleButtonAtivo.Checked)
            {
                dto.Ativo = "S";
            }
            else
            {
                dto.Ativo = "N";
            }
        }

        private void AtribuirDadosAosInputs()
        {
            inputNomeProduto.Text = Parametros.nomeProduto;
            numericUpDownPreco.Value = (decimal)Parametros.precoProduto;
            if (Parametros.produtoAtivo == "S")
            {
                toggleButtonAtivo.Checked = true;
            }
            else
            {
                toggleButtonAtivo.Checked = false;
            }
        }

        private void CadastrarProduto()
        {
            AtribuirDadosDosInputs(false);
            bll.CadastrarProdutos(dto);
            CarregarProdutos();
        }

        private void EditarProduto()
        {
            AtribuirDadosDosInputs(true);
            bll.EditarProduto(dto);
            CarregarProdutos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(5))
            {
                if (tabControlProdutos.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(tabControlProdutos))
                    {
                        CadastrarProduto();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'C';
                    dataGridViewProdutosFinais.Enabled = false;
                    btnCadastrar.Text = "Salvar";
                    tabControlProdutos.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeProduto.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar produtos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarAoPadrao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(4))
            {
                if (tabControlProdutos.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(tabControlProdutos))
                    {
                        EditarProduto();
                        VoltarAoPadrao();
                    }
                }
                else
                {
                    cadastrarOuEditar = 'E';
                    btnEditar.Text = "Salvar";
                    dataGridViewProdutosFinais.Enabled = false;
                    tabControlProdutos.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeProduto.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para editar produtos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void inputPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarProdutos();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        private void dataGridViewProdutosFinais_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewProdutosFinais.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                string cellValue = dataGridViewProdutosFinais.Rows[e.RowIndex].Cells["AtivoCheckBox"].Value.ToString();
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

        private void dataGridViewProdutosFinais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                rowData = dataGridViewProdutosFinais.Rows[e.RowIndex];
                Parametros.idProduto = int.Parse(rowData.Cells[0].Value.ToString());
                bll.PegarDados((int)Parametros.idProduto);
                AtribuirDadosAosInputs();
            }
        }

        private void dataGridViewProdutosFinais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProdutosFinais.Columns[e.ColumnIndex].Name == "AtivoCheckBox")
            {
                rowData = dataGridViewProdutosFinais.Rows[e.RowIndex];
                DataGridViewCheckBoxCell chk = dataGridViewProdutosFinais.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                string valor = chk.Value.ToString();
                if (valor == "S")
                {
                    bllGeral.AtivarDesativar("produtos", "id_produto", int.Parse(rowData.Cells[0].Value.ToString()), "N");
                }
                else
                {
                    bllGeral.AtivarDesativar("produtos", "id_produto", int.Parse(rowData.Cells[0].Value.ToString()), "S");
                }
                CarregarProdutos();
            }
        }

        private void dataGridViewProdutosFinais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (funcoes.VerificarPermissao(4))
                {
                    if (tabControlProdutos.Enabled)
                    {
                        if (!funcoes.VerificarSeInputEstaVazio(tabControlProdutos))
                        {
                            EditarProduto();
                            VoltarAoPadrao();
                        }
                    }
                    else
                    {
                        cadastrarOuEditar = 'E';
                        btnEditar.Text = "Salvar";
                        dataGridViewProdutosFinais.Enabled = false;
                        tabControlProdutos.Enabled = true;
                        btnCancelar.Enabled = true;
                        inputNomeProduto.Focus();
                    }
                }
                else
                {
                    MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar opção", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
            CarregarProdutos();
        }

        private void btnVincularComponentes_Click(object sender, EventArgs e)
        {
            VincularComponentes frm = new((int)Parametros.idProduto);
            funcoes.AbrirForms(frm, 2, 1);
        }

        private void btnVincularOpcionais_Click(object sender, EventArgs e)
        {
            VincularOpcionais frm = new();
            funcoes.AbrirForms(frm, 2, 1);
        }
    }
}
