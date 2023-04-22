using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.DTO
{
    internal class HistoricoEstoqueDTO
    {
        private string produto;
        private string componente;
        private string item;
        private float qtd;
        private int tipoMovimento;
        private string fornecedor;

        public string Produto { get => produto; set => produto = value; }
        public string Componente { get => componente; set => componente = value; }
        public string Item { get => item; set => item = value; }
        public float Qtd { get => qtd; set => qtd = value; }
        public int TipoMovimento { get => tipoMovimento; set => tipoMovimento = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
    }
}
