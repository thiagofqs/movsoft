using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    class FornecedoresBLL
    {
        AcessoBancoDados db = new();

        public void CadastrarFornecedor(FornecedoresDTO dtoFornecedores, EnderecosDTO dtoEnderecos)
        {
            try
            {
                db.Conectar();
                string comando = $"call cad_fornecedor('{dtoFornecedores.Nome_fantasia}', '{dtoFornecedores.Razao_social}', '{dtoFornecedores.Cnpj}', " +
                    $"'{dtoEnderecos.Uf}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', " +
                    $"'{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}','{dtoFornecedores.Ativo}')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar fornecedor!");
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarFornecedores(string filtro)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable($"call fornecedores('{filtro}')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public DataTable ProcurarFornecedores(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable($"call procurarFornecedores('{pesquisa}')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public void EditarFornecedor(FornecedoresDTO dtoFornecedores, EnderecosDTO dtoEnderecos)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_fornecedor({dtoFornecedores.Id_fornecedor}, {dtoEnderecos.Id_endereco}, '{dtoFornecedores.Nome_fantasia}', '{dtoFornecedores.Razao_social}', '{dtoFornecedores.Cnpj}', '{dtoEnderecos.Uf}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}','{dtoFornecedores.Ativo}')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void PegarDados(int idFornecedor)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_selec_fornecedores({idFornecedor})";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idFornecedor = dr.GetInt32(0);
                Parametros.nomeFantasia = dr.GetString(1);
                Parametros.razaoSocial = dr.GetString(2);
                Parametros.cnpj = dr.GetString(3);
                Parametros.FornecedorAtivo = dr.GetString(12);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void PegarEndereco(int idFornecedor)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_selec_fornecedores({idFornecedor})";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idEndereco = dr.GetInt32(4);
                Parametros.uf = dr.GetString(5);
                Parametros.cidade = dr.GetString(6);
                Parametros.bairro = dr.GetString(7);
                Parametros.logradouro = dr.GetString(8);
                Parametros.cep = dr.GetString(9);
                Parametros.complemento = dr.GetString(10);
                Parametros.numero = dr.GetString(11);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}