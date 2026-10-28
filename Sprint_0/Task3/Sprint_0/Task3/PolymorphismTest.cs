using System;
using Tyuiu.mamatqulov.Sprint_0.Task1;

namespace Tyuiu.mamatqulov.Sprint_0.Task3
{
    public class PolymorphismTest
    {
        public static void Run()
        {
            Console.WriteLine("=== Задание 3: Демонстрация полиморфизма ===");

            // Массив растений разных типов
            Plant[] garden = new Plant[2];
            garden[0] = new Flower("Тюльпан", "Желтый", 6, 20.0f);
            garden[1] = new Tree("Сосна", "Хвойные", 15, 300.0f);

            // Циклда har bir o'simlik o'ziga xos Bloom() ni ishlatadi
            foreach (var plant in garden)
            {
                plant.Bloom(); 
            }
        }
    }
}