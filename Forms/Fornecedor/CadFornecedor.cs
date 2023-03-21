using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using Newtonsoft.Json;

namespace MovSoft.Forms
{
    public partial class CadFornecedor : Form
    {
        Funcoes funcoes = new();
        FornecedoresBLL fornecedoresBLL = new();
        FornecedoresDTO fornecedoresDTO = new();
        EnderecosDTO EnderecosDTO = new();
        bool editarFornecedor = false;
        public CadFornecedor(bool editar)
        {
            InitializeComponent();
            RemoverMascarasDeTexto();
            inputNomeFantasia.Focus();
            funcoes.AjustarSelectorDosMaskedTextBox(pnlMain);
            if (editar)
            {
                editarFornecedor = true;
                fornecedoresBLL.PegarDados((int)Parametros.idFornecedor);
                fornecedoresBLL.PegarEndereco((int)Parametros.idFornecedor);
                txtTitulo.Text = "Editar Fornecedor 1/2";
                AtribuirDadosAosInputs();
            }
            else
            {
                editarFornecedor = false;
            }
        }

        private void AtualizarFornecedores()
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaFornecedores
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaFornecedores)qrForm.First()).CarregarFornecedores();
            }
        }

        private void EditarFornecedor()
        {
            fornecedoresDTO.Id_fornecedor = (int)Parametros.idFornecedor;
            fornecedoresDTO.Nome_fantasia = inputNomeFantasia.Text;
            fornecedoresDTO.Razao_social = inputRazaoSocial.Text;
            fornecedoresDTO.Cnpj = inputCnpj.Text;
            EnderecosDTO.Id_endereco = (int)Parametros.idEndereco;
            EnderecosDTO.Cep = inputCep.Text;
            EnderecosDTO.Uf = inputBoxUf.Text;
            EnderecosDTO.Cidade = inputCidade.Text;
            EnderecosDTO.Bairro = inputBairro.Text;
            EnderecosDTO.Logradouro = inputLogradouro.Text;
            EnderecosDTO.Numero = inputNumero.Text;
            EnderecosDTO.Complemento = inputComplemento.Text;
            fornecedoresDTO.Ativo = Parametros.FornecedorAtivo;
            fornecedoresBLL.EditarFornecedor(fornecedoresDTO, EnderecosDTO);
            ActiveForm.Close();
        }

        private void CadastrarFornecedor()
        {
            fornecedoresDTO.Nome_fantasia = inputNomeFantasia.Text;
            fornecedoresDTO.Razao_social = inputRazaoSocial.Text;
            fornecedoresDTO.Cnpj = inputCnpj.Text;
            fornecedoresDTO.Ativo = Parametros.FornecedorAtivo;
            EnderecosDTO.Cep = inputCep.Text;
            EnderecosDTO.Uf = inputBoxUf.Text;
            EnderecosDTO.Cidade = inputCidade.Text;
            EnderecosDTO.Bairro = inputBairro.Text;
            EnderecosDTO.Logradouro = inputLogradouro.Text;
            EnderecosDTO.Numero = inputNumero.Text;
            EnderecosDTO.Complemento = inputComplemento.Text;
            fornecedoresBLL.CadastrarFornecedor(fornecedoresDTO, EnderecosDTO);
            funcoes.LimparInputsDeUmControl(pnlMain);
            inputNomeFantasia.Focus();
        }

        private void RemoverMascarasDeTexto()
        {
            funcoes.RemoverMascarasDeTexto(inputCnpj);
            funcoes.RemoverMascarasDeTexto(inputCep);
        }

        private void AtribuirDadosAosInputs()
        {
            inputRazaoSocial.Text = Parametros.razaoSocial;
            inputNomeFantasia.Text = Parametros.nomeFantasia;
            inputCnpj.Text = Parametros.cnpj;
            inputCep.Text = Parametros.cep;
            inputBoxUf.Text = Parametros.uf;
            inputCidade.Text = Parametros.cidade;
            inputLogradouro.Text = Parametros.logradouro;
            inputNumero.Text = Parametros.numero;
            inputBairro.Text = Parametros.bairro;
            inputComplemento.Text = Parametros.complemento;
            if(Parametros.FornecedorAtivo == "S")
            {
                toggleButtonAtivo.Checked = true;
            }
            else
            {
                toggleButtonAtivo.Checked = false;
            }
        }

        private void CadastrarOuEditar()
        {
            AtribuirDadosDosInputs();
            if (editarFornecedor)
            {
                EditarFornecedor();
                AtualizarFornecedores();
            }
            else if (!editarFornecedor)
            {
                CadastrarFornecedor();
                AtualizarFornecedores();
            }
        }

        private void VerificarCampos()
        {
            if(!funcoes.VerificarSeInputEstaVazio(pnlMain))
            {
                CadastrarOuEditar();
            }
        }

        private void AtribuirDadosDosInputs()
        {
            Parametros.nomeFantasia = inputNomeFantasia.Text;
            Parametros.razaoSocial = inputRazaoSocial.Text;
            Parametros.cnpj = inputCnpj.Text;
            Parametros.cep = inputCep.Text;
            Parametros.uf = inputBoxUf.Text;
            Parametros.cidade = inputCidade.Text;
            Parametros.bairro = inputBairro.Text;
            Parametros.numero = inputNumero.Text;
            Parametros.logradouro = inputLogradouro.Text;
            Parametros.complemento = inputComplemento.Text;
            if(toggleButtonAtivo.Checked)
            {
                Parametros.FornecedorAtivo = "S";
            }
            else
            {
                Parametros.FornecedorAtivo = "N";
            }
        }

        private void LimparInputsLocalidade()
        {
            foreach (TextBox input in pnlMain.Controls.OfType<TextBox>())
            {
                if (input.TabIndex > 3)
                {
                    input.Clear();
                }
            }
            inputBoxUf.SelectedIndex = -1;
        }

        private void AtribuirDadosDoCepAosInputs(CepModel cepModel)
        {
            LimparInputsLocalidade();
            inputCep.Text = cepModel.Cep;
            inputLogradouro.Text = cepModel.Logradouro;
            inputBairro.Text = cepModel.Bairro;
            inputComplemento.Text = cepModel.Complemento;
            inputCidade.Text = cepModel.Localidade;
            inputBoxUf.Text = cepModel.Uf;
        }

        private async void VerificarCep()
        {
            if (!string.IsNullOrWhiteSpace(inputCep.Text.Trim()))
            {
                string url = $"https://viacep.com.br/ws/{inputCep.Text}/json/";
                string? resultado = await Task.Run(() => funcoes.GetApiResult(url));
                try
                {
                    CepModel cepModel = JsonConvert.DeserializeObject<CepModel>(resultado);
                    AtribuirDadosDoCepAosInputs(cepModel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("CEP inexistente! Por favor, insira um CEP válido e tente novamente.");
                }
            }
            else
            {
                LimparInputsLocalidade();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void inputCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCep();
            }
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            VerificarCep();
        }

        private void toggleButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificarCampos();
        }

        private void inputCep_Leave(object sender, EventArgs e)
        {
            VerificarCep();
        }
    }
}