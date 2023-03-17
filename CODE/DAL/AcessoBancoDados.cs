using System.Data;
using MySql.Data.MySqlClient;
using IniParser.Model;
using MovSoft.Classes;
using System.Text.RegularExpressions;

namespace MovSoft.CODE.DAL
{
    class AcessoBancoDados
    {
        private IniData iniData;
        private MySqlConnection conn;
        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;

        private string server = "127.0.0.1";
        private string user = "root";
        private string database = "movsoft";
        private string port = "3305";
        private string password = "root";

        private async void GetIniData()
        {
            iniData = Funcoes.LerIni();
            server = iniData["DataBase"]["DB_Server"];
            user = iniData["DataBase"]["DB_Username"];
            database = iniData["DataBase"]["DB_Database"];
            port = iniData["DataBase"]["DB_Port"];
            password = iniData["DataBase"]["DB_Password"];
        }

        public void Conectar()
        {
            GetIniData();
            string connStr = string.Format("server={0}; User Id={1}; database={2}; port={3}; password={4}; pooling=false", server, user, database, port, password);
            try
            {
                conn?.Close();
                conn = new(connStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a conexão!");
                MessageBox.Show(ex.Message);
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
                    MessageBox.Show("Registro salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Conexão não foi aberta, impossível executar o comando SQL!");
                }
            }
            catch (Exception ex)
            { 
                if(((MySqlException)ex).ErrorCode == -2147467259)
                {
                    string padrao = @"'([^']*)'\s*?$";
                    Match match = Regex.Match(ex.Message, padrao);
                    if (match.Success)
                    {
                        string ultimaPalavraEntreAspasSimples = match.Groups[1].Value;
                        MessageBox.Show($"Esse {match.Groups[1].Value.ToUpper()} já foi cadastrado no sistema!", "Erro ao salvar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao executar o procedimento");
                }
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