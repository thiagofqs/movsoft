namespace MovSoft.CODE.DTO
{
    class ColaboradoresDTO
    {
        private int id_colaborador;
        private string nome;
        private string sobrenome;
        private string data_nasc;
        private string data_cad;
        private string cpf;
        private string email;
        private int id_sexo;
        private string id_endereco;
        private string ativo;

        public int Id_colaborador { get => id_colaborador; set => id_colaborador = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        public string Data_nasc { get => data_nasc; set => data_nasc = value; }
        public string Data_cad { get => data_cad; set => data_cad = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public int Id_sexo { get => id_sexo; set => id_sexo = value; }
        public string Id_endereco { get => id_endereco; set => id_endereco = value; }
        public string Ativo { get => ativo; set => ativo = value; }
    }
}
