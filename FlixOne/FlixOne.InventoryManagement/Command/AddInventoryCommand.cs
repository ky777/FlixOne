using FlixOne.InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;
using FlixOne.InventoryManagement.Repository;

namespace FlixOne.InventoryManagement.Command
{
    internal class AddInventoryCommand : NonTerminatingCommand, IParameterisedCommand
    {
        private readonly IInventoryContext _context;
        public string InventoryName { get; private set; }
        internal AddInventoryCommand(IUserInterface userInterface, IInventoryContext context)
            : base(userInterface: userInterface) 
        {
            _context = context;
        }
        protected override bool InternalCommand()
        {
            return _context.AddBook(InventoryName);
            //throw new NotImplementedException("Будет реализовано в следующей главе!");
        }

        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");
            return !string.IsNullOrWhiteSpace(InventoryName);

        }
    }

}
