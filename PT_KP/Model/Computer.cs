using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_KP.Model
{
    // Абстрактный класс компьютера
    // который хранит ссылку на объекты класса Component (Комплектующее)
    public abstract class Computer
    {
        public abstract string Title { get; set; } // Название компьютера

        public abstract Component Motherboard { get; set; } // Материнская плата

        public abstract Component Cpu { get; set; } // Процессор

        public abstract Component Gpu { get; set; } // Видеокарта

        public abstract decimal Price { get; set; } // Цена компьютера

        // Получение характеристик компьютера
        public abstract string GetSpecification();
    }

    // Конкретная реализация класса Computer
    public class PC : Computer
    {
        public override string Title { get; set; } // Название компьютера

        public override Component Motherboard { get; set; } // Материнская плата

        public override Component Cpu { get; set; } // Процессор

        public override Component Gpu { get; set; } // Видеокарта

        public override decimal Price { get; set; } // Цена компьютера

        // Получение характеристик компьютера
        public override string GetSpecification()
        {
            return string.Format("ПК {0}:\nМатеринская плата: {1}\nПроцессор: {2}\nВидеокарта: {3}\n\nЦена: {4}", this.Title, this.Motherboard, this.Cpu, this.Gpu, this.Price);
        }

        public PC(string Title, Motherboard motherboard, CPU cpu, GPU gpu, decimal price)
        {
            this.Title = Title;
            this.Motherboard = motherboard;
            this.Cpu = cpu;
            this.Gpu = gpu;
            this.Price = price;
        }

        public PC() { }
    }

    // Класс-строитель
    // который по совместительству делегирует выполнение операций методам объекта класса Component (Комплектующее)
    public class PCBuilder
    {
        private PC curPC;

        public PCBuilder()
        {
            curPC = new PC();
        }

        // Добавление материнской платы
        public PCBuilder AddMotherboard(string manuf, string title, int price)
        {
            curPC.Motherboard = new Motherboard().CreateComponent(manuf, title, price);
            curPC.Price += price;
            return this;
        }

        // Добавление процессора
        public PCBuilder AddCpu(string manuf, string title, int price, int cores, decimal frequency)
        {
            curPC.Cpu = new CPU().CreateComponent(manuf, title, price, cores, frequency);
            curPC.Price += price;
            return this;
        }

        // Добавление видеокарты
        public PCBuilder AddGpu(string manuf, string title, int price, int vm)
        {
            curPC.Gpu = new GPU().CreateComponent(manuf, title, price, vm);
            curPC.Price += price;
            return this;
        }

        // Добавление названия и финальная сборка объекта класса PC (Персональный компьютер)
        public PC Build(string title)
        {
            curPC.Title = title;
            return curPC;
        }
    }
}
