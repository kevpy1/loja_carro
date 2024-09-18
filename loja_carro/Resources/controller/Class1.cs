using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_carro.Controller
{
    internal class Connection
    {
        private SqlConnection con;
        private string Database = "PRCJ3022358LOJADECARRO";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";
        public Connection()
        {
            string stringconnection = @"Data Source  = " + Server
            + "; initial catalog  = " + Database
            + "; user Id =" + Username
            + "; Password = " + Password
            + "; encrypt = false ";

            // string atringconnection = @ "Data souce=" + enviror

            con = new SqlConnection(stringconnection);
            con.Open(); // abrir a conexão com o banco de dados

            // tente fechar a conexão que foi aberta 

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
      

    

