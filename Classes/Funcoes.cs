using IniParser.Model;
using IniParser;
using MovSoft.CODE.BLL;
using System.Text.RegularExpressions;
using MovSoft.Controls;
using System.Reflection.Metadata.Ecma335;
using System.DirectoryServices.ActiveDirectory;

namespace MovSoft.Classes
{
    internal class Funcoes
    {
        Thread tr;
        UsuariosBLL bll = new();
        public void OpenChildForm(Form childForm, Form activeForm, Panel pnlMain, int nivelPermissao)
        {
            bool podeAcessar = VerificarPermissao(nivelPermissao);
            if (podeAcessar)
            {
                activeForm?.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(childForm);
                //pnlMain.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para acessar a tela {childForm.Text}!", "Não há permissão suficiente para continuar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void CriarColunaComCheckbox(DataGridView gridview)
        {
            DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new();
            dataGridViewCheckBoxColumn.HeaderText = "Ativo";
            dataGridViewCheckBoxColumn.Name = "Ativo";
            dataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            dataGridViewCheckBoxColumn.TrueValue = 'S';
            dataGridViewCheckBoxColumn.FalseValue = 'N';
            gridview.Columns.Add(dataGridViewCheckBoxColumn);
        }

        public bool VerificaSeInputEstáVazio(Control controlComInputs)
        {
            List<bool?> verificadores = new();
            foreach (Control control in controlComInputs.Controls)
            {
                if (!string.IsNullOrEmpty((string)control.Tag))
                {
                    if (control.GetType() == typeof(MaskedTextBox))
                    {
                        ((MaskedTextBox)control).TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        if (control.Text == string.Empty)
                        {
                            verificadores.Add(false);
                        }
                    }
                    else if (control.GetType() == typeof(TextBox))
                    {
                        if (control.Text == string.Empty)
                        {
                            verificadores.Add(false);
                        }
                    }
                    else if (control.GetType() == typeof(ComboBox))
                    {
                        if (((ComboBox)control).SelectedIndex == -1)
                        {
                            verificadores.Add(false);
                        }
                    }
                    else if (control.GetType() == typeof(NumericUpDown))
                    {
                        if (((NumericUpDown)control).Value == 0)
                        {
                            verificadores.Add(false);
                        }
                    }
                }
            }
            if (verificadores.Count > 0)
            {
                MessageBox.Show($"Preencha todos os campos obrigatórios!", "Entrada de dados vazia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        public void PrimeiroInputEmFoco(Control input)
        {
            input.Focus();
        }

        public bool VerificarPermissao(int nivelPermissao)
        {
            bool podeAcessar;
            bll.VerificarPermissao((int)Parametros.idUser, nivelPermissao);
            if (Parametros.adminUser == 'S' || Parametros.permissaoUser == 'S')
            {
                podeAcessar = true;
            }
            else
            {
                podeAcessar = false;
            }
            return podeAcessar;
        }

        public void AbrirForms(Form form, int nivelPermissao)
        {
            bool podeAcessar = VerificarPermissao(nivelPermissao);
            if (podeAcessar)
            {
                form.Show();
            }
            else
            {
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para acessar a tela {form.Text}!", "Não há permissão suficiente para continuar o processo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public void limpaInputsDeUmControl(Control control)
        {
            foreach (Control elemento in control.Controls)
            {
                if(elemento.GetType() == typeof(TextBox))
                {
                    ((TextBox)elemento).Clear();
                }
                else if (elemento.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)elemento).SelectedIndex = -1;
                }
                else if(elemento.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)elemento).Clear();
                }
                else if(elemento.GetType() == typeof(NumericUpDown))
                {
                    ((NumericUpDown)elemento).Value = 0;
                }
            }
        }
        static public IniData LerIni()
        {
            IniData? data;
            FileIniDataParser? parser = new();
            data = parser.ReadFile(Parametros.Dir);
            return data;
        }

        public string GridViewMascaraCPF(string valor)
        {
            if (valor == "")
            {
                return valor;
            }
            return valor.Insert(3, ".").Insert(7, ".").Insert(11, "-");
        }

        public string GridViewMascaraCelular(string valor)
        {
            return valor.Insert(10, "-");
        }

        public void RemoverMascarasDeTexto(MaskedTextBox input)
        {
            input.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        public string BdDataNascimento(string data)
        {
            return data.Substring(4, 4) + "-" + data.Substring(2, 2) + "-" + data.Substring(0, 2);
        }

        public void CentralizarHorizontalmente(Control controlDeReferencia, Control controlCentralizado)
        {
            controlCentralizado.Anchor = AnchorStyles.Top;
            controlCentralizado.Left = (controlDeReferencia.Width - controlCentralizado.Width) / 2;
        }

        public void CentralizarVerticalmente(Control controlDeReferencia, Control controlCentralizado)
        {
            controlCentralizado.Anchor = AnchorStyles.Top;
            controlCentralizado.Top = (controlDeReferencia.Height - controlCentralizado.Height) / 2;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = GridViewMascaraCPF(e.Value.ToString());
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 2)
            {
                e.Value = GridViewMascaraCelular(e.Value.ToString());
                e.FormattingApplied = true;
            }
        }

        public void dataGridView_AplicarCellFormatting(DataGridView dataGridView)
        {
            dataGridView.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView_CellFormatting);
        }

        private void AbrirJanelaLogin()
        {
            Application.Run(new Login());
        }

        public void ThreadVoltarAoLogin()
        {
            tr = new(AbrirJanelaLogin);
            tr.SetApartmentState(ApartmentState.STA);
            tr.Start();
        }

        private void SairOnClick(object sender, EventArgs e)
        {
            ThreadVoltarAoLogin();
        }

        public void AplicarFuncaoSair(Control obj)
        {
            obj.Click += new EventHandler(SairOnClick);
        }

        public void AjustarSelectorDosMaskedTextBox(Control control)
        {
            foreach (MaskedTextBox input in control.Controls.OfType<MaskedTextBox>())
            {
                input.Click += (s, e) =>
                {
                    if (string.IsNullOrEmpty(input.Text))
                    {
                        input.Select(0, 0);
                    }
                    else
                    {
                        input.SelectionStart = input.MaskedTextProvider.LastAssignedPosition + 1;
                    }
                };
            }
        }

        public string? getApiResult(string url)
        {
            string? result = null;
            try
            {
                using (HttpClient cliente = new())
                {
                    HttpResponseMessage response = cliente.GetAsync(url).Result;
                    result = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $" | Erro ao conectar em {url} ({MessageBoxButtons.OK} {MessageBoxIcon.Error})");
            }
            return result;
        }
        public bool ValidacaoDataNascimento(MaskedTextBox inputNascimento)
        {
            string? input = inputNascimento.Text;
            if (input.Length < 8)
            {
                MessageBox.Show("Quantidade de caracteres inválida no campo de Data de Nascimento!", "Número de caracteres inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputNascimento.Focus();
                return false;
            }
            else
            {
                int dia = int.Parse(input.Substring(0, 2));
                int mes = int.Parse(input.Substring(2, 2));
                int ano = int.Parse(input.Substring(4, 4));
                input = input.Substring(0, 2) + "/" + input.Substring(2, 2) + "/" + input.Substring(4, 4);
                DateTime date;
                if (dia > DateTime.DaysInMonth(ano, mes)){
                    inputNascimento.Focus();
                    inputNascimento.Clear();
                    MessageBox.Show("O dia inserido é maior que a quantidade de dias do mês inserido","Formatação de dados incorreta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }
                else if (DateTime.TryParse(input, out date))
                {
                    if (date >= DateTime.Now)
                    {
                        MessageBox.Show("O ano de nascimento inserido é acima do ano atual!", "Formatação de dados incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inputNascimento.Focus();
                        inputNascimento.Clear();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Data de nascimento inválida!", "Formatação de dados incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputNascimento.Focus();
                    inputNascimento.Clear();
                    return false;
                }
                return true;
            }
        }
        public bool ValidacaoEmail(TextBox inputEmail)
        {
            string input = inputEmail.Text;
            bool numerosRepetidos = true;
            if (input != null)
            {
                Regex regex = new(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!regex.IsMatch(input))
                {
                    MessageBox.Show("Informe um e-mail válido! Exemplo: 'exemplo@exemplo.com' ou 'exemplo@exemplo.com.br'", "Formatação de dados incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputEmail.Focus();
                    inputEmail.Clear();
                    return false;
                }
                return true;
            }
            return false;
        }

        public bool ValidacaoTelefone(MaskedTextBox inputCelular)
        {
            string numeroCelular = inputCelular.Text;
            if (numeroCelular != null)
            {
                if (numeroCelular.Length < 11)
                {
                    MessageBox.Show("Quantidade de caracteres inválidos no campo de Celular!", "Número de caracteres inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inputCelular.Focus();
                    return false;
                }
                else
                {
                    Regex regex = new(@"^[1-9]{2} ?:[2-8]|9[1-9][0-9]{3}[0-9]{4}$");
                    if (!regex.IsMatch(numeroCelular))
                    {
                        MessageBox.Show("Primeiro dígito incorreto, adicione '9' corretamente no campo de Celular!", "Formatação de dados incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inputCelular.Focus();
                        inputCelular.Clear();
                        return false;
                    }
                    numeroCelular = inputCelular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                    List<string> dddBrasil = new() {"61", "62", "64", "65", "66", "67", "82", "71", "73", "74", "75",
                "77", "85", "88", "98", "99", "83", "81", "87", "86", "89", "84", "79", "68", "96", "92", "97", "91", "93",
                "94", "69", "95", "63","27", "28", "31", "32", "33", "34", "35", "37", "38", "21", "22", "24", "11", "12",
                "13", "14", "15", "16", "17", "18", "19", "41", "42", "43", "44", "45", "46", "51", "53", "54",
                "55", "47", "48", "49"};
                    string dddInserido = numeroCelular.Substring(0, 2);
                    bool dddExistente = dddBrasil.Contains(dddInserido);
                    if (dddExistente == false)
                    {
                        MessageBox.Show("Esse DDD não existe!", "Formatação de dados incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inputCelular.Focus();
                        inputCelular.Clear();
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }
        
        public bool ValidacaoCPF(MaskedTextBox inputCpf)
        {
            string cpf = inputCpf.Text;
            bool numerosRepetidos = true;
            // Verificar se o cpf tem 11 dígitos
            if (cpf.Length != 11)
            {
                MessageBox.Show("Quantidade de caracteres inválidos no campo CPF", "Número de caracteres inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar se é 00000000000 ...., 99999999999
            int n = cpf.Length;
            for (int i = 1; i < n; i++)
            {
                if (cpf[i] != cpf[0])
                {
                    numerosRepetidos = false;
                }
            }
            if (numerosRepetidos == true)
            {
                MessageBox.Show($"O número de CPF '{cpf}' é inválido", "Formatação de dados incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verificar dígito de controle do cpf
            var j = 0;
            var d1 = 0;
            var d2 = 0;

            // Validar o primeiro número do dígito de controle
            for (int i = 10; i > 1; i--)
            {
                d1 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                j++;
            }

            // Resto da divisão
            d1 = (d1 * 10) % 11;
            if (d1 == 10)
            {
                d1 = 0;
            }

            // Verificar se o primeiro número bateu ---- posição 9 (penúltima)
            if (d1 != Convert.ToInt32(cpf.Substring(9, 1)))
            {
                MessageBox.Show($"O número de CPF '{cpf}' é inválido", "Formatação de dados inccorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar o segundo número (dígito) do controle
            j = 0;
            for (int i = 11; i > 1; i--)
            {
                d2 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                j++;
            }

            // Resto divisão
            d2 = (d2 * 10) % 11;
            if (d2 == 10)
            {
                d2 = 0;
            }

            // Verificar se o segundo número bateu ---- posicao 10 (última)
            if (d2 != Convert.ToInt32(cpf.Substring(10, 1)))
            {
                MessageBox.Show($"O número de CPF '{cpf}' é inválido!", "Formatação de dados incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inputCpf.Focus();
                inputCpf.Clear();
                return false;
            }
            return true;
        }
    }
}