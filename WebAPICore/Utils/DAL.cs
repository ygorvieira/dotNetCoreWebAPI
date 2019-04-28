using MySql.Data.MySqlClient;
using System.Data;

namespace WebAPICore.Utils
{
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "DBCLIENTE";
        private static string User = "root";
        private static string Password = "";
        private MySqlConnection Connection;

        private string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};SslMode=none";

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

        public DataTable RetornarDataTable(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(sql, Connection);
            DataTable Dados = new DataTable();
            DataAdapter.Fill(Dados);
            return Dados;
        }
    }
}
