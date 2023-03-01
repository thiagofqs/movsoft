using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using Newtonsoft.Json;

namespace MovSoft
{
    public partial class CadColaboradorEndereco : Form
    {
        Funcoes funcoes = new();
        ColaboradoresBLL bllColaboradores = new();
        ColaboradoresDTO dtoColaboradores = new();
        EnderecosDTO dtoEnderecos = new();
        ContatosDTO dtoContatos = new();
        private bool editarColaborador = false;

        public CadColaboradorEndereco(bool primeiraAbertura, bool editar)
        {
            InitializeComponent();
            RemoverMascarasDeTexto();
            funcoes.PrimeiroInputEmFoco(inputCep);
            if (!primeiraAbertura)
            {
                AtribuirDadosAosInputs();
            }
            if(editar)
            {
                txtTitulo.Text = "Editar Colaborador 2/2";
                btnCadastrar.Text = "Salvar";
                editarColaborador = true;
                AtribuirDadosAosInputs();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            funcoes.RemoverMascarasDeTexto(inputCep);
        }

        private void AtualizarColaboradores()
        {
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaColaboradores
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaColaboradores)qrForm.First()).CarregarColaboradores();
            }
        }

        private void CadastrarColaborador()
        {
            dtoColaboradores.Nome = Parametros.nomeColab;
            dtoColaboradores.Sobrenome = Parametros.sobrenomeColab;
            dtoColaboradores.Id_sexo = (int)Parametros.idSexoColab;
            dtoColaboradores.Cpf = Parametros.cpfColab;
            dtoColaboradores.Data_nasc = Parametros.nascimentoColab;
            dtoColaboradores.Email = Parametros.emailColab;
            dtoEnderecos.Cep = Parametros.cep;
            dtoEnderecos.Logradouro = Parametros.logradouro;
            dtoEnderecos.Numero = Parametros.numero;
            dtoEnderecos.Complemento = Parametros.complemento;
            dtoEnderecos.Bairro = Parametros.bairro;
            dtoEnderecos.Cidade = Parametros.cidade;
            dtoEnderecos.Uf = Parametros.uf;
            dtoContatos.Ddd = Parametros.dddColab;
            dtoContatos.Celular = Parametros.celularColab;
            bllColaboradores.CadastrarColaborador(dtoColaboradores, dtoEnderecos, dtoContatos);
            //ActiveForm.Close();
        }

        private void EditarColaborador()
        {
            dtoColaboradores.Id_colaborador = (int)Parametros.idColab;
            dtoEnderecos.Id_endereco = (int)Parametros.idEndereco;
            dtoContatos.Id_celular = (int)Parametros.idCelularColab;
            dtoColaboradores.Nome = Parametros.nomeColab;
            dtoColaboradores.Sobrenome = Parametros.sobrenomeColab;
            dtoColaboradores.Id_sexo = (int)Parametros.idSexoColab;
            dtoColaboradores.Cpf = Parametros.cpfColab;
            dtoColaboradores.Data_nasc = Parametros.nascimentoColab;
            dtoColaboradores.Email = Parametros.emailColab;
            dtoEnderecos.Cep = Parametros.cep;
            dtoEnderecos.Logradouro = Parametros.logradouro;
            dtoEnderecos.Numero = Parametros.numero;
            dtoEnderecos.Complemento = Parametros.complemento;
            dtoEnderecos.Bairro = Parametros.bairro;
            dtoEnderecos.Cidade = Parametros.cidade;
            dtoEnderecos.Uf = Parametros.uf;
            dtoContatos.Ddd = Parametros.dddColab;
            dtoContatos.Celular = Parametros.celularColab;
            bllColaboradores.EditarColaborador(dtoColaboradores, dtoEnderecos, dtoContatos);
            //ActiveForm.Close();
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

        private void VerificarCampos()
        {
            if (inputCep.Text == "" || inputLogradouro.Text == "" || inputNumero.Text == "" || inputBairro.Text == "" || inputCidade.Text == "" || inputboxUf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            } else
            {
                CadastrarOuEditar();
            }
        }

        private void CadastrarOuEditar()
        {
            if (!editarColaborador)
            {
                CadastrarColaborador();
                AtualizarColaboradores();
            }
            else if (editarColaborador)
            {
                EditarColaborador();
                AtualizarColaboradores();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AtribuirDadosDosInputs();
            VerificarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AtribuirDadosDosInputs();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is CadColaborador
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorPessoal(false, editarColaborador);
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

        private void inputCep_Leave(object sender, EventArgs e)
        {
            VerificarCep();
        }
    }
}