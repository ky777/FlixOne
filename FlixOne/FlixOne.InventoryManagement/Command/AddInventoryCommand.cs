using FlixOne.InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlixOne.InventoryManagement.Command
{
    internal class AddInventoryCommand : NonTerminatingCommand, IParameterisedCommand
    {
        public string InventoryName { get; private set; }
        internal AddInventoryCommand(IUserInterface userInterface)
            : base(userInterface: userInterface) { }
        protected override bool InternalCommand()
        {
            throw new NotImplementedException("Будет реализовано в следующей главе!");
        }

        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");
            return !string.IsNullOrWhiteSpace(InventoryName);

        }
    }

}
