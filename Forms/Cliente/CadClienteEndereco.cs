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
            PosicionarObrs();
            funcoes.PrimeiroInputEmFoco(inputCep);
            if (!primeiraAbertura)
            {
                AtribuirDadosAosInputs();
            }
            if (editar)
            {
                txtTitulo.Text = "Editar Colaborador 2/2";
                btnCadastrar.Text = "Salvar";
                editarCliente = true;
                AtribuirDadosAosInputs();
            }
        }

        private void PosicionarObrs()
        {
            funcoes.PosicionarObrFilho(txtCep, txtObr1);
            funcoes.PosicionarObrFilho(txtLogradouro, txtObr2);
            funcoes.PosicionarObrFilho(txtNumero, txtObr3);
            funcoes.PosicionarObrFilho(txtBairro, txtObr4);
            funcoes.PosicionarObrFilho(txtCidade, txtObr5);
            funcoes.PosicionarObrFilho(txtUf, txtObr6);
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
            dtoEnderecos.Uf = Parametros.uf;
            dtoContatos.Ddd = Parametros.dddCliente;
            dtoContatos.Celular = Parametros.celularCliente;
            bllClientes.CadastrarCliente(dtoClientes, dtoEnderecos, dtoContatos);
            ActiveForm.Close();
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
            dtoEnderecos.Uf = Parametros.uf;
            dtoContatos.Ddd = Parametros.dddCliente;
            dtoContatos.Celular = Parametros.celularCliente;
            bllClientes.EditarCliente(dtoClientes, dtoEnderecos, dtoContatos);
            Close();
            GC.Collect();
        }

        private void AtualizarClientes()
        {
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
            VerificarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AtribuirDadosDosInputs();
            Close();
            GC.Collect();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is CadCliente
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((CadCliente)qrForm.First()).AbrirTelaCadClientePessoal(false, editarCliente);
            }
        }

        private void CadastrarOuEditar()
        {
            AtribuirDadosDosInputs();
            if (!editarCliente)
            {
                CadastrarCliente();
                AtualizarClientes();
            }
            else if (editarCliente)
            {
                EditarCliente();
                AtualizarClientes();
            }
        }

        private void VerificarCampos()
        {
            if (inputCep.Text == "" || inputLogradouro.Text == "" || inputNumero.Text == "" || inputBairro.Text == "" || inputCidade.Text == "" || inputboxUf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else
            {
                CadastrarOuEditar();
            }
        }

        private void AtribuirDadosDoCepAosInputs(CepModel cepModel)
        {
            inputCep.Text = cepModel.Cep;
            inputLogradouro.Text = cepModel.Logradouro;
            inputBairro.Text = cepModel.Bairro;
            inputComplemento.Text = cepModel.Complemento;
            inputCidade.Text = cepModel.Localidade;
            inputboxUf.Text = cepModel.Uf;
        }

        private void VerificarCep()
        {
            if (!string.IsNullOrWhiteSpace(inputCep.Text.Trim()))
            {
                string url = $"https://viacep.com.br/ws/{inputCep.Text}/json/";
                string? result = funcoes.getApiResult(url);
                CepModel cepModel = JsonConvert.DeserializeObject<CepModel>(result);
                AtribuirDadosDoCepAosInputs(cepModel);
            }
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            VerificarCep();
        }

        private void inputCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCep();
            }
        }
    }
}