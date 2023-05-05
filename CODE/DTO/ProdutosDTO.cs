namespace MovSoft.CODE.DTO
{
    internal class ProdutosDTO
    {
        private int id_produto;
        private string produto;
        private string grupo;
        private float preco;
        private bool controlaEstoque;
        private string ativo;

        public int Id_produto { get => id_produto; set => id_produto = value; }
        public string Produto { get => produto; set => produto = value; }
        public string Ativo { get => ativo; set => ativo = value; }
        public float Preco { get => preco; set => preco = value; }
        public bool ControlaEstoque { get => controlaEstoque; set => controlaEstoque = value; }
        public string Grupo { get => grupo; set => grupo = value; }
    }
}
