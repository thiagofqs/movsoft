namespace CRUD.CODE.DTO
{
    class ContatosDTO
    {
        private int id_celular;
        private int id_colaborador;
        private string ddd;
        private string celular;

        public int Id_celular { get => id_celular; set => id_celular = value; }
        public int Id_colaborador { get => id_colaborador; set => id_colaborador = value; }
        public string Ddd { get => ddd; set => ddd = value; }
        public string Celular { get => celular; set => celular = value; }
    }
}
