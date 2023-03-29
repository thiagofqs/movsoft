using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.DTO
{
    internal class ProdutoCompostoDTO
    {
        private List<int> idProduto;
        private List<int> idComponente;
        private List<int> idOpcional;
        private List<float> qtdComponente;

        public List<int> IdProduto { get => idProduto; set => idProduto = value; }
        public List<int> IdComponente { get => idComponente; set => idComponente = value; }
        public List<int> IdOpcional { get => idOpcional; set => idOpcional = value; }
        public List<float> QtdComponente { get => qtdComponente; set => qtdComponente = value; }
    }
}
