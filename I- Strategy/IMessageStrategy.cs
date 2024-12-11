using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I__Strategy
{
    internal interface IMessageStrategy
    {
        void EnvoyerMessage(string destinataire, string message);
    }
}
