using FlixOne.InventoryManagement.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace FlixOne.InventoryManagement.Repository
{
    internal class InventoryContext : IInventoryContext
    {
        private static object _lock = new object();
        private static InventoryContext _context;
        /*protected InventoryContext()
        {
            _books = new Dictionary<string, Book>();
        }*/
        protected InventoryContext()
        {
            _books = new ConcurrentDictionary<string, Book>();
        }
        public static InventoryContext Singleton
        {
            /*get
            {
                if (_context == null)
                {
                    _context = new InventoryContext();
                }
                return _context;
            }*/
            /*get
            {
                if (_context == null)
                {
                    lock (_lock)
                    {
                        _context = new InventoryContext();
                    }
                }
                return _context;
            }*/
            get
            {
                if (_context == null)
                {
                    lock (_lock)
                    {
                        if (_context == null)
                        {
                            _context = new InventoryContext();
                        }
                    }
                }
                return _context;
            }
        }
        /*
        public InventoryContext()
        {
            _books = new Dictionary<string, Book>();
        }*/
        private readonly IDictionary<string, Book> _books;
        public Book[] GetBooks()
        {
            return _books.Values.ToArray();
        }
        public bool AddBook(string name)
        {
            _books.Add(name, new Book { Name = name });
            return true;
        }
        /*public bool UpdateQuantity(string name, int quantity)
        {
            _books[name].Quantity += quantity;
            return true;
        }*/

        public bool UpdateQuantity(string name, int quantity)
        {
            lock (_lock)
            {
                _books[name].Quantity += quantity;
            }
            return true;
        }
    }
}
