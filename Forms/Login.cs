using IniParser.Model;
using IniParser;
using MovSoft.CODE.BLL;
using MovSoft.Classes;

namespace MovSoft
{
    public partial class Login : Form
    {
        Thread tr;
        UsuariosBLL bll = new();
        Funcoes funcoes = new();
        public Login()
        {
            InitializeComponent();
            ActiveControl = inputUsuario;
            bool iniExiste;
            iniExiste = File.Exists(Parametros.Dir);
            if (!iniExiste)
            {
                CriarIni();
                MessageBox.Show("Arquivo .ini gerado! Para configurar, abra-o e altere os valores padrões.");
            }
        }

        private void Logar()
        {
            if(!funcoes.VerificaSeInputEstáVazio(pnlLogin))
            {
                string usuarioDigitado = inputUsuario.Text;
                string senhaDigitada = inputSenha.Text;
                Parametros parametros = new();
                bool logado = bll.Login(usuarioDigitado);
                if(Parametros.userAtivo == "N")
                {
                    MessageBox.Show($"O usuário '{inputUsuario.Text}' está desativado!","Falha de autenticação",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if (Parametros.senhaUser == senhaDigitada)
                {
                    Close();
                    tr = new(AbrirJanelaHome);
                    tr.SetApartmentState(ApartmentState.STA);
                    tr.Start();
                }
                else
                {
                    MessageBox.Show("Usuario e/ou Senha incorreta!","Falha de autenticação",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (inputUsuario.Text == "" || inputSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos de login!");
            }
            else
            {
                Logar();
            }
        }

        private void AbrirJanelaHome(object obj)
        {
            Application.Run(new Home());
        }

        private void inputSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logar();
            }
        }

        private async void CriarIni()
        {
            await File.WriteAllTextAsync(Parametros.Dir, "");
            IniData data;
            FileIniDataParser parser = new();
            data = parser.ReadFile(Parametros.Dir);
            data.Sections.AddSection("DataBase");
            data["DataBase"].AddKey("DB_Server", "127.0.0.1");
            data["DataBase"].AddKey("DB_Database", "movsoft");
            data["DataBase"].AddKey("DB_Username", "root");
            data["DataBase"].AddKey("DB_Password", "root");
            data["DataBase"].AddKey("DB_Port", "3305");
            parser.WriteFile(Parametros.Dir, data);
        }

        private void inputUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logar();
            }
        }
    }
}