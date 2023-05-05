namespace MovSoft.CODE.DTO
{
    internal class ComponentesDTO
    {
        private int idComponente;
        private string nomeComponente;
        private string unidadeMedida;
        private bool controlaEstoque;
        private string ativo;

        public int IdComponente { get => idComponente; set => idComponente = value; }
        public string NomeComponente { get => nomeComponente; set => nomeComponente = value;  }
        public string UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public string Ativo { get => ativo; set => ativo = value; }
        public bool ControlaEstoque { get => controlaEstoque; set => controlaEstoque = value; }
    }
}
