using System;
using System.Collections.Generic;
using System.Text;

namespace FlixOne.InventoryManagement.Command
{
    internal interface IParameterisedCommand
    {
        bool GetParameters();
    }
}
