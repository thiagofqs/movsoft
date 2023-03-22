﻿using MovSoft.Classes;
using MovSoft.CODE.BLL;
using System.Data;

namespace MovSoft.Forms
{
    public partial class CadColaboradorPessoal : Form
    {
        Funcoes funcoes = new();
        ColaboradoresBLL colaboradoresBLL = new();
        private bool primeiraAberturaColaborador = true;
        private bool editarColaborador = false;

        public CadColaboradorPessoal(bool primeiraAbertura, bool editar)
        {
            InitializeComponent();
            RemoverMascarasDeTexto();
            inputNome.Focus();
            funcoes.AjustarSelectorDosMaskedTextBox(this);
            if (!primeiraAbertura)
            {
                primeiraAberturaColaborador = false;
                AtribuirDadosAosInputs();
            }
            if (editar && primeiraAbertura)
            {
                txtTitulo.Text = "Editar Colaborador 1/2";
                colaboradoresBLL.PegarDados((int)Parametros.idColab);
                colaboradoresBLL.PegarEndereco((int)Parametros.idColab);
                editarColaborador = true;
                AtribuirDadosAosInputs();
            }
            else if (editar && !primeiraAbertura)
            {
                txtTitulo.Text = "Editar Colaborador 1/2";
                editarColaborador = true;
                AtribuirDadosAosInputs();
            }
        }

        private void RemoverMascarasDeTexto()
        {
            funcoes.RemoverMascarasDeTexto(inputCpf);
            funcoes.RemoverMascarasDeTexto(inputNascimento);
            funcoes.RemoverMascarasDeTexto(inputCelular);
        }

        private void AtribuirDadosDosInputs()
        {
            Parametros.nomeColab = inputNome.Text;
            Parametros.sobrenomeColab = inputSobrenome.Text;
            Parametros.idSexoColab = inputboxSexo.SelectedIndex + 1;
            Parametros.cpfColab = inputCpf.Text;
            if (primeiraAberturaColaborador)
            {
                Parametros.nascimentoColab = funcoes.BdDataNascimento(inputNascimento.Text);
            }
            Parametros.nascimentoInputColab = inputNascimento.Text;
            Parametros.emailColab = inputEmail.Text;
            Parametros.dddColab = inputCelular.Text.Substring(0, 2);
            Parametros.celularColab = inputCelular.Text.Substring(2, 9);
            if(toggleButton1.Checked)
            {
                Parametros.ColaboradorAtivo = "S";
            }
            else
            {
                Parametros.ColaboradorAtivo = "N";
            }
        }

        private void AtribuirDadosAosInputs()
        {
            inputNome.Text = Parametros.nomeColab;
            inputSobrenome.Text = Parametros.sobrenomeColab;
            inputboxSexo.SelectedIndex = (int)Parametros.idSexoColab - 1;
            inputCpf.Text = Parametros.cpfColab;
            inputNascimento.Text = Parametros.nascimentoInputColab;
            inputEmail.Text = Parametros.emailColab;
            inputCelular.Text = Parametros.dddColab + Parametros.celularColab;
            if(Parametros.ColaboradorAtivo == "S")
            {
                toggleButton1.Checked = true;
            }
            else
            {
                toggleButton1.Checked = false;
            }
        }

        private void VerificarCampos()
        {
            if(!funcoes.VerificarSeInputEstaVazio(this))
            {
                bool[] validacaoCorreta = new bool[4];
                validacaoCorreta[0] = funcoes.ValidacaoCpf(inputCpf);
                validacaoCorreta[1] = funcoes.ValidacaoDataNascimento(inputNascimento);
                validacaoCorreta[2] = funcoes.ValidacaoEmail(inputEmail);
                validacaoCorreta[3] = funcoes.ValidacaoTelefone(inputCelular);
                if (validacaoCorreta[0] && validacaoCorreta[1] && validacaoCorreta[2] && validacaoCorreta[3])
                {
                    ContinuarCadastro();
                }
            }
        }

        private void ContinuarCadastro()
        {
            AtribuirDadosDosInputs();
            Close();
            GC.Collect();
            var qrForm = from frm in Application.OpenForms.Cast<Form>()
                         where frm is CadColaborador
                         select frm;
            if (qrForm != null && qrForm.Count() > 0)
            {
                ((CadColaborador)qrForm.First()).AbrirTelaCadColaboradorEndereco(primeiraAberturaColaborador, editarColaborador);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void inputCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCampos();
            }
        }

        private void toggleButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                VerificarCampos();
            }
        }
    }
}