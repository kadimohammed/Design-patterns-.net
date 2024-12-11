using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I__Strategy
{
    internal class ServiceMessage
    {
        private IMessageStrategy _messageStrategy;

        public ServiceMessage(IMessageStrategy messageStrategy)
        {
            this._messageStrategy = messageStrategy;
        }

        public void ChangerStrategie(IMessageStrategy newStrategy)
        {
            this._messageStrategy = newStrategy;
        }

        public void Envoyer(string destinataire, string message)
        {
            this._messageStrategy.EnvoyerMessage(destinataire, message);
        }
    }
}
