using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.DTO
{
    internal class OpcionaisDTO
    {
        private int idOpcional;
        private string opcional;
        private int quantidadeMarcacoes;
        private string ativo;

        public int IdOpcional { get => idOpcional; set => idOpcional = value; }
        public string Opcional { get => opcional; set => opcional = value; }
        public int QuantidadeMarcacoes { get => quantidadeMarcacoes; set => quantidadeMarcacoes = value; }
        public string Ativo { get => ativo; set => ativo = value; }
    }
}
