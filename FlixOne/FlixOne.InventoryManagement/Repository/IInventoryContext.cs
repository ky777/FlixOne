using FlixOne.InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlixOne.InventoryManagement.Repository
{
    internal interface IInventoryContext
    {
        Book[] GetBooks();
        bool AddBook(string name);
        bool UpdateQuantity(string name, int quantity);
    }
}
