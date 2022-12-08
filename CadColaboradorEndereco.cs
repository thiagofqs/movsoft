using CRUD.CODE.BLL;
using CRUD.CODE.DTO;

namespace MovSoft
{
    public partial class CadColaboradorEndereco : Form
    {
        ColaboradoresBLL bllColaboradores = new();
        ColaboradoresDTO dtoColaboradores = new();
        EnderecosDTO dtoEnderecos = new();
        ContatosDTO dtoContatos = new();
        Endereco enderecoColaborador = new();
        CadColaboradorPessoal.Dados dadosColaborador;
        private bool editarColaborador = false;
        public struct Endereco
        {
            public int idEndereco;
            public string cep;
            public string logradouro;
            public string numero;
            public string complemento;
            public string cidade;
            public string bairro;
            public string uf;
        }

        public CadColaboradorEndereco(CadColaboradorPessoal.Dados dadosColaboradorRetornado, bool primeiraAbertura, Endereco enderecoColaboradorRetornado, bool editarColaboradorRetornado)
        {
            InitializeComponent();
            RemoverMascarasDeTexto();
            dadosColaborador = dadosColaboradorRetornado;
            if (primeiraAbertura == false)
            {
                enderecoColaborador = enderecoColaboradorRetornado;
                AtribuirDadosAosInputs();
            }
            if(editarColaboradorRetornado == true)
            {
                enderecoColaborador = enderecoColaboradorRetornado;
                txtTitulo.Text = "Editar Colaborador 2/2";
                btnCadastrar.Text = "Salvar";
                editarColaborador = true;
                AtribuirDadosAosInputs();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            inputCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        private void CadastrarColaborador()
        {
            dtoColaboradores.Nome = dadosColaborador.nome;
            dtoColaboradores.Sobrenome = dadosColaborador.sobrenome;
            dtoColaboradores.Id_sexo = dadosColaborador.idSexo;
            dtoColaboradores.Cpf = dadosColaborador.cpf;
            dtoColaboradores.Data_nasc = dadosColaborador.nascimento;
            dtoColaboradores.Email = dadosColaborador.email;
            dtoEnderecos.Cep = enderecoColaborador.cep;
            dtoEnderecos.Logradouro = enderecoColaborador.logradouro;
            dtoEnderecos.Numero = enderecoColaborador.numero;
            dtoEnderecos.Complemento = enderecoColaborador.complemento;
            dtoEnderecos.Bairro = enderecoColaborador.bairro;
            dtoEnderecos.Cidade = enderecoColaborador.cidade;
            dtoEnderecos.Estado = enderecoColaborador.uf;
            dtoContatos.Ddd = dadosColaborador.ddd;
            dtoContatos.Celular = dadosColaborador.celular;
            bllColaboradores.CadastrarColaborador(dtoColaboradores, dtoEnderecos, dtoContatos);
            ActiveForm.Close();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaColaboradores
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaColaboradores)qrForm.First()).CarregarColaboradores();
            }
        }

        private void EditarColaborador()
        {
            dtoColaboradores.Id_colaborador = dadosColaborador.idColaborador;
            dtoEnderecos.Id_endereco = enderecoColaborador.idEndereco;
            dtoContatos.Id_celular = dadosColaborador.idCelular;
            dtoColaboradores.Nome = dadosColaborador.nome;
            dtoColaboradores.Sobrenome = dadosColaborador.sobrenome;
            dtoColaboradores.Id_sexo = dadosColaborador.idSexo;
            dtoColaboradores.Cpf = dadosColaborador.cpf;
            dtoColaboradores.Data_nasc = dadosColaborador.nascimento;
            dtoColaboradores.Email = dadosColaborador.email;
            dtoEnderecos.Cep = enderecoColaborador.cep;
            dtoEnderecos.Logradouro = enderecoColaborador.logradouro;
            dtoEnderecos.Numero = enderecoColaborador.numero;
            dtoEnderecos.Complemento = enderecoColaborador.complemento;
            dtoEnderecos.Bairro = enderecoColaborador.bairro;
            dtoEnderecos.Cidade = enderecoColaborador.cidade;
            dtoEnderecos.Estado = enderecoColaborador.uf;
            dtoContatos.Ddd = dadosColaborador.ddd;
            dtoContatos.Celular = dadosColaborador.celular;
            bllColaboradores.EditarColaborador(dtoColaboradores, dtoEnderecos, dtoContatos);
            ActiveForm.Close();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is ListaColaboradores
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((ListaColaboradores)qrForm.First()).CarregarColaboradores();
            }
    }

        private void AtribuirDadosAosInputs()
        {
            inputCep.Text = enderecoColaborador.cep;
            inputLogradouro.Text = enderecoColaborador.logradouro;
            inputNumero.Text = enderecoColaborador.numero;
            inputComplemento.Text = enderecoColaborador.complemento;
            inputBairro.Text = enderecoColaborador.bairro;
            inputCidade.Text = enderecoColaborador.cidade;
            inputboxUf.Text = enderecoColaborador.uf;
        }

        private void AtribuirDadosDosInputs()
        {
            enderecoColaborador.cep = inputCep.Text;
            enderecoColaborador.logradouro = inputLogradouro.Text;
            enderecoColaborador.numero = inputNumero.Text;
            enderecoColaborador.complemento = inputComplemento.Text;
            enderecoColaborador.bairro = inputBairro.Text;
            enderecoColaborador.cidade = inputCidade.Text;
            enderecoColaborador.uf = inputboxUf.Text;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            AtribuirDadosDosInputs();
            if(inputCep.Text == "" || inputLogradouro.Text == "" || inputNumero.Text == "" || inputBairro.Text == "" || inputCidade.Text == "" || inputboxUf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else if (editarColaborador == false)
            {
                CadastrarColaborador();
            }
            else if(editarColaborador == true)
            {
                EditarColaborador();
            }
        }

        private void botaoVoltar_MouseClick(object sender, MouseEventArgs e)
        {
            AtribuirDadosDosInputs();
            if (editarColaborador == true)
            {
                var qrForm = from frm in Application.OpenForms.Cast<Form>()
                             where frm is CadColaborador
                             select frm;
                if (qrForm != null && qrForm.Count() > 0)
                {
                    ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorPessoalEditar(dadosColaborador);
                }
            }
            else if (editarColaborador == false)
            {
                var qrForm = from frm in Application.OpenForms.Cast<Form>()
                             where frm is CadColaborador
                             select frm;
                if (qrForm != null && qrForm.Count() > 0)
                {
                    ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorPessoal(enderecoColaborador);
                }
            }
        }
    }
}
