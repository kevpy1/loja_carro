using System;
using System.Data.SqlClient;

namespace loja_carro.Controller
{
    internal class Connection
    {
        private SqlConnection con;
        private string Database = "PR2CJ3022358LOJADECARRO";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public Connection()
        {
            string stringconnection = @"Data Source=" + Server
            + ";Initial Catalog=" + Database
            + ";User ID=" + Username
            + ";Password=" + Password
            + ";Encrypt=False";

            con = new SqlConnection(stringconnection);
            con.Open();
        }

        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
