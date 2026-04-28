using FlixOne.InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlixOne.InventoryManagement.Command
{
    internal class GetInventoryCommand:NonTerminatingCommand
    {
        internal GetInventoryCommand(IUserInterface userInterface):base(userInterface: userInterface) { }

        protected override bool InternalCommand()
        {
            throw new NotImplementedException("Будет реализовано в следующей главе!");
        }
    }
}
