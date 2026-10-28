using System;
using Tyuiu.mamatqulov.Sprint_0.Task1;

namespace Tyuiu.mamatqulov.Sprint_0.Task3
{
    public class PolymorphismTest
    {
        public static void Run()
        {
            Console.WriteLine("=== Задание 3: Демонстрация полиморфизма ===");
            
            Plant[] garden = new Plant[2];
            garden[0] = new Flower("Тюльпан", "Желтый", 6, 20.0f);
            garden[1] = new Tree("Сосна", "Хвойные", 15, 300.0f);
            
            foreach (var plant in garden) plant.Bloom();
        }
    }
}