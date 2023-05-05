namespace MovSoft.CODE.DTO
{
    internal class GruposDTO
    {
        private int idGrupo;
        private string nomeGrupo;
        private string ativo;

        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string NomeGrupo { get => nomeGrupo; set => nomeGrupo = value; }
        public string Ativo { get => ativo; set => ativo = value; }
    }
}
