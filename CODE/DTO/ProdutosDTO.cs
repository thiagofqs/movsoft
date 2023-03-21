namespace MovSoft.CODE.DTO
{
    internal class ProdutosDTO
    {
        private int id_produto;
        private string produto;
        private int id_grupo;
        private int id_preco;
        private string ativo;

        public int Id_colaborador { get => id_produto; set => id_produto = value; }
        public string Produto { get => produto; set => produto = value; }
        public int Id_grupo { get => id_grupo; set => id_grupo = value; }
        public int Id_preco { get => id_preco; set => id_preco = value; }
        public string Ativo { get => ativo; set => ativo = value; }
    }
}
