using MovSoft.Classes;
using MovSoft.CODE.DAL;
using MovSoft.CODE.DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace MovSoft.CODE.BLL
{
    class ClientesBLL
    {
        AcessoBancoDados db = new();

        public void CadastrarCliente(ClientesDTO dtoClientes,EnderecosDTO dtoEnderecos, ContatosDTO dtoContatos)
        {
            try
            {
                db.Conectar();
                string comando = $"call cad_cliente('{dtoClientes.Nome}', '{dtoClientes.Sobrenome}', '{dtoClientes.Data_nasc}', '{dtoClientes.Cpf}', '{dtoClientes.Email}', {dtoClientes.Id_sexo}, '{dtoEnderecos.Uf}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}', '{dtoContatos.Ddd}', '{dtoContatos.Celular}', 'S')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente!");
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable MostrarClientes()
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable("call clientes('S')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public DataTable ProcurarClientes(string pesquisa)
        {
            DataTable dataTable = new();
            try
            {
                db.Conectar();
                dataTable = db.RetDataTable($"call procurarClientes('{pesquisa}')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public void EditarCliente(ClientesDTO dtoClientes, EnderecosDTO dtoEnderecos, ContatosDTO dtoContatos)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_cliente({dtoClientes.Id_cliente},{dtoEnderecos.Id_endereco},{dtoContatos.Id_celular},'{dtoClientes.Nome}', '{dtoClientes.Sobrenome}', '{dtoClientes.Data_nasc}', '{dtoClientes.Cpf}', '{dtoClientes.Email}', {dtoClientes.Id_sexo}, '{dtoEnderecos.Uf}', '{dtoEnderecos.Cidade}', '{dtoEnderecos.Bairro}', '{dtoEnderecos.Logradouro}', '{dtoEnderecos.Cep}', '{dtoEnderecos.Complemento}', '{dtoEnderecos.Numero}', '{dtoContatos.Ddd}', '{dtoContatos.Celular}', 'S')";
                db.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar cliente!");
                MessageBox.Show(ex.Message);
            }
        }

        public void PegarDados(int idCliente)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_selec_clientes({idCliente})";
                MySqlDataReader dr = db.RetDataReader(comando);
                Parametros.idCliente = dr.GetInt32(0);
                Parametros.nomeCliente = dr.GetString(1);
                Parametros.sobrenomeCliente = dr.GetString(2);
                Parametros.dddCliente = dr.GetString(3);
                Parametros.celularCliente = dr.GetString(4);
                Parametros.cpfCliente = dr.GetString(5);
                Parametros.nascimentoInputCliente = dr.GetString(6);
                Parametros.idSexoCliente = dr.GetInt32(7);
                Parametros.emailCliente = dr.GetString(8);
                Parametros.nascimentoInputCliente = Parametros.nascimentoInputCliente.Replace("/", "");
                Parametros.nascimentoInputCliente = Parametros.nascimentoInputCliente.Substring(0,8);
                Parametros.idCelularCliente = dr.GetInt32(17);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar registro!");
                MessageBox.Show(ex.Message);
            }
        }

        public void PegarEndereco(int idCliente)
        {
            try
            {
                db.Conectar();
                string comando = $"call edit_selec_clientes({idCliente})";
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