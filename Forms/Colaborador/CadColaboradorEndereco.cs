﻿using MovSoft.Classes;
using MovSoft.CODE.BLL;
using MovSoft.CODE.DTO;
using Newtonsoft.Json;

namespace MovSoft.Forms
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
            inputCep.Focus();
            funcoes.AjustarSelectorDosMaskedTextBox(this);
            if (!primeiraAbertura)
            {
                AtribuirDadosAosInputs();
            }
            if (editar)
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

        private async void CadastrarColaborador()
        {
            dtoColaboradores.Nome = Parametros.nomeColab;
            dtoColaboradores.Sobrenome = Parametros.sobrenomeColab;
            dtoColaboradores.Id_sexo = (int)Parametros.idSexoColab;
            dtoColaboradores.Cpf = Parametros.cpfColab;
            dtoColaboradores.Data_nasc = Parametros.nascimentoColab;
            dtoColaboradores.Email = Parametros.emailColab;
            dtoColaboradores.Ativo = Parametros.ColaboradorAtivo;
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
            AtualizarColaboradores();
            ActiveForm.Close();
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
            dtoColaboradores.Ativo = Parametros.ColaboradorAtivo;
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
            AtualizarColaboradores();
            ActiveForm.Close();
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

        private void VerificarCampos()
        {
            if (!funcoes.VerificarSeInputEstaVazio(this))
            {
                CadastrarOuEditar();
            }
        }

        private void CadastrarOuEditar()
        {
            AtribuirDadosDosInputs();
            if (!editarColaborador)
            {
                CadastrarColaborador();
            }
            else if (editarColaborador)
            {
                EditarColaborador();
            }
            inputBairro.Enabled = false;
            inputCidade.Enabled = false;
            inputBoxUf.Enabled = false;
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
                    _ = cepModel.Bairro == "" ? inputBairro.Enabled = true : inputBairro.Enabled = false;
                    _ = cepModel.Localidade == "" ? inputCidade.Enabled = true : inputCidade.Enabled = false;
                    _ = cepModel.Uf == "" ? inputBoxUf.Enabled = true : inputBoxUf.Enabled = false;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AtribuirDadosDosInputs();
            Close();
            GC.Collect();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is CadColaborador
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorPessoal(false, editarColaborador);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();
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

        private void inputComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCampos();
            }
        }
    }
}