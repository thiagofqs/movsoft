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

        public void centralizarElementos(Control element, Control parent)
        {
            element.Left = (parent.Width - element.Width) / 2;
        }

        public void centralizarElementosVerticalmente(Control element, Form frm)
        {
            element.Top = (frm.Height - element.Height) / 2;
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
            data = data.Substring(4, 4) + "-" + data.Substring(2, 2) + "-" + data.Substring(0, 2);
            return data;
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
                MessageBox.Show(ex.Message, $" | Erro ao conectar em {url}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public bool ValidacaoData(MaskedTextBox inputNascimento)
        {
            string? input = inputNascimento.Text;
            if (input != "")
            {
                if (input.Length < 8)
                {
                    MessageBox.Show("Quantidade de caracteres inválida!");
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
                            MessageBox.Show("Ano de nascimento acima do atual!");
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
            else
            {
                MessageBox.Show("O campo de data não pode estar vazio!");
                return false;
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
                    MessageBox.Show("Informe um e-mail válido, exemplo: 'exemplo@exemplo.com' ou 'exemplo@exemplo.com.br'");
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
            string input = inputCelular.Text;
            if (input != null)
            {
                if (input.Length < 11)
                {
                    MessageBox.Show("Quantidade de caracteres inválidos!");
                    inputCelular.Focus();
                    return false;
                }
                else
                {
                    Regex regex = new(@"^[1-9]{2} ?:[2-8]|9[1-9][0-9]{3}[0-9]{4}$");
                    if (!regex.IsMatch(input))
                    {
                        MessageBox.Show("Primeiro Digito incorreto adicione o prineiro digito corretamente '9'");
                        inputCelular.Focus();
                        inputCelular.Clear();
                        return false;
                    }
                    input = inputCelular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                    List<string> dddBrasil = new List<string> {"61", "62", "64", "65", "66", "67", "82", "71", "73", "74", "75",
                "77", "85", "88", "98", "99", "83", "81", "87", "86", "89", "84", "79", "68", "96", "92", "97", "91", "93",
                "94", "69", "95", "63","27", "28", "31", "32", "33", "34", "35", "37", "38", "21", "22", "24", "11", "12",
                "13", "14", "15", "16", "17", "18", "19", "41", "42", "43", "44", "45", "46", "51", "53", "54",
                "55", "47", "48", "49"};
                    string ddd = input.Substring(0, 2);
                    bool resultDdd = dddBrasil.Contains(ddd);
                    if (resultDdd == false)
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

        /*
        public bool ValidacaoCPF(MaskedTextBox inputCpf)
        {
            string input = inputCpf.Text;
            bool primeiraValidacao = false;
            int multiplicadores = 10;
            int resultado = 0;
            bool repetido = false;
            if (input.Length == 11)
            {
                for(int i = 0; i <= 8; i++)
                {
                    resultado += int.Parse(input[i].ToString()) * multiplicadores;
                    multiplicadores = multiplicadores - 1;
                    if (input[i] == input[i + 1])
                    {
                        repetido = true;
                    }
                    else
                    {
                        repetido = false;
                    }
                }
                if (resultado * 10 % 11 == 10)
                {
                    resultado = 0;
                }
                if(resultado * 10 % 11 == int.Parse(input[9].ToString()) || resultado == 0)
                {
                    primeiraValidacao = true;
                    resultado = 0;
                    multiplicadores = 11;
                }
                if (primeiraValidacao == true && repetido == false) {
                    for (int i = 0; i <= 9; i++)
                    {
                        resultado += int.Parse(input[i].ToString()) * multiplicadores;
                        multiplicadores -= 1;
                    }
                    if (resultado * 10 % 11 == int.Parse(input[10].ToString()))
                    {
                        return true;
                    }
                    MessageBox.Show("CPF inválido!");
                    return false;
                }
                MessageBox.Show("CPF inválido!");
                return false;
            }
            MessageBox.Show("CPF inválido!");
            return false;
        }*/
    }
}