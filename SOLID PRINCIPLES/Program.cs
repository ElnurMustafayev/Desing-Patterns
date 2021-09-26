using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SPR;
using OCP;
using LSP;
using ISP;

namespace SOLID_PRINCIPLES
{
    class Program
    {
        static int CurrentSolid = 3;
        static bool RunAll = false;
        static async Task Main(string[] args)
        {
            // Принцип единственной ответственности
            // single-responsibility principle, SRP
            /* 
                Каждый класс занимается только своим делом 
                Скажи нет божественным классам!

                Использование: При написании clean-code, нормального production-enterprise проекта
            */
            if(CurrentSolid == 0 || RunAll) {
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
            if(CurrentSolid == 1 || RunAll) {
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
        
            // Принцип подстановки Барбары Лисков
            // Liskov substitution principle
            /*
                Поведение наследующих классов не должно противоречивать поведению заданных в базовом классе

                Использование: Необходимо, чтобы замещение наследников родительскими классами было безболезненным для приложения
            */
            if(CurrentSolid == 2 || RunAll) {
                // предположим мы проводим Unit test для некоторого количества объектов
                List<Rectangle> rectangles = new List<Rectangle>() {
                    new Rectangle(),
                    new Rectangle(0,0),
                    new Square(),           // ⛔⛔⛔
                    new Rectangle(5,10),
                };

                // задаем какие-то тестовые параметры
                rectangles.ForEach(r => {
                    r.Width = 5;
                    r.Height = 10;
                });

                // и вызываем API "GetArea()" для теста
                foreach (var rectangle in rectangles)
                    System.Console.WriteLine($"{rectangle.GetType().Name}: {rectangle.GetArea()}");

                // объект Square не прошел тест, вернув совершенно другое значение, 
                // что показывает - архитектура не удовлетворяет тредованиям принципа Лисков 
            }

            // Принцип разделения интерфейсов
            // Interface Segregation Principle
            /*
                Не создавай супер интерфейсы,
                Лучше раздели их на логические части!
            */
            if(CurrentSolid == 3 || RunAll) {
                // ⛔⛔⛔
                var birds = new IBird[] {
                    new Swan(),
                    new Chicken()
                };
                try {
                    foreach (var bird in birds)
                    {
                        bird.Walk();
                        // Программа обвалится на курице потому что она не умеет ни плавать, ни летать
                        bird.Fly();
                        bird.Swim();
                    }
                }
                catch(Exception ex) {
                    System.Console.WriteLine(ex.Message);
                }

                // ✅✅✅
                var fliables = new List<IFly>() {
                    new Parrot(),
                };

                var walkables = new List<IWalk>() {
                    new Parrot(), new Flamingo(),
                };

                fliables.ForEach(f => f.Fly());
                walkables.ForEach(w => w.Walk());
            }
        }
    }
}
