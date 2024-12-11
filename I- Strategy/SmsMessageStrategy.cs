using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I__Strategy
{
    internal class SmsMessageStrategy : IMessageStrategy
    {
        public void EnvoyerMessage(string destinataire, string message)
        {
            Console.WriteLine($"Envoi du SMS a {destinataire}: {message}");
        }
    }
}
