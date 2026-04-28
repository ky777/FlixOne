using System;
using System.Collections.Generic;
using System.Text;

namespace FlixOne.InventoryManagement.UserInterface
{
    /*public interface IUserInterface
    {
        /// <summary>
        /// Чтение значения из консоли
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        string ReadValue(string message);
        /// <summary>
        /// Сообщение в консоль
        /// </summary>
        /// <param name="message"></param>
        void WriteMessage(string message);
        /// <summary>
        /// Вывод предупреждения в консоль
        /// </summary>
        /// <param name="message"></param>
        void WriteWarning(string message);


    }*/
    public interface IUserInterface:IReadUserInterface, IWriteUserInterface
    { }
    public interface IReadUserInterface
    {
        /// <summary>
        /// Чтение значения из консоли
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        string ReadValue(string message);
    }
    public interface IWriteUserInterface
    {
        /// <summary>
        /// Сообщение в консоль
        /// </summary>
        /// <param name="message"></param>
        void WriteMessage(string message);
        /// <summary>
        /// Вывод предупреждения в консоль
        /// </summary>
        /// <param name="message"></param>
        void WriteWarning(string message);
    }

}
