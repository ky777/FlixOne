using FlixOne.InventoryManagement.UserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlixOne.InventoryManagement.Command
{
    public abstract class InventoryCommand
    {
        private readonly bool _isTerminatingCommand;
        protected IUserInterface Interface { get;}
        protected InventoryCommand(bool commandIsTerminating, IUserInterface userInterface)
        {
            _isTerminatingCommand = commandIsTerminating;
            Interface = userInterface;
        }
        public (bool wasSuccessful, bool shouldQuit) RunCommand()
        {
            if (this is IParameterisedCommand parameterisedCommand)
            {
                var allParametersCompleted = false;
                //while (allParametersCompleted==false)
                while (!allParametersCompleted)
                {
                    allParametersCompleted = parameterisedCommand.GetParameters();
                }
            }
            return (InternalCommand(), _isTerminatingCommand);
        }
        protected abstract bool InternalCommand();
        protected string GetParameter(string parameterName)
        {
            return Interface.ReadValue($"Enter {parameterName}:");
        }
    }
}
