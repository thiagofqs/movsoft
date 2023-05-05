using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.DTO
{
    internal class VendasDTO
    {
        private int idVenda;
        private int idProduto;
        private int idUsuario;
        private int idForma;
        private int idCondicao;
        private string uf;
        private string cidade;
        private string bairro;
        private string logradouro;
        private string numero;
        private string complemento;
        private string cep;
        private float taxaEntrega;
        private string status;
        private float total;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdForma { get => idForma; set => idForma = value; }
        public int IdCondicao { get => idCondicao; set => idCondicao = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Cep { get => cep; set => cep = value; }
        public float TaxaEntrega { get => taxaEntrega; set => taxaEntrega = value; }
        public string Status { get => status; set => status = value; }
        public float Total { get => total; set => total = value; }
    }
}
