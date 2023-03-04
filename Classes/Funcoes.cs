using IniParser.Model;
using IniParser;
using MovSoft.CODE.BLL;
using System.Text.RegularExpressions;

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
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para acessar a tela {childForm.Text}!");
            }
        }

        public void PosicionarObrFilho(Label pai, Label filho)
        {
            pai.AutoSize = false;
            pai.Controls.Add(filho);
            filho.Location = new Point(pai.Width - filho.Width + 10, -4);
            pai.Width += filho.Width;
        }

        public void PrimeiroInputEmFoco(Control input)
        {
            input.Focus();
        }

        public bool VerificarPermissao(int nivelPermissao)
        {
            bool podeAcessar;
            bll.VerificarPermissao((int)Parametros.idCargoUser, nivelPermissao);
            if (Parametros.permissaoUser == 'S' || Parametros.adminUser == 'S')
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
                MessageBox.Show($"O cargo {Parametros.cargoUser} não tem permissão para acessar a tela {form.Text}!");
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
                MessageBox.Show("Quantidade de caracteres inválida no campo de Data de Nascimento!");
                inputNascimento.Focus();
                return false;
            }
            else
            {
                input = input.Substring(2, 2) + "/" + input.Substring(2, 2) + "/" + input.Substring(4, 4);
                DateTime date;

                if (DateTime.TryParse(input, out date))
                {
                    if (date >= DateTime.Now)
                    {
                        MessageBox.Show("O ano de nascimento inserido é acima do ano atual!");
                        inputNascimento.Focus();
                        inputNascimento.Clear();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Data de nascimento inválida!");
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
            if (input != null)
            {
                Regex regex = new(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!regex.IsMatch(input))
                {
                    MessageBox.Show("Informe um e-mail válido! Exemplo: 'exemplo@exemplo.com' ou 'exemplo@exemplo.com.br'");
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
                    MessageBox.Show("Quantidade de caracteres inválidos no campo de Celular!");
                    inputCelular.Focus();
                    return false;
                }
                else
                {
                    Regex regex = new(@"^[1-9]{2} ?:[2-8]|9[1-9][0-9]{3}[0-9]{4}$");
                    if (!regex.IsMatch(numeroCelular))
                    {
                        MessageBox.Show("Primeiro dígito incorreto, adicione '9' corretamente no campo de Celular!");
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
                        MessageBox.Show("Esse DDD não existe!");
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
            bool cpfValido = true;

            // Verificar se o cpf tem 11 dígitos
            if (cpf.Length != 11)
            {
                cpfValido = false;
            }

            // Verificar se é 00000000000 ...., 99999999999
            if (cpfValido)
            {
                int n = cpf.Length;
                cpfValido = false;
                for (int i = 1; i < n; i++)
                {
                    if (cpf[i] != cpf[0])
                    {
                        cpfValido = true;
                    }
                }
            }

            // Verificar dígito de controle do cpf
            if (cpfValido)
            {
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
                    cpfValido = false;
                }

                // Validar o segundo número (dígito) do controle
                if (cpfValido)
                {
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
                        cpfValido = false;
                    }
                }
            }
            if (!cpfValido)
            {
                MessageBox.Show("CPF inválido!");
                inputCpf.Focus();
                inputCpf.Clear();
            }
            return cpfValido;
        }
    }
}