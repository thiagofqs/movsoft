using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.BLL
{
    internal class VendaBLL
    {
        AcessoBancoDados db = new();

        public void IniciarVenda(VendasDTO vendasDTO)
        {
            try
            {
                db.Conectar();
                string comando = $@"call lancarVenda({vendasDTO.IdVenda}
                ,{vendasDTO.IdUsuario},{vendasDTO.IdForma},{vendasDTO.IdCondicao},
                '{vendasDTO.Uf}','{vendasDTO.Cidade}','{vendasDTO.Bairro}',
                '{vendasDTO.Logradouro}','{vendasDTO.Numero}','{vendasDTO.Complemento}',
                '{vendasDTO.Cep}',{vendasDTO.TaxaEntrega},'{vendasDTO.Status}',{vendasDTO.Total})";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
