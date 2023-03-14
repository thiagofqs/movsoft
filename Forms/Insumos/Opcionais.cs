﻿using MovSoft.Classes;

namespace MovSoft.Forms
{
    public partial class Opcionais : Form
    {
        string[] opc = new string[10];

        public Opcionais()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void LimparCampos()
        {
            inputNomeOpcionais.Text = "";
            numericUpDownOpcionais.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Enabled)
            {
                if (inputNomeOpcionais.Text == "" || numericUpDownOpcionais.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    inputNomeOpcionais.Focus();
                }
                else
                {
                    pnlCadastro.Enabled = false;
                    LimparCampos();
                    btnCancelar.Enabled = false;
                }
            }
            else
            {
                dataGridViewOpcionais.Enabled = false;
                btnCadastrar.Text = "Salvar";
                pnlCadastro.Enabled = true;
                btnCancelar.Enabled = true;
                inputNomeOpcionais.Focus();
            }
        }

        private void PesquisarInsumos()
        {
            //dataGridViewGrupos.DataSource = bll.PesquisarInsumos(inputPesquisar.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewOpcionais.Enabled = true;
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarInsumos();
        }

        private void inputPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarInsumos();
            }
        }

        private void VoltarAoPadrao()
        {
            btnCadastrar.Text = "Cadastrar";
            btnEditar.Text = "Editar";
            dataGridViewOpcionais.Enabled = true;
            pnlCadastro.Enabled = false;
            LimparCampos();
            btnCadastrar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (pnlCadastro.Enabled)
            {
                if (inputNomeOpcionais.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!");
                    inputNomeOpcionais.Focus();
                }
                else
                {
                    //EditarGrupo();
                    VoltarAoPadrao();
                }
            }
            else
            {
                btnEditar.Text = "Salvar";
                dataGridViewOpcionais.Enabled = false;
                pnlCadastro.Enabled = true;
                btnCancelar.Enabled = true;
                inputNomeOpcionais.Focus();
            }
        }

        private void dataGridViewOpcionais_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                btnCadastrar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                /*rowData = dataGridViewGrupos.Rows[e.RowIndex];
                Parametros.idGrupo = int.Parse(rowData.Cells[0].Value.ToString());
                bll.PegarDados((int)Parametros.idGrupo);
                AtribuirDadosAosInputs();*/
            }
        }
    }
}