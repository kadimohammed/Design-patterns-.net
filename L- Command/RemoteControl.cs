using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L__Command
{
    internal class RemoteControl
    {
        private ICommand _command;

        // Associer une commande a un bouton
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        // excuter la commande
        public void PressButton()
        {
            _command?.Execute();
        }

        // annuler la derniere commande
        public void PressUndo()
        {
            _command?.Undo();
        }
    }
}
