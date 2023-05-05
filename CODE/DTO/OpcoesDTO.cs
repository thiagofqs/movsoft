namespace MovSoft.CODE.DTO
{
    internal class OpcoesDTO
    {
        private int idOpcao;
        private string opcao;
        private float preco;
        private string unidadeMedida;
        private string ativo;
        private int idOpcional;
        private bool controlaEstoque;

        public int IdOpcao { get => idOpcao; set => idOpcao = value; }
        public string Opcao { get => opcao; set => opcao = value; }
        public float Preco { get => preco; set => preco = value; }
        public string UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public string Ativo { get => ativo; set => ativo = value; }
        public int IdOpcional { get => idOpcional; set => idOpcional = value; }
        public bool ControlaEstoque { get => controlaEstoque; set => controlaEstoque = value; }
    }
}
