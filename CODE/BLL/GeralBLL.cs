using MovSoft.CODE.DAL;

namespace MovSoft.CODE.BLL
{
    internal class GeralBLL
    {
        AcessoBancoDados db = new();

        public void AtivarDesativar(string tabela,string campo,int idGrupo, string ativo)
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
