using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.DTO
{
    internal class GruposDTO
    {
        private int idGrupo;
        private string nomeGrupo;
        private string ativo;

        public string NomeGrupo { get => nomeGrupo; set => nomeGrupo = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        public string Ativo { get => ativo; set => ativo = value; }
    }
}
