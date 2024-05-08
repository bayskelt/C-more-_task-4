using System;
using System.Collections.Generic;
using System.Linq;

namespace C__more__task_4
{
    // Клас Automobile
    public class Automobile
    {
        // Властивості класу
        public string Name { get; set; }
        public int MaxSpeed { get; set; }

        // Конструктор класу
        public Automobile(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        // Метод для виведення інформації про автомобіль
        public void DisplayInformation()
        {
            Console.WriteLine($"Назва: {Name}, Максимальна швидкiсть: {MaxSpeed} км/год");
        }
    }

    class Program
    {
        static void Main()
        {
            // Створення колекції автомобілів
            List<Automobile> automobiles = new List<Automobile>
        {
            new Automobile("Tesla Model S", 250),
            new Automobile("Bugatti Veyron", 407),
            new Automobile("Toyota Corolla", 180)
        };

            // Виведення інформації про всі автомобілі
            Console.WriteLine("Iнформацiя про всi автомобiлi:");
            foreach (var auto in automobiles)
            {
                auto.DisplayInformation();
            }

            // Пошук автомобіля з найвищою максимальною швидкістю
            var fastestAuto = automobiles.OrderByDescending(a => a.MaxSpeed).First();
            Console.WriteLine($"\nАвтомобiль з найвищою максимальною швидкiстю: {fastestAuto.Name}");
        }
    }
}
