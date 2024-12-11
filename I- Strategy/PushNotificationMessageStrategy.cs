using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I__Strategy
{
    internal class PushNotificationMessageStrategy : IMessageStrategy
    {
        public void EnvoyerMessage(string destinataire, string message)
        {
            Console.WriteLine($"Envoi de la notification push a {destinataire}: {message}");
        }
    }
}
