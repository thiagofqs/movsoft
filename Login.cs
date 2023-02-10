using CRUD.CODE.BLL;

namespace MovSoft
{
    public partial class Login : Form
    {
        Thread tr;
        UsuariosBLL bll = new();
        Usuario usuario = new();
        UsuariosBLL.Usuario retornoDados;

        public struct Usuario
        {
            public int idUsuario;
            public string usuario;
            public string senha;
            public string cargo;
            public char admin;
            public int idCargo;
        }

        public Login()
        {
            InitializeComponent();
            ActiveControl = inputUsuario;
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
                retornoDados = bll.Login(usuarioDigitado);
                if (retornoDados.senha == senhaDigitada)
                {
                    usuario.idUsuario = retornoDados.idUsuario;
                    usuario.usuario = retornoDados.nome;
                    usuario.cargo = retornoDados.cargo;
                    usuario.idCargo = retornoDados.idCargo;
                    usuario.admin = retornoDados.admin;
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
            Application.Run(new Home(usuario));
        }

        private void inputSenha_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Logar();
            }
        }
    }
}
