namespace MovSoft.CODE.DTO
{
    internal class ProdutosDTO
    {
        private int id_produto;
        private string produto;
        private int id_grupo;
        private float preco;
        private string ativo;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Produto { get => produto; set => produto = value; }
        public int Id_grupo { get => id_grupo; set => id_grupo = value; }
        public string Ativo { get => ativo; set => ativo = value; }
        public float Preco { get => preco; set => preco = value; }
    }
}
