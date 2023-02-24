using IniParser.Model;
using IniParser;
using MovSoft.CODE.BLL;

namespace MovSoft
{
    public partial class Login : Form
    {
        Thread tr;
        UsuariosBLL bll = new();

        public Login()
        {
            InitializeComponent();
            ActiveControl = inputUsuario;
            bool existe;
            existe = File.Exists(Parametros.Dir);
            if (existe == false)
            {
                CriarIni();
            }
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizarJanela_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Logar()
        {
            if (inputUsuario.Text == "" || inputSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos de login!");
            }
            else
            {
                string usuarioDigitado = inputUsuario.Text;
                string senhaDigitada = inputSenha.Text;
                bll.Login(usuarioDigitado);
                if (Parametros.senhaUser == senhaDigitada)
                {
                    Close();
                    tr = new(AbrirJanelaHome);
                    tr.SetApartmentState(ApartmentState.STA);
                    tr.Start();
                }
                else
                {
                    MessageBox.Show("Senha incorreta!");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(inputUsuario.Text == "" || inputSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
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
            var parser = new FileIniDataParser();
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