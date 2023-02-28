using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using Newtonsoft.Json;

namespace MovSoft
{
    public partial class CadClienteEndereco : Form
    {
        Funcoes funcoes = new();
        ClientesBLL bllClientes = new();
        ClientesDTO dtoClientes = new();
        EnderecosDTO dtoEnderecos = new();
        ContatosDTO dtoContatos = new();
        private bool editarCliente = false;
        public CadClienteEndereco(bool primeiraAbertura, bool editar)
        {
            InitializeComponent();
            RemoverMascarasDeTexto();
            if (primeiraAbertura == false)
            {
                AtribuirDadosAosInputs();
            }
            if (editar == true)
            {
                txtTitulo.Text = "Editar Colaborador 2/2";
                btnCadastrar.Text = "Salvar";
                editarCliente = true;
                AtribuirDadosAosInputs();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            funcoes.RemoverMascarasDeTexto(inputCep);
        }

        private void CadastrarCliente()
        {
            dtoClientes.Nome = Parametros.nomeCliente;
            dtoClientes.Sobrenome = Parametros.sobrenomeCliente;
            dtoClientes.Id_sexo = (int)Parametros.idSexoCliente;
            dtoClientes.Cpf = Parametros.cpfCliente;
            dtoClientes.Data_nasc = Parametros.nascimentoCliente;
            dtoClientes.Email = Parametros.emailCliente;
            dtoEnderecos.Cep = Parametros.cep;
            dtoEnderecos.Logradouro = Parametros.logradouro;
            dtoEnderecos.Numero = Parametros.numero;
            dtoEnderecos.Complemento = Parametros.complemento;
            dtoEnderecos.Bairro = Parametros.bairro;
            dtoEnderecos.Cidade = Parametros.cidade;
            dtoEnderecos.Estado = Parametros.uf;
            dtoContatos.Ddd = Parametros.dddCliente;
            dtoContatos.Celular = Parametros.celularCliente;
            bllClientes.CadastrarCliente(dtoClientes, dtoEnderecos, dtoContatos);
            Parametros parametros = new();
            ActiveForm.Close();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaClientes
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaClientes)qrForm.First()).CarregarClientes();
            }
        }

        private void EditarCliente()
        {
            dtoClientes.Id_cliente = (int)Parametros.idCliente;
            dtoEnderecos.Id_endereco = (int)Parametros.idEndereco;
            dtoContatos.Id_celular = (int)Parametros.idCelularCliente;
            dtoClientes.Nome = Parametros.nomeCliente;
            dtoClientes.Sobrenome = Parametros.sobrenomeCliente;
            dtoClientes.Id_sexo = (int)Parametros.idSexoCliente;
            dtoClientes.Cpf = Parametros.cpfCliente;
            dtoClientes.Data_nasc = Parametros.nascimentoCliente;
            dtoClientes.Email = Parametros.emailCliente;
            dtoEnderecos.Cep = Parametros.cep;
            dtoEnderecos.Logradouro = Parametros.logradouro;
            dtoEnderecos.Numero = Parametros.numero;
            dtoEnderecos.Complemento = Parametros.complemento;
            dtoEnderecos.Bairro = Parametros.bairro;
            dtoEnderecos.Cidade = Parametros.cidade;
            dtoEnderecos.Estado = Parametros.uf;
            dtoContatos.Ddd = Parametros.dddCliente;
            dtoContatos.Celular = Parametros.celularCliente;
            bllClientes.EditarCliente(dtoClientes, dtoEnderecos, dtoContatos);
            ActiveForm.Close();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaClientes
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaClientes)qrForm.First()).CarregarClientes();
            }
        }

        private void AtribuirDadosAosInputs()
        {
            inputCep.Text = Parametros.cep;
            inputLogradouro.Text = Parametros.logradouro;
            inputNumero.Text = Parametros.numero;
            inputComplemento.Text = Parametros.complemento;
            inputBairro.Text = Parametros.bairro;
            inputCidade.Text = Parametros.cidade;
            inputboxUf.Text = Parametros.uf;
        }

        private void AtribuirDadosDosInputs()
        {
            Parametros.cep = inputCep.Text;
            Parametros.logradouro = inputLogradouro.Text;
            Parametros.numero = inputNumero.Text;
            Parametros.complemento = inputComplemento.Text;
            Parametros.bairro = inputBairro.Text;
            Parametros.cidade = inputCidade.Text;
            Parametros.uf = inputboxUf.Text;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AtribuirDadosDosInputs();
            if (inputCep.Text == "" || inputLogradouro.Text == "" || inputNumero.Text == "" || inputBairro.Text == "" || inputCidade.Text == "" || inputboxUf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else if (editarCliente == false)
            {
                CadastrarCliente();
            }
            else if (editarCliente == true)
            {
                EditarCliente();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AtribuirDadosDosInputs();
            if (editarCliente == true)
            {
                var qrForm = from frm in Application.OpenForms.Cast<Form>()
                             where frm is CadCliente
                             select frm;
                if (qrForm != null && qrForm.Count() > 0)
                {
                    ((CadCliente)qrForm.First()).AbrirTelaCadClientePessoal(false, editarCliente);
                }
            }
            else if (editarCliente == false)
            {
                var qrForm = from frm in Application.OpenForms.Cast<Form>()
                             where frm is CadCliente
                             select frm;
                if (qrForm != null && qrForm.Count() > 0)
                {
                    ((CadCliente)qrForm.First()).AbrirTelaCadClientePessoal(false, editarCliente);
                }
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
    }
}