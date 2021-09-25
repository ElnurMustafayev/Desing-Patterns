using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SPR;
using OCP;

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
                await todo.SaveInFile("assets/SPR.txt", false);                     // ⛔⛔⛔

                // Теперь все объекты (в данном случае, с правильно реализованным методом ToString())
                // могут сохраняться в файл с помощью отдельного класса-помощника
                await Saver.SaveToStringInFile("assets/SPR.txt", todo, false);      // ✅✅✅
            }


            // Принцип открытости/закрытости
            // Open–closed principle
            /*
                Хватит теребить этот бедный класс!
                Давай писать модули!
                
                Использование: Архитектуру необходимо реализовать так, чтобы можно было 
                расширять функционал класса извне, не изменяя сам класс каждый раз
            */
            {
                IEnumerable<Person> people = new List<Person>() {
                    new Person("Elnur", "Mustafayev", 21),
                    new Person("Ann", "Brown", 17),
                    new Person("John", "Smith", 32),
                };
                string someID = people.FirstOrDefault().Id;

                // ⛔⛔⛔
                // просто создаем класс без полиморфизма и гибкости
                PersonService personService = new PersonService();
                var serviceResult = personService.FilerById(people, id: someID);

                // ✅✅✅
                // создал фильтр
                IFilter<Person> personFilter = new Filter<Person>();
                // создал нужные спецификации
                var idSpec = new PersonIdSpecification(id: someID);
                var adultSpec = new PersonAdultSpecification();
                // сделал выборку
                var filterResult = personFilter.FilterBy(items: people, specification: idSpec + adultSpec);
            }
        }
    }
}
