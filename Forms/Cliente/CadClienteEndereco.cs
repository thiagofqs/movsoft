using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using Newtonsoft.Json;

namespace MovSoft.Forms
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
            inputCep.Focus();
            funcoes.AjustarSelectorDosMaskedTextBox(this);
            if (!primeiraAbertura)
            {
                AtribuirDadosAosInputs();
            }
            if (editar)
            {
                txtTitulo.Text = "Editar Cliente 2/2";
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
            dtoEnderecos.Uf = Parametros.uf;
            dtoContatos.Ddd = Parametros.dddCliente;
            dtoContatos.Celular = Parametros.celularCliente;
            dtoClientes.Ativo = Parametros.ClienteAtivo;
            bllClientes.CadastrarCliente(dtoClientes, dtoEnderecos, dtoContatos);
            AtualizarClientes();
            funcoes.LimparInputsDeUmControl(this);
            VoltarPagina(true);
            
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
            dtoClientes.Ativo = Parametros.ClienteAtivo;
            bllClientes.EditarCliente(dtoClientes, dtoEnderecos, dtoContatos);
            AtualizarClientes();
            ActiveForm.Close();
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
            inputBoxUf.Text = Parametros.uf;
        }

        private void AtribuirDadosDosInputs()
        {
            Parametros.cep = inputCep.Text;
            Parametros.logradouro = inputLogradouro.Text;
            Parametros.numero = inputNumero.Text;
            Parametros.complemento = inputComplemento.Text;
            Parametros.bairro = inputBairro.Text;
            Parametros.cidade = inputCidade.Text;
            Parametros.uf = inputBoxUf.Text;
        }

        private void CadastrarOuEditar()
        {
            AtribuirDadosDosInputs();
            if (!editarCliente)
            {
                CadastrarCliente();
            }
            else if (editarCliente)
            {
                EditarCliente();
            }
        }

        private void VerificarCampos()
        {
            if(!funcoes.VerificarSeInputEstaVazio(this))
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
            inputBoxUf.Text = cepModel.Uf;
        }

        private void LimparInputs()
        {
            foreach (TextBox input in Controls.OfType<TextBox>())
            {
                input.Clear();
            }
            inputBoxUf.SelectedIndex = -1;
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
                foreach (TextBox input in Controls.OfType<TextBox>())
                {
                    LimparInputs();
                }
            }
        }

        private void VoltarPagina(bool primeiraAbertura)
        {
            AtribuirDadosDosInputs();
            Close();
            GC.Collect();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is CadCliente
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((CadCliente)qrForm.First()).AbrirTelaCadClientePessoal(primeiraAbertura, editarCliente);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarPagina(false);
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

        private void inputBoxUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerificarCampos();
        }

        private void inputCep_Leave(object sender, EventArgs e)
        {
            VerificarCep();
        }
    }
}