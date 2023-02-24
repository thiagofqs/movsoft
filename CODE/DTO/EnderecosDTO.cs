namespace MovSoft.CODE.DTO
{
    class EnderecosDTO
    {
        private int id_endereco;
        private string estado;
        private string cidade;
        private string bairro;
        private string logradouro;
        private string complemento;
        private string numero;
        private string cep;

        public int Id_endereco { get => id_endereco; set => id_endereco = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
