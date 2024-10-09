using loja_carro.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_carro.Resources.Model
{
    internal class PropertyDAO
    {
        private Connection connect { get; set; }
        private SqlCommand Command { get; set; }

        public PropertyDAO()
        {
            connect = new Connection();
            Command = new SqlCommand();

        }
        public void insert(Property prop)
        {
            Command.Connection = connect.ReturnConnection();
            Command.CommandText = @"INSER INTO Usuario VALUES 
         (@Marca,@Modelo,  @Preco)";

            Command.Parameters.AddWithValue("@Marca", prop.Marca);
            Command.Parameters.AddWithValue("Modelo", prop.Modelo);
            Command.Parameters.AddWithValue("Preco", prop.Preco);

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