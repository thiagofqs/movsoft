using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MovSoft.Forms
{
    public partial class HistoricoEstoque : Form
    {
        Funcoes funcoes = new();
        GeralBLL geralBLL = new GeralBLL();
        FornecedoresBLL fornecedoresBLL = new();
        HistoricoEstoqueBLL historicoEstoqueBLL = new();
        HistoricoEstoqueDTO dto = new();
        public HistoricoEstoque(bool lancarEstoqueNovo)
        {
            InitializeComponent();
            funcoes.CentralizarHorizontalmente(this, pnlCadastro);
            MostrarProdutosQueControlaEstoque();
            MostrarFornecedores();
            if (!lancarEstoqueNovo)
            {
                AtribuirDadosAosInputs();
                VerificacoesPreCadastro();
            }
        }

        private void AtribuirDadosAosInputs()
        {
            comboBox1.Text = Parametros.tipoItem;
            comboBoxProduto.Text = Parametros.nomeProduto;
        }
        private void LimparCampos()
        {
            comboBoxMovimento.Text = "";
            numericUpDownQuantidade.Text = "0";
        }

        private void MostrarProdutosQueControlaEstoque()
        {
            List<string> produtos = new();
            produtos = geralBLL.ProdutosQueControlamEstoque();
            foreach (string produto in produtos)
            {
                comboBoxProduto.Items.Add(produto);
            }
        }

        private void MostrarFornecedores()
        {
            List<string> fornecedores = new();
            fornecedores = fornecedoresBLL.FornecedoresAtivo();
            foreach (string fornecedor in fornecedores)
            {
                comboBoxFornecedor.Items.Add(fornecedor);
            }
        }

        public void verHistoricoItem(string item)
        {
            dataGridViewEstoque.DataSource = historicoEstoqueBLL.verHistoricoProduto(item, comboBox1.Text.Substring(0, 1));
            foreach (DataGridViewColumn column in dataGridViewEstoque.Columns)
            {
                if (column.Index == 0)
                {
                    column.Width = 50;
                }
                else if (column.Name == "Opcao")
                {
                    column.HeaderText = "Opção";
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void VoltarAoPadrao()
        {
            btnCadastrar.Text = "Cadastrar";
            dataGridViewEstoque.Enabled = true;
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void AtribuirDadosDosInputs()
        {
            string padrao = @"\[[A-Z]\]";
            string resultado = Regex.Replace(comboBoxProduto.Text, padrao, string.Empty);
            if (comboBox1.SelectedIndex == 0)
            {
                dto.Produto = resultado.Trim();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                dto.Componente = resultado.Trim();
            }
            else
            {
                dto.Item = resultado.Trim();
            }
            dto.Qtd = float.Parse(numericUpDownQuantidade.Value.ToString());
            dto.Fornecedor = comboBoxFornecedor.Text;
            dto.TipoMovimento = comboBoxMovimento.SelectedIndex;
        }

        private void CadastrarEstoque()
        {
            AtribuirDadosDosInputs();
            historicoEstoqueBLL.lancarEstoque(dto, comboBox1.Text.Substring(0, 1));
            string padrao = @"\[[A-Z]\]";
            string resultado = Regex.Replace(comboBoxProduto.Text, padrao, string.Empty);
            verHistoricoItem(resultado.Trim());
        }

        private void VerificacoesPreCadastro()
        {
            if (funcoes.VerificarPermissao(4))
            {
                if (pnlCadastro.Enabled)
                {
                    if (!funcoes.VerificarSeInputEstaVazio(pnlCadastro))
                    {
                        CadastrarEstoque();
                        VoltarAoPadrao();

                    }
                }
                else
                {
                    dataGridViewEstoque.Enabled = false;
                    btnCadastrar.Text = "Salvar";
                    pnlCadastro.Enabled = true;
                    btnCancelar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para cadastrar estoque", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            VerificacoesPreCadastro();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VoltarAoPadrao();
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxProduto.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {
                string padrao = @"\[[A-Z]\]";
                string resultado = Regex.Replace(comboBoxProduto.Text, padrao, string.Empty);
                verHistoricoItem(resultado.Trim());
            }
        }
    }
}
