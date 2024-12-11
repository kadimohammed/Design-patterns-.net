using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I__Strategy
{
    internal class EmailMessageStrategy : IMessageStrategy
    { 
        public void EnvoyerMessage(string destinataire, string message)
        {
            Console.WriteLine($"Envoi de lemail a {destinataire}: {message}");
        }
    }
}
