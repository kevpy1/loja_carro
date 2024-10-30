using loja_carro.Controller;
using loja_carro.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
                throw new Exception("erro: Problema ao" + "insirir carro no banco.\n" + err.Message);
            }
            finally
            {
                connect.CloseConnection();
            }
        }
       

        public void Atualizar(Usuario usuarioAtualizado)
        {
            Command.Connection = connect.ReturnConnection();
            Command.CommandText = @"UPDATE USUARIO SET Usuario = @usuario, Senha = @senha, WHERE codusuario= @codusuario";
         
            Command.Parameters.AddWithValue("@usuario", usuarioAtualizado.Usuarionome);
            Command.Parameters.AddWithValue("@codusuario", usuarioAtualizado.Codusuario);
            Command.Parameters.AddWithValue("@senha", usuarioAtualizado.Senha);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                connect.CloseConnection();
            }
        }

        public void Excluir(int codusuario)
        {
            Command.Connection = connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Usuario WHERE codusuario = @code";
            Command.Parameters.AddWithValue("@codusuario", "@code");
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connect.CloseConnection();
            }
        }
        public List<Usuario> ListarTodosUsuarios()
        {

            Command.Connection = connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM USUARIO";

            List<Usuario> listaDeUsuarios = new List<Usuario>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Usuario usuario = new Usuario(
                        (int)rd["Codusuario"],
                        (string)rd["usuario"], 
                        (string)rd["senha"]);
                
                      
                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                connect.CloseConnection();
            }
            return listaDeUsuarios;
        }
    }
}