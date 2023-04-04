using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using Mysqlx.Resultset;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace MovSoft.Forms
{
    public partial class ProdutosFinais : Form
    {
        Funcoes funcoes = new();
        ProdutosBLL bll = new();
        GruposBLL gruposBLL = new();
        ProdutosDTO dto = new();
        DataGridViewRow rowData = new();
        GeralBLL bllGeral = new();
        string? filtro = null;
        string? filtroGrupo = null;
        char cadastrarOuEditar; //Cadastrar = 'C' | Editar = 'E'

        public ProdutosFinais()
        {
            InitializeComponent();
            CarregarProdutos();
            comboBoxFiltro.SelectedIndex = 0;
            comboBoxFiltroGrupo.SelectedIndex = 0;
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
            funcoes.CriarColunaComCheckbox(dataGridViewProdutosFinais);
            MostrarGruposAtivos();
        }

        private void MostrarGruposAtivos()
        {
            DataTable dataTable = new();
            dataTable = gruposBLL.MostrarGrupos("S");
            foreach (DataRow row in dataTable.Rows)
            {
                comboBoxGrupo.Items.Add(row.ItemArray[1].ToString());
                comboBoxGrupo.AutoCompleteCustomSource.Add(row.ItemArray[1].ToString());
                comboBoxFiltroGrupo.Items.Add(row.ItemArray[1].ToString());
            }
        }

        public void CarregarProdutos()
        {
            dataGridViewProdutosFinais.DataSource = bll.MostrarProdutos(filtro, filtroGrupo);
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
            dataGridViewProdutosFinais.DataSource = bll.PesquisarProdutos(inputPesquisar.Text,filtroGrupo,filtro);
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
            comboBoxGrupo.SelectedIndex = -1;
            kryptonCheckBoxControlarEstoque.Checked = false;
            dataGridViewProdutosFinais.Enabled = true;
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
            dto.Produto = inputNomeProduto.Text;
            dto.Grupo = comboBoxGrupo.Text;
            dto.ControlaEstoque = kryptonCheckBoxControlarEstoque.Checked;
            dto.Preco = (float)numericUpDownPreco.Value;
        }

        private void AtribuirDadosAosInputs()
        {
            inputNomeProduto.Text = Parametros.nomeProduto;
            numericUpDownPreco.Value = (decimal)Parametros.precoProduto;
            kryptonCheckBoxControlarEstoque.Checked = (bool)Parametros.controlaEstoqueProduto;
            comboBoxGrupo.Text = Parametros.grupoProduto;
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
            dataGridViewProdutosFinais.CurrentCell = dataGridViewProdutosFinais.Rows[dataGridViewProdutosFinais.Rows.Count - 1].Cells[0];
        }

        private void EditarProduto()
        {
            AtribuirDadosDosInputs(true);
            bll.EditarProduto(dto);
        }

        private void verificacoesPreCadastro()
        {
            if (funcoes.VerificarPermissao(5))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
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
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeProduto.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar produtos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            verificacoesPreCadastro();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarAoPadrao();
            Parametros.idProduto = null;
        }

        private void VerificacoesPreEdicao()
        {
            if (funcoes.VerificarPermissao(4))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        EditarProduto();
                        VoltarAoPadrao();
                    }
                    else
                    {
                        Parametros.idProduto = null;
                    }
                }
                else
                {
                    cadastrarOuEditar = 'E';
                    btnEditar.Text = "Salvar";
                    dataGridViewProdutosFinais.Enabled = false;
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                    inputNomeProduto.Focus();
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para editar produtos", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            VerificacoesPreEdicao();
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
                    if (pnlCadastro.Enabled)
                    {
                        if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
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
                        pnlCadastro.Enabled = true;
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
            if (cadastrarOuEditar == 'C')
            {
                verificacoesPreCadastro();
            }
            else
            {
                VerificacoesPreEdicao();
            }
            if (Parametros.idProduto.HasValue)
            {
                VincularComponentes frm = new((int)Parametros.idProduto);
                funcoes.AbrirForms(frm, 2, 1);
                CarregarProdutos();
            }
        }

        private void btnVincularOpcionais_Click(object sender, EventArgs e)
        {
            if(cadastrarOuEditar == 'C')
            {
                verificacoesPreCadastro();
            }
            else
            {
                VerificacoesPreEdicao();
            }
            if (Parametros.idProduto.HasValue)
            {
                VincularOpcionais frm = new((int)Parametros.idProduto);
                funcoes.AbrirForms(frm, 2, 1);
                CarregarProdutos();
            }
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (!string.IsNullOrEmpty(comboBox.Text) && !comboBox.Items.Contains(comboBox.Text))
            {
                MessageBox.Show("O grupo inserido não existe", "Entrada de dados incorreta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void comboBoxFiltroGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltroGrupo.SelectedIndex == 0)
            {
                filtroGrupo = "";
            }
            else
            {
                filtroGrupo = comboBoxFiltroGrupo.Text;
            }
            CarregarProdutos();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            // Verifica se o item placeholder está presente na lista de itens
            if (comboBoxFiltroGrupo.Items.Contains("Grupos"))
            {
                // Remove o item placeholder
                comboBoxFiltroGrupo.Items.Remove("Grupos");
                comboBoxFiltroGrupo.SelectedIndex = 0;
            }
        }
    }
}
