using System.Data.SqlClient;

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

        // Construtor único
        public Broker(string brokerName, int id, string brokerCode, string state,
                      int codeArea, string telephone, string email, string password)
        {
            Id = id;
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
