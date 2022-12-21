using System.Data;
using MySql.Data.MySqlClient;

namespace MovSoft.CODE.DAL
{
	class AcessoBancoDados
	{
		private MySqlConnection conn;
		private DataTable data;
		private MySqlDataAdapter da;
		private MySqlDataReader dr;
		private MySqlCommandBuilder cb;

		private string server = "127.0.0.1";
		private string user = "root";
		private string database = "movsoft";
		private string port = "3306";
		private string password = "root";

		public void Conectar()
		{
			string connStr = string.Format("server={0}; User Id={1}; database={2}; port={3}; password={4}; pooling=false", server, user, database, port, password);
			try
			{
				conn?.Close();
				conn = new(connStr);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Não foi possível realizar a conexão!");
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public void ExecutarComandoSQL(string comandoSql)
		{
			try
			{
				conn.Open();
				if (conn.State == ConnectionState.Open)
				{
					MySqlCommand comando = new(comandoSql, conn);
					comando.ExecuteNonQuery();
                    MessageBox.Show("Registro Criado Com Sucesso!");
                }
				else
				{
					MessageBox.Show("Conexão não foi aberta, impossível executar o comando SQL!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao executar comando SQL!");
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}

		public DataTable RetDataTable(string sql)
		{
			conn.Open();
            data = new();
            da = new(sql, conn);
            cb = new(da);
            da.Fill(data);
            return data;
        }

		public MySqlDataReader RetDataReader(string sql)
		{
            conn.Open();
            MySqlCommand comando = new(sql, conn);
            dr = comando.ExecuteReader();
            dr.Read();
            return dr;
        }
	}
}