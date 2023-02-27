using System.Data;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using MovSoft.Classes;

namespace MovSoft.CODE.BLL
{
    class ColaboradoresBLL
    {
        AcessoBancoDados db = new();
        public List<string> Colaboradores()
        {
            List<string> listaColaboradores = new();
            try
            {
                DataTable dataTable = new();
                db.Conectar();
                string comando = $"call colaboradores()";
                dataTable = db.RetDataTable(comando);
                foreach(DataRow dataRow in dataTable.Rows )
                {
                    string content = dataRow["Nome Completo"].ToString();
                    listaColaboradores.Add(content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return listaColaboradores;
        }

        public DataTable MostrarColaboradores()
        {
            DataTable dataTable = new DataTable();

            try
            {
                db.Conectar();
                dataTable = db.RetDataTable("call colaboradores()");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            
            return dataTable;
        }

        public DataTable ProcurarColaboradores(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable($"call procurarColaboradores('{pesquisa}')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }
        public void CadastrarColaborador(ColaboradoresDTO dtoColaboradores, EnderecosDTO dtoEnderecos, ContatosDTO dtoContatos)
        {
            try
            {
                db.Conectar();
                string comando = $"call cad_colaborador('{dtoColaboradores.Nome}', '{dtoColaboradores.Sobrenome}', '{dtoColaboradores.Data_nasc}', '{dtoColaboradores.Cpf}', '{dtoColaboradores.Email}', {dtoColaboradores.Id_sexo}, '{dtoEnderecos.Estado}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}', '{dtoContatos.Ddd}', '{dtoContatos.Celular}')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar colaborador!");
                MessageBox.Show(ex.Message);
            }
        }
        public void EditarColaborador(ColaboradoresDTO dtoColaboradores, EnderecosDTO dtoEnderecos, ContatosDTO dtoContatos)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_colaborador({dtoColaboradores.Id_colaborador},{dtoEnderecos.Id_endereco},{dtoContatos.Id_celular},'{dtoColaboradores.Nome}', '{dtoColaboradores.Sobrenome}', '{dtoColaboradores.Data_nasc}', '{dtoColaboradores.Cpf}', '{dtoColaboradores.Email}', {dtoColaboradores.Id_sexo}, '{dtoEnderecos.Estado}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}', '{dtoContatos.Ddd}', '{dtoContatos.Celular}')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar colaborador!");
                MessageBox.Show(ex.Message);
            }
        }
        public void PegarDados(int idColaborador)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_selec_colaboradores({idColaborador})";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idColab = dr.GetInt32(0);
                Parametros.nomeColab = dr.GetString(1);
                Parametros.sobrenomeColab = dr.GetString(2);
                Parametros.dddColab = dr.GetString(3);
                Parametros.celularColab = dr.GetString(4);
                Parametros.cpfColab = dr.GetString(5);
                Parametros.nascimentoInputColab = dr.GetString(6);
                Parametros.idSexoColab = dr.GetInt32(7);
                Parametros.emailColab = dr.GetString(8);
                Parametros.nascimentoInputColab = Parametros.nascimentoInputColab.Replace("/", "");
                Parametros.nascimentoInputColab = Parametros.nascimentoInputColab.Substring(0,8);
                Parametros.idCelularColab = dr.GetInt32(17);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void PegarEndereco(int idColaborador)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_selec_colaboradores({idColaborador})";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idEndereco = dr.GetInt32(9);
                Parametros.uf = dr.GetString(10);
                Parametros.cidade = dr.GetString(11);
                Parametros.bairro = dr.GetString(12);
                Parametros.logradouro = dr.GetString(13);
                Parametros.cep = dr.GetString(14);
                Parametros.complemento = dr.GetString(15);
                Parametros.numero = dr.GetString(16);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.ToString());
            }
        }

    }
}