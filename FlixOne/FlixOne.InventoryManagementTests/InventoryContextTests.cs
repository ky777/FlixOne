using FlixOne.InventoryManagement.Repository;
using Mono.Cecil.Cil;

namespace FlixOne.InventoryManagementTests;

[TestClass]
public class InventoryContextTests
{
    [TestMethod]
    public void MaintainBooks_Successful()
    {
        List<Task> tasks = new List<Task>();

        var context = InventoryContext.Singleton;
        // добавление 30 книг
        /*foreach (var id in Enumerable.Range(1, 30))
        {
            context.AddBook($"Book_{id}");
        }*/
        foreach (var id in Enumerable.Range(1, 30))
        {
            tasks.Add(AddBook($"Book_{id}"));
        }
        Task.WaitAll(tasks.ToArray());
        tasks.Clear();


        // обновим количество книг, добавив 1, 2, 3, 4, 5...
        foreach (var quantity in Enumerable.Range(1, 10))
        {
            foreach (var id in Enumerable.Range(1, 30))
            {
                context.UpdateQuantity($"Book_{id}", quantity);
            }
        }
        // обновим количество книг, отняв 1, 2, 3, 4, 5...
        /*foreach (var quantity in Enumerable.Range(1, 10))
        {
            foreach (var id in Enumerable.Range(1, 30))
            {
                context.UpdateQuantity($"Book_{id}", -quantity);
            }
        }*/
        foreach (var quantity in Enumerable.Range(1, 10))
        {
            foreach (var id in Enumerable.Range(1, 30))
            {
            tasks.Add(UpdateQuantity($"Book_{id}", quantity));
            }
        }


        // все величины должны быть равны 0
        /*foreach (var book in context.GetBooks())
        {
            Assert.AreEqual(0, book.Quantity);
        }*/
        foreach (var quantity in Enumerable.Range(1, 10))
        {
            foreach (var id in Enumerable.Range(1, 30))
            {
                tasks.Add(UpdateQuantity($"Book_{id}", -quantity));
            }
        }
        // ждем, пока все сложения и вычитания не завершатся
        Task.WaitAll(tasks.ToArray());
    }
    public Task AddBook(string book)
    {
        return Task.Run(() =>
        {
            var context = InventoryContext.Singleton;
            Assert.IsTrue(context.AddBook(book));
        });
    }
    public Task UpdateQuantity(string book, int quantity)
    {
        return Task.Run(() =>
        {
            var context = InventoryContext.Singleton;
            Assert.IsTrue(context.UpdateQuantity(book, quantity));
        });
    }
}
