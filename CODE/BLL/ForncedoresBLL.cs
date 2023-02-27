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
                string comando = $"call cad_fornecedor('{dtoFornecedores.RazaoSocial}', '{dtoFornecedores.Cnpj}', '{dtoEnderecos.Estado}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar fornecedor!");
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarFornecedores()
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable("call fornecedores()");
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
                string comando = $"call edit_fornecedor({dtoFornecedores.Id_fornecedor},{dtoEnderecos.Id_endereco},'{dtoFornecedores.RazaoSocial}', '{dtoFornecedores.Cnpj}', '{dtoEnderecos.Estado}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar fornecedor!");
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
                Parametros.razaoSocial = dr.GetString(1);
                Parametros.Cnpj = dr.GetString(2);
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
                Parametros.idEndereco = dr.GetInt32(3);
                Parametros.uf = dr.GetString(4);
                Parametros.cidade = dr.GetString(5);
                Parametros.bairro = dr.GetString(6);
                Parametros.logradouro = dr.GetString(7);
                Parametros.cep = dr.GetString(8);
                Parametros.complemento = dr.GetString(9);
                Parametros.numero = dr.GetString(10);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}