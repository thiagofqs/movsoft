namespace MovSoft.CODE.DTO
{
    internal class ProdutoCompostoDTO
    {
        private int idProduto;
        private List<string> componente;
        private List<string> opcional;

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public List<string> Componente { get => componente; set => componente = value; }
        public List<string> Opcional { get => opcional; set => opcional = value; }
    }
}
