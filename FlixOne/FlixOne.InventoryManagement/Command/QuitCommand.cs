using FlixOne.InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlixOne.InventoryManagement.Command
{
    internal class QuitCommand:InventoryCommand
    {
        internal QuitCommand(IUserInterface userInterface)
            :base(commandIsTerminating: true, userInterface: userInterface) { }
        protected override bool InternalCommand()
        {
            Interface.WriteMessage("Спасибо за использование FlixOne Inventory Management System");
            return true;
        }

    }
}