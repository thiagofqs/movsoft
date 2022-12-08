using System.Data;
using CRUD.CODE.DAL;
using CRUD.CODE.DTO;
using MySql.Data.MySqlClient;
using MovSoft;

namespace CRUD.CODE.BLL
{
    class ColaboradoresBLL
    {
        CadColaboradorEndereco.Endereco endereco = new();
        CadColaboradorPessoal.Dados dados = new();
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
        public CadColaboradorPessoal.Dados PegarDados(int idColaborador)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_selec_colaboradores({idColaborador})";
                MySqlDataReader dr = db.RetDataReader(comando);
                dados.idColaborador = dr.GetInt32(0);
                dados.nome = dr.GetString(1);
                dados.sobrenome = dr.GetString(2);
                dados.ddd = dr.GetString(3);
                dados.celular = dr.GetString(4);
                dados.cpf = dr.GetString(5);
                dados.nascimentoInput = dr.GetString(6);
                dados.idSexo = dr.GetInt32(7);
                dados.email = dr.GetString(8);
                dados.nascimentoInput = dados.nascimentoInput.Replace("/", "");
                dados.nascimentoInput = dados.nascimentoInput.Substring(0,8);
                dados.idCelular = dr.GetInt32(17);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dados;
        }

        public CadColaboradorEndereco.Endereco PegarEndereco(int idColaborador)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_selec_colaboradores({idColaborador})";
                MySqlDataReader dr = db.RetDataReader(comando);
                endereco.idEndereco = dr.GetInt32(9);
                endereco.uf = dr.GetString(10);
                endereco.cidade = dr.GetString(11);
                endereco.bairro = dr.GetString(12);
                endereco.logradouro = dr.GetString(13);
                endereco.cep = dr.GetString(14);
                endereco.complemento = dr.GetString(15);
                endereco.numero = dr.GetString(16);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.ToString());
            }
            return endereco;
        }

    }
}
