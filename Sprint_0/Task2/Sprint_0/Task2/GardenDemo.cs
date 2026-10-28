using System;
using Tyuiu.mamatqulov.Sprint_0.Task1;

namespace Tyuiu.mamatqulov.Sprint_0.Task2
{
    public class GardenDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Задание 2: Тестирование объектов ===");

            // Создаем объекты Цветка и Дерева
            Flower rose = new Flower("Роза", "Красный", 5, 30.0f);
            Tree oak = new Tree("Дуб", "Лиственные", 10, 200.0f);

            // Вызываем методы для Цветка
            rose.Bloom();
            rose.Grow(5.0f);
            rose.Wither();

            Console.WriteLine();

            // Вызываем методы для Дерева
            oak.Bloom();
            oak.Grow(10.0f);
            oak.GrowOlder(5);
        }
    }
}