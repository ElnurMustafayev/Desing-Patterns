using System;
using System.Threading.Tasks;
using SPR;

namespace SOLID_PRINCIPLES
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Принцип единственной ответственности
            // single-responsibility principle, SRP
            /* 
                Каждый класс занимается только своим делом 
                Скажи нет божественным классам!

                Использование: При написании clean-code, нормального production-enterprise проекта
            */
            {
                ToDoList todo = new ToDoList("task1", "task1", "task1");
                // ToDoList сам сохраняет себя - это неправильно!
                //await todo.SaveInFile("SPR.txt", false);                  // ❌

                // Теперь все объекты (в данном случае, с правильно реализованным методом ToString())
                // могут сохраняться в файл с помощью отдельного класса-помощника
                await Saver.SaveToStringInFile("SPR.txt", todo, false);     // ✔
            }

        }
    }
}
