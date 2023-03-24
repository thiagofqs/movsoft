using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;

namespace MovSoft.Forms
{
    public partial class ProdutosFinais : Form
    {
        Funcoes funcoes = new();
        GruposBLL bll = new();
        GruposDTO dto = new();
        string? filtro = null;
        char cadastrarOuEditar; //Cadastrar = 'C' | Editar = 'E'

        public ProdutosFinais()
        {
            InitializeComponent();
            CarregarProdutos();
            comboBoxFiltro.SelectedIndex = 0;
            comboBoxUnidadeDeMedida.SelectedIndex = 0;
            tabControlProdutos.Left = (Width - tabControlProdutos.Width) / 2;
        }

        private void PesquisarProdutos()
        {
            //dataGridViewProdutosFinais.DataSource = bll.PesquisarProdutos(inputPesquisar.Text);
        }

        private void LimparCampos()
        {
            inputNomeProduto.Text = "";
            kryptonCheckBoxControlarEstoque.Checked = false;
            comboBoxUnidadeDeMedida.Text = "";
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
        {/*
            if (editar)
            {
                dto.IdProduto = (int)Parametros.idProduto;
            }
            if (toggleButtonAtivo.Checked)
            {
                dto.Ativo = "S";
            }
            else
            {
                dto.Ativo = "N";
            }
            dto.Produto = inputNomeProduto.Text;*/
        }

        private void CarregarProdutos()
        {
            //dataGridViewProdutosFinais.DataSource = bll.MostrarProdutos(filtro);
        }

        private void CadastrarProduto()
        {
            AtribuirDadosDosInputs(false);
            //bll.CadastrarProduto(dto);
            CarregarProdutos();
        }

        private void EditarProduto()
        {
            AtribuirDadosDosInputs(true);
            //bll.EditarProduto(dto);
            CarregarProdutos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (funcoes.VerificarPermissao(5))
            {
                if (tabControlProdutos.Enabled)
                {
                    if (!(funcoes.VerificarSeInputEstaVazio(Geral) && funcoes.VerificarSeInputEstaVazio(Preco)))
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

        private void btnVincularComponentes_Click(object sender, EventArgs e)
        {
            VincularComponentes frm = new();
            funcoes.AbrirForms(frm, 2, 1);
        }

        private void btnVincularOpcionais_Click(object sender, EventArgs e)
        {
            VincularOpcionais frm = new();
            funcoes.AbrirForms(frm, 2, 1);
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
                    if (!(funcoes.VerificarSeInputEstaVazio(Geral) && funcoes.VerificarSeInputEstaVazio(Preco)))
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

        private void numericUpDownPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!funcoes.VerificarSeInputEstaVazio(tabControlProdutos))
                {
                    if (cadastrarOuEditar == 'C')
                    {
                        CadastrarProduto();
                    }
                    else if (cadastrarOuEditar == 'E')
                    {
                        EditarProduto();
                    }
                    VoltarAoPadrao();
                }
            }
        }

        private void inputNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!funcoes.VerificarSeInputEstaVazio(tabControlProdutos))
                {
                    if (cadastrarOuEditar == 'C')
                    {
                        CadastrarProduto();
                    }
                    else if (cadastrarOuEditar == 'E')
                    {
                        EditarProduto();
                    }
                    VoltarAoPadrao();
                }
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
    }
}
