using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.DTO
{
    internal class OpcoesDTO
    {
        private int idOpcao;
        private string opcoao;
        private float preco;
        private string unidadeMedida;
        private string ativo;
        private int idOpcional;

        public int IdOpcao { get => idOpcao; set => idOpcao = value; }
        public string Opcoao { get => opcoao; set => opcoao = value; }
        public float Preco { get => preco; set => preco = value; }
        public string UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
        public string Ativo { get => ativo; set => ativo = value; }
        public int IdOpcional { get => idOpcional; set => idOpcional = value; }
    }
}
