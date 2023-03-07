﻿using MovSoft.Classes;
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
            PosicionarObrs();
            funcoes.PrimeiroInputEmFoco(inputNomeFantasia);
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

        private void PosicionarObrs()
        {
            funcoes.PosicionarObrFilho(txtNomeFantasia, txtObr0);
            funcoes.PosicionarObrFilho(txtRazao, txtObr1);
            funcoes.PosicionarObrFilho(txtCnpj, txtObr2);
            funcoes.PosicionarObrFilho(txtCep, txtObr3);
            funcoes.PosicionarObrFilho(txtLogradouro, txtObr4);
            funcoes.PosicionarObrFilho(txtNumero, txtObr5);
            funcoes.PosicionarObrFilho(txtBairro, txtObr6);
            funcoes.PosicionarObrFilho(txtCidade, txtObr7);
            funcoes.PosicionarObrFilho(txtUf, txtObr8);
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
            fornecedoresDTO.Nome_fantasia = inputNomeFantasia.Text;
            fornecedoresDTO.Razao_social = inputRazaoSocial.Text;
            fornecedoresDTO.Cnpj = inputCnpj.Text;
            EnderecosDTO.Cep = inputCep.Text;
            EnderecosDTO.Uf = inputBoxUf.Text;
            EnderecosDTO.Cidade = inputCidade.Text;
            EnderecosDTO.Bairro = inputBairro.Text;
            EnderecosDTO.Logradouro = inputLogradouro.Text;
            EnderecosDTO.Numero = inputNumero.Text;
            EnderecosDTO.Complemento = inputComplemento.Text;
            fornecedoresBLL.EditarFornecedor(fornecedoresDTO, EnderecosDTO);
            ActiveForm.Close();
        }

        private void CadastrarFornecedor()
        {
            fornecedoresDTO.Nome_fantasia = inputNomeFantasia.Text;
            fornecedoresDTO.Razao_social = inputRazaoSocial.Text;
            fornecedoresDTO.Cnpj = inputCnpj.Text;
            EnderecosDTO.Cep = inputCep.Text;
            EnderecosDTO.Uf = inputBoxUf.Text;
            EnderecosDTO.Cidade = inputCidade.Text;
            EnderecosDTO.Bairro = inputBairro.Text;
            EnderecosDTO.Logradouro = inputLogradouro.Text;
            EnderecosDTO.Numero = inputNumero.Text;
            EnderecosDTO.Complemento = inputComplemento.Text;
            fornecedoresBLL.CadastrarFornecedor(fornecedoresDTO, EnderecosDTO);
            ActiveForm.Close();
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
            if (inputNomeFantasia.Text == "" || inputRazaoSocial.Text == "" || inputCnpj.Text == "" || inputCep.Text == "" || inputLogradouro.Text == "" || inputNumero.Text == "" || inputBairro.Text == "" || inputCidade.Text == "" || inputBoxUf.Text == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
            }
            else
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
        }

        private void inputCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCampos();
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

        private void inputBoxUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCampos();
            }
        }
    }
}