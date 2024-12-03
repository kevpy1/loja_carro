using loja_carro.Controller;
using loja_carro.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        public void Insert(Usuario prop)
        {
            Command.Connection = connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Usuario(Usuarionome, Senha) VALUES (@USUARIO, @SENHA)";
            Command.Parameters.AddWithValue("@USUARIO", prop.Usuarionome);
            Command.Parameters.AddWithValue("@SENHA", prop.Senha);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                //throw new Exception("Erro: Problema ao inserir usuário no banco.\n" + err.Message);
                throw err;
            }
            finally
            {
                connect.CloseConnection();
            }
        }

        public void Atualizar(Usuario usuarioAtualizado)
        {
            Command.Connection = connect.ReturnConnection();
            Command.CommandText = @"UPDATE USUARIO SET Usuarionome = @usuario, Senha = @senha WHERE Codusuario = @codusuario";
            Command.Parameters.AddWithValue("@usuario", usuarioAtualizado.Usuarionome);
            Command.Parameters.AddWithValue("@codusuario", usuarioAtualizado.Codusuario);
            Command.Parameters.AddWithValue("@senha", usuarioAtualizado.Senha);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problema ao atualizar usuário no banco.\n" + err.Message);
            }
            finally
            {
                connect.CloseConnection();
            }
        }

        public void Excluir(int codusuario)
        {
            Command.Connection = connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM USUARIO WHERE Codusuario = @codusuario";
            Command.Parameters.AddWithValue("@codusuario", codusuario);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problema ao excluir usuário no banco.\n" + err.Message);
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

            List<Usuario> listaDeUsuarios = new List<Usuario>();

            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                while (rd.Read())
                {
                    Usuario usuario = new Usuario(
                        (int)rd["Codusuario"],
                        (string)rd["Usuarionome"],
                        (string)rd["Senha"]);

                    listaDeUsuarios.Add(usuario);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problema ao ler usuários no banco.\n" + err.Message);
            }
            finally
            {
                connect.CloseConnection();
            }
            return listaDeUsuarios;
        }
    }
}



/*
namespace loja_carro.Model
{
    internal class Broker
    {
        public int Id { get; set; }
        public string BrokerName { get; private set; }
        public string BrokerCode { get; private set; }
        public string State { get; private set; }
        public int CodeArea { get; private set; }
        public string Telephone { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public Broker(string brokerCode, string password)
        {
            this.BrokerCode = brokerCode;
            Password = password;
        }

        public Broker(int id, string brokerName, string brokerCode,
            string state, int codeArea, string telephone, string email,
            string password) : this(brokerName, brokerCode, state, codeArea,
            telephone, email, password)
        {
            Id = id;
        }

        public Broker(string brokerName, string brokerCode,
            string state, int codeArea, string telephone, string email, string password)
        {
            BrokerName = brokerName;
            BrokerCode = brokerCode;
            State = state;
            CodeArea = codeArea;
            Telephone = telephone;
            Email = email;
            Password = password;
        }
    }
}
*/