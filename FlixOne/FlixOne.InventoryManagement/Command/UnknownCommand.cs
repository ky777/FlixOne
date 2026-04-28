using FlixOne.InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlixOne.InventoryManagement.Command
{
    internal class UnknownCommand : NonTerminatingCommand
    {
        internal UnknownCommand(IUserInterface userInterface)
            : base(userInterface: userInterface) { }
        protected override bool InternalCommand()
        {
            Interface.WriteWarning("Unable to determine the desired command.");
            return false;
        }
    }
}
