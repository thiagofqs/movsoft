namespace MovSoft.CODE.DTO
{
    class UsuariosDTO
    {
        private int id_usuario;
        private string nome;
        private string senha;
        private int id_cargo;
        private int id_colaborador;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Id_cargo { get => id_cargo; set => id_cargo = value; }
        public int Id_colaborador { get => id_colaborador; set => id_colaborador = value; }
    }
}
