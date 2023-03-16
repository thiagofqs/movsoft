using System.Data;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using MovSoft.Classes;
using Google.Protobuf.Collections;

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
                string comando = $"call colaboradores('S')";
                dataTable = db.RetDataTable(comando);
                foreach (DataRow dataRow in dataTable.Rows)
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
            DataTable dataTable = new();

            try
            {
                db.Conectar();
                dataTable = db.RetDataTable("call colaboradores('S')");
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
                string comando = $"call cad_colaborador('{dtoColaboradores.Nome}', '{dtoColaboradores.Sobrenome}', '{dtoColaboradores.Data_nasc}', '{dtoColaboradores.Cpf}', '{dtoColaboradores.Email}', {dtoColaboradores.Id_sexo}, '{dtoEnderecos.Uf}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}', '{dtoContatos.Ddd}', '{dtoContatos.Celular}','S')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar colaborador!");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.HResult.ToString());
            }
        }
        public void EditarColaborador(ColaboradoresDTO dtoColaboradores, EnderecosDTO dtoEnderecos, ContatosDTO dtoContatos)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_colaborador({dtoColaboradores.Id_colaborador},{dtoEnderecos.Id_endereco},{dtoContatos.Id_celular},'{dtoColaboradores.Nome}', '{dtoColaboradores.Sobrenome}', '{dtoColaboradores.Data_nasc}', '{dtoColaboradores.Cpf}', '{dtoColaboradores.Email}', {dtoColaboradores.Id_sexo}, '{dtoEnderecos.Uf}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}', '{dtoContatos.Ddd}', '{dtoContatos.Celular}','S')";
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
                Parametros.nascimentoInputColab = Parametros.nascimentoInputColab.Substring(0, 8);
                Parametros.idCelularColab = dr.GetInt32(17);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public List<string> ColaboradoresSemUsuarioVinculado()
        {
            List<string> colaboradores = new();
            try
            {
                db.Conectar();
                string comando = "call colaboradoresSemUsuarioVinculado()";
                DataTable dataTable = db.RetDataTable(comando);
                foreach (DataRow row in dataTable.Rows)
                {
                    colaboradores.Add(row["Colaborador"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return colaboradores;
        }

        public int PegarIdPeloNome(string nomeCompleto)
        {
            int idColaborador = 0;
            try
            {
                DataTable dataTable = new();
                db.Conectar();
                string comando = $"select id_colaborador as 'ID' from colaboradores where Concat(nome,' ',sobrenome) = '{nomeCompleto}' limit 1";
                dataTable = db.RetDataTable(comando);
                foreach(DataRow row in dataTable.Rows)
                {
                    idColaborador = int.Parse(row["ID"].ToString());
                }
                MessageBox.Show(nomeCompleto);
            }
            catch(Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
            return idColaborador;
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