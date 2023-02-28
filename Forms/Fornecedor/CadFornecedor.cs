using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using Newtonsoft.Json;

namespace MovSoft
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
            if(editar == true)
            {
                editarFornecedor = true;
                AtribuirDadosAosInputs();
                txtTitulo.Text = "Editar Fornecedor 1/2";
                fornecedoresBLL.PegarDados((int)Parametros.idFornecedor);
                fornecedoresBLL.PegarEndereco((int)Parametros.idFornecedor);
                AtribuirDadosAosInputs();
            }
            else
            {
                editarFornecedor = false;
            }
        }

        private void EditarFornecedor()
        {
            //fornecedoresDTO.Nome_fantasia = inputNomeFantasia.Text;
            fornecedoresDTO.Razao_social = inputRazaoSocial.Text;
            fornecedoresDTO.Cnpj = inputCnpj.Text;
            EnderecosDTO.Cep = inputCep.Text;
            EnderecosDTO.Estado = inputboxUf.Text;
            EnderecosDTO.Cidade = inputCidade.Text;
            EnderecosDTO.Bairro = inputBairro.Text;
            EnderecosDTO.Logradouro = inputLogradouro.Text;
            EnderecosDTO.Complemento = inputComplemento.Text;
            fornecedoresBLL.EditarFornecedor(fornecedoresDTO, EnderecosDTO);
            Parametros parametros = new();
            ActiveForm.Close();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaFornecedores
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaFornecedores)qrForm.First()).CarregarFornecedores();
            }
        }

        private void CadastrarFornecedor()
        {
            //fornecedoresDTO.Nome_fantasia = inputNomeFantasia.Text;
            fornecedoresDTO.Razao_social = inputRazaoSocial.Text;
            fornecedoresDTO.Cnpj = inputCnpj.Text;
            EnderecosDTO.Cep = inputCep.Text;
            EnderecosDTO.Estado = inputboxUf.Text;
            EnderecosDTO.Cidade = inputCidade.Text;
            EnderecosDTO.Bairro = inputBairro.Text;
            EnderecosDTO.Logradouro = inputLogradouro.Text;
            EnderecosDTO.Complemento = inputComplemento.Text;
            fornecedoresBLL.CadastrarFornecedor(fornecedoresDTO, EnderecosDTO);
            Parametros parametros = new();
            ActiveForm.Close();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaFornecedores
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaFornecedores)qrForm.First()).CarregarFornecedores();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            funcoes.RemoverMascarasDeTexto(inputCnpj);
            funcoes.RemoverMascarasDeTexto(inputCep);
        }

        private void AtribuirDadosAosInputs()
        {
            inputRazaoSocial.Text = Parametros.nomeCliente;
            inputCnpj.Text = Parametros.cnpj;
            inputCep.Text = Parametros.cep;
            inputboxUf.Text = Parametros.uf;
            inputCidade.Text = Parametros.cidade;
            inputLogradouro.Text = Parametros.logradouro;
            inputNumero.Text = Parametros.numero;
            inputBairro.Text = Parametros.bairro;
            inputComplemento.Text = Parametros.complemento;
        }

        private void ContinuarCadastro()
        {
            AtribuirDadosDosInputs();
            if (inputNomeFantasia.Text == "" || inputRazaoSocial.Text == "" || inputCnpj.Text == "" || inputCep.Text == "" || inputLogradouro.Text == "" || inputNumero.Text == "" || inputBairro.Text == "" || inputCidade.Text == "" || inputboxUf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else
            {
                if (editarFornecedor == true)
                {
                    EditarFornecedor();
                }
                else
                {
                    CadastrarFornecedor();
                }
            }
        }

        private void AtribuirDadosDosInputs()
        {
            Parametros.nomeFantasia = inputNomeFantasia.Text;
            Parametros.razaoSocial = inputRazaoSocial.Text;
            Parametros.cnpj = inputCnpj.Text;
            Parametros.cep = inputCep.Text;
            Parametros.uf = inputboxUf.Text;
            Parametros.cidade = inputCidade.Text;
            Parametros.bairro = inputBairro.Text;
            Parametros.logradouro = inputLogradouro.Text;
            Parametros.complemento = inputComplemento.Text;
        }

        private void inputCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ContinuarCadastro();
            }
        }

        private void verificarCep()
        {
            if (!string.IsNullOrWhiteSpace(inputCep.Text.Trim()))
            {
                string url = $"https://viacep.com.br/ws/{inputCep.Text}/json/";
                string? result = funcoes.getApiResult(url);
                CepModel cepModel = JsonConvert.DeserializeObject<CepModel>(result);
                inputCep.Text = cepModel.Cep;
                inputLogradouro.Text = cepModel.Logradouro;
                inputBairro.Text = cepModel.Bairro;
                inputComplemento.Text = cepModel.Complemento;
                inputCidade.Text = cepModel.Localidade;
                inputboxUf.Text = cepModel.Uf;
            }
        }

        private void inputCep_Leave(object sender, EventArgs e)
        {
            verificarCep();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ContinuarCadastro();
        }
    }
}