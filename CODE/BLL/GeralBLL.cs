using MovSoft.CODE.DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovSoft.CODE.BLL
{
    internal class GeralBLL
    {
        AcessoBancoDados db = new();

        public void AtivarDesetivar(string tabela,string campo,int idGrupo, string ativo)
        {
            try
            {
                db.Conectar();
                string comando = $@"update {tabela}
                                 set ativo = '{ativo}'
                                 where {campo} = {idGrupo}";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
