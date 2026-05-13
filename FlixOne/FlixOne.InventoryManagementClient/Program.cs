using FlixOne.InventoryManagement.Command;
using FlixOne.InventoryManagement.UserInterface;
using Microsoft.Extensions.DependencyInjection;

namespace FlixOne.InventoryManagementClient
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddTransient<IUserInterface, ConsoleUserInterface>();
            services.AddTransient<IInventoryCommandFactory, InventoryCommandFactory>();
        }
    }
}
