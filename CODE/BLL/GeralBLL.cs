using MovSoft.CODE.DAL;
using MySql.Data.MySqlClient;

namespace MovSoft.CODE.BLL
{
    internal class GeralBLL
    {
        AcessoBancoDados db = new();

        public void AtivarDesativar(string tabela, string campo, int idGrupo, string ativo)
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
                    db.ExecutarComandoSQL(comando, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public List<string> ProdutosQueControlamEstoque()
        {
            List<string> produtos = new();
            try
            {
                db.Conectar();
                string comando = @"select concat('[P]',' ',produto) from produtos where controla_estoque = true
                union
                select concat('[C]',' ',componente) from componentes where controla_estoque = true
                union
                select concat('[',opcionais.opcional,']',' ',item) from opcionais_itens inner join opcionais on opcionais.id_opcional = opcionais_itens.id_opcional where controla_estoque = true;
                ";
                MySqlDataReader dr = db.RetDataReader(comando);
                do
                {
                    produtos.Add(dr.GetString(0));
                }
                while (dr.Read());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return produtos;
        }
    }
}
