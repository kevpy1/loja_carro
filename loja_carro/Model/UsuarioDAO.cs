using loja_carro.Controller;
using loja_carro.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_carro.Resources.Model
{
    internal class UsuarioDAO
    {
        private Connection connect { get; set; }
        private SqlCommand Command { get; set; }

        public UsuarioDAO()
        {
            connect = new Connection();
            Command = new SqlCommand();

        }
        public void insert(Usuario prop)
        {
            Command.Connection = connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO USUARIO VALUES 
         (@USUARIO, @SENHA)";

            Command.Parameters.AddWithValue("@USUARIO", prop.Usuarionome);
            Command.Parameters.AddWithValue("@SENHA", prop.Senha);
         

            try

            {
                Command.ExecuteNonQuery();
            }

            catch (Exception err)
            {
                throw new Exception("erro: Problema ao" + "insirir imóvel no banco.\n" + err.Message);
            }
            finally
            {
                connect.CloseConnection();
            }
        }
    }
}