using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_KP.Model
{
    //
    // СТРУКТУРНЫЙ ПАТТЕРН МОСТ "BRIDGE"
    //

    // Базовый абстрактный класс комплектующего
    public abstract class Component
    {
        public virtual string Manufacturer { get; set; } // Производитель

        public virtual string Title { get; set; } // Название

        public virtual int Price { get; set; } // Цена        

        // Создание комплектующего с минимальным набором характеристик
        public Component CreateComponent(string manuf, string title, int price)
        {
            this.Title = title;
            this.Price = price;
            this.Manufacturer = manuf;

            return this;
        }
    }

    // Конкретная реализация класса Component
    public class Motherboard : Component
    {
        public override string Manufacturer { get; set; }

        public override string Title { get; set; }

        public override int Price { get; set; }

        // Вызов метода из базового класса без расширения набора характеристик комплектующего
        public new Motherboard CreateComponent(string manuf, string title, int price)
        {
            base.CreateComponent(manuf, title, price);

            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2} ₽", this.Manufacturer, this.Title, this.Price);
        }
    }

    // Конкретная реализация класса Component
    public class CPU : Component
    {
        public override string Manufacturer { get; set; }

        public override string Title { get; set; }

        public override int Price { get; set; }

        public int Cores { get; set; } // Количествово ядер

        public decimal Frequancy { get; set; } // Базовая частота

        // Расширение базового набора характеристик комплектующего
        public CPU CreateComponent(string manuf, string title, int price, int cores, decimal frequancy)
        {
            base.CreateComponent(manuf, title, price);
            this.Cores = cores;
            this.Frequancy = frequancy;

            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} cores, {3} GHz, {4} ₽", this.Manufacturer, this.Title, this.Cores, this.Frequancy, this.Price);
        }
    }

    // Конкретная реализация класса Component
    public class GPU : Component
    {
        public override string Manufacturer { get; set; }

        public override string Title { get; set; }

        public override int Price { get; set; }

        public int VideoMemory { get; set; } // Объем видеопамяти

        // Расширение базового набора характеристик комплектующего
        public GPU CreateComponent(string manuf, string title, int price, int vm)
        {
            base.CreateComponent(manuf, title, price);
            this.VideoMemory = vm;

            return this;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} GB, {3} ₽", this.Manufacturer, this.Title, this.VideoMemory, this.Price);
        }
    }
}
