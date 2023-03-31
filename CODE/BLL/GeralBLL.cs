using MovSoft.CODE.DAL;

namespace MovSoft.CODE.BLL
{
    internal class GeralBLL
    {
        AcessoBancoDados db = new();

        public void AtivarDesativar(string tabela,string campo,int idGrupo, string ativo)
        {
            DialogResult result = MessageBox.Show("Realmete deseja desativar esse cadastro", "Confirmação de Alteração", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                try
                {
                    db.Conectar();
                    string comando = $@"update {tabela}
                                 set ativo = '{ativo}'
                                 where {campo} = {idGrupo}";
                    db.ExecutarComandoSQL(comando,true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
