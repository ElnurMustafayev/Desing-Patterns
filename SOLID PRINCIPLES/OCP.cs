using System;
using System.Linq;
using System.Collections.Generic;

// Принцип открытости/закрытости
// Open–closed principle
/*
    Хватит теребить этот бедный класс!
    Давай писать модули!
    
    Использование: Архитектуру необходимо реализовать так, чтобы можно было 
    расширять функционал класса извне, не изменяя сам класс каждый раз

    при коммандной работе это очень полезно, т.к не будет конфликтов изменений в "популярном" классе
*/
namespace OCP {
    // Класс, относительно которого будут проводиться расширения извне 
    public class Person {
        public string Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname, int age) {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Id = Guid.NewGuid().ToString();
        }

        public override string ToString() => string.Join(' ', this.GetType().GetProperties().Select(p => p.GetValue(this)?.ToString()));
    } 

    // класс-сервис который захламлен всякими реализациями выборок ⛔⛔⛔
    public class PersonService {
        // state space explosion (взрыв количества представлений)
        // Плохо, так как всегда нужно будет делать изменения в "неприкосаемом" классе!
        public IEnumerable<Person> FilerById(IEnumerable<Person> people, string id) {
            foreach (var person in people)
                if(person.Id == id)
                    yield return person;
        }
        // При работе с реальными бд не во всех кейсах можно написать фильтрацию предикатом (плохое универсальное решение)
        public IEnumerable<Person> FilerBy (IEnumerable<Person> people, Func<Person, bool> specification) {
            return people.Where(specification);
        }
    }

    // Создаем базовый класс для выборок ✅✅✅
    public abstract class Specification<T> {
        public abstract bool IsSatisfied(T item);

        public static SpecificationCollection<T> operator + (Specification<T> left, Specification<T> rigth) {
            return new SpecificationCollection<T>(left, rigth);
        }
    }

    // теперь у нас для каждой выборки есть отдельный класс
    public class PersonIdSpecification : Specification<Person> {
        private readonly string id;
        public PersonIdSpecification(string id) => this.id = id;
        public override bool IsSatisfied(Person item)
        {
            if(item is null)
                throw new ArgumentNullException($"Argument item can't be null in {this.GetType().Name} specification");

            return item.Id == id;
        }
    }

    // для того чтобы добавить новую выборку нужно всего лишь добавить новый класс базированный на Specification
    public class PersonAdultSpecification : Specification<Person> {
        public override bool IsSatisfied(Person item)
        {
            if(item is null)
                throw new ArgumentNullException("Person");
            else if (item.Age <= 0)
                throw new ArgumentException($"A person with id '{item.Id}' has aged less than 0");

            return item.Age >= 18;
        }
    }

    // комбинирование выборок
    public class SpecificationCollection<T> : Specification<T> {
        private IEnumerable<Specification<T>> Specs;
        public SpecificationCollection(params Specification<T>[] specs)
        {
            this.Specs = specs;
        }

        public override bool IsSatisfied(T item)
        {
            return this.Specs.All(spec => spec.IsSatisfied(item));
        }
    }

    // создаем отдельный класс для Фильтрации ✅✅✅
    public interface IFilter<T> {
        IEnumerable<T> FilterBy(IEnumerable<T> items, Specification<T> specification);
    }
        public class Filter<T> : IFilter<T> {
        public IEnumerable<T> FilterBy(IEnumerable<T> items, Specification<T> specification) {
            foreach (var item in items)
                if(specification.IsSatisfied(item))
                    yield return item;
        }
    }
}