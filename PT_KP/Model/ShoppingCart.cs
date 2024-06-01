using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PT_KP.Model;

namespace PT_KP.Model
{
    // Класс корзины
    public class ShoppingCart
    {
        // Список записей в корзине
        private static List<CartRecord> recordsList = new List<CartRecord>();

        // Добавление товара в корзину
        public static void AddItem(Computer computer, int quantity)
        {
            CartRecord record = recordsList
                .Where(item => item.Computer.Title == computer.Title)
                .FirstOrDefault();

            if (record == null)
            {
                recordsList.Add(new CartRecord(computer, quantity));
            }
            else
            {
                record.Quantity += quantity;
                record.Title = record.Computer.Title + "; Кол-во: " + record.Quantity + "; Итог " + (record.Computer.Price * record.Quantity);
            }
        }

        // Удаление товара из корзины
        public static void RemoveRecord(CartRecord record)
        {
            CartRecord curRecord = recordsList
                .Where(item => item.Title == record.Title)
                .FirstOrDefault();

            if (curRecord.Quantity > 1)
            {
                curRecord.Quantity -= 1;
                record.Title = record.Computer.Title + "; Кол-во: " + record.Quantity + "; Итог " + (record.Computer.Price * record.Quantity);
            }
            else
            {
                recordsList.RemoveAll(item => item.Title == record.Title);
            }            
        }

        // Подсчет итоговой стоимости
        public static decimal ComputeTotalValue()
        {
            return recordsList.Sum(item => item.Computer.Price * item.Quantity);
        }

        // Очистка корзины
        public static void ClearShoppingCart()
        {
            recordsList.Clear();
        }

        // Получение списка записей
        public static List <CartRecord> GetRecords
        {
            get { return recordsList; }
        }
    }

    // Класс записи в корзине
    public class CartRecord
    {
        public string Title { get; set; }
        public Computer Computer { get; set; }
        public int Quantity { get; set; }

        public CartRecord(Computer computer, int quantity)
        {
            this.Computer = computer;
            this.Quantity = quantity;
            this.Title = Computer.Title + "; Кол-во: " + Quantity + "; Итог: " + (Computer.Price * Quantity);
        }
    }
}