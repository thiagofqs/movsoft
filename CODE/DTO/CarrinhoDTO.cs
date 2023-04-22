using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.DTO
{
    internal class CarrinhoDTO
    {
        private int idVenda;
        private int idProduto;
        private int idUsuario;
        private int quantidade;
        private string opcional;
        private float precoProduto;
        private float precoOpcional;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Opcional { get => opcional; set => opcional = value; }
        public float PrecoProduto { get => precoProduto; set => precoProduto = value; }
        public float PrecoOpcional { get => precoOpcional; set => precoOpcional = value; }
    }
}
