namespace MovSoft.CODE.DTO
{
    internal class FornecedoresDTO
    {
        private int id_fornecedor;
        private string nomeFantasia;
        private string razaoSocial;
        private string cnpj;
        private int id_endereco;

        public int Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public string Nome_fantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string Razao_social { get => razaoSocial; set => razaoSocial = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public int Id_endereco { get => id_endereco; set => id_endereco = value; }
    }
}