using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L__Command
{
    internal interface ICommand
    {
        void Execute();  // Executer la commande
        void Undo();     // Annuler la commande
    }
}
