// Принцип подстановки Барбары Лисков
// Liskov substitution principle
/*
    Поведение наследующих классов не должно противоречивать поведению заданных в базовом классе

    Использование: Необходимо, чтобы замещение наследников родительскими классами было безболезненным для приложения
*/
using System;

namespace LSP {
    // Пример проблемы принципа LSP

    // У нас есть класс описывающий прямоугольник
    public class Rectangle {
        public virtual decimal Width { get; set; }
        public virtual decimal Height { get; set; }

        public Rectangle() {}
        public Rectangle(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public decimal GetArea() => this.Width * this.Height;
    }

    // Основываясь на тот факт, что квадрат является таким же прямоугольником, решаем облегчить себе жизнь и наследуемся от него
    // ⛔⛔⛔
    public class Square : Rectangle {
        public override decimal Width { set => base.Width = base.Height = value; }
        public override decimal Height { set => base.Width = base.Height = value; }
        public Square() {}
        public Square(decimal side) : base (side, side) {}
    }
}