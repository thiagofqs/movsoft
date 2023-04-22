using MovSoft.CODE.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.BLL
{
    internal class CarrinhoBLL
    {
        public void IniciarVenda(CarrinhoDTO carrinhoDTO)
        {
            try
            {
                string comando = $@"call lancarVenda({carrinhoDTO.IdVenda}
                ,{carrinhoDTO.IdProduto},{carrinhoDTO.IdUsuario},{carrinhoDTO.Quantidade},
                '{carrinhoDTO.Opcional}',{carrinhoDTO.PrecoProduto},{carrinhoDTO.PrecoOpcional})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
