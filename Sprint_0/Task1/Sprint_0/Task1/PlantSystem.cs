using System;

namespace Tyuiu.mamatqulov.Sprint_0.Task1
{
    
    public class Plant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public float Height { get; set; }

        public Plant(string name, string type, float height)
        {
            Name = name;
            Type = type;
            Height = height;
        }

        public virtual void Bloom()
        {
            Console.WriteLine($"Растение '{Name}' цветет.");
        }

        public void Grow(float growth)
        {
            Height += growth;
            Console.WriteLine($"Растение '{Name}' выросло на {growth} см. Текущая высота: {Height} см.");
        }
    }

   
    public class Flower : Plant
    {
        public string Color { get; set; }
        public int PetalCount { get; set; }

        public Flower(string name, string color, int petalCount, float height) 
            : base(name, "Цветок", height)
        {
            Color = color;
            PetalCount = petalCount;
        }

        // Полиморфизм: Переопределение метода Bloom
        public override void Bloom()
        {
            Console.WriteLine($"Цветок '{Name}' распускается и радует глаз!");
        }

        public void Wither()
        {
            Console.WriteLine($"Цветок '{Name}' начинает увядать.");
        }
    }
 
    public class Tree : Plant
    {
        public int Age { get; set; }
        public string LeafType { get; set; }

        public Tree(string name, string leafType, int age, float height) 
            : base(name, "Дерево", height)
        {
            LeafType = leafType;
            Age = age;
        }

        // Полиморфизм: Переопределение метода Bloom
        public override void Bloom()
        {
            Console.WriteLine($"Дерево '{Name}' покрывается новыми листьями!");
        }

        public void GrowOlder(int years)
        {
            Age += years;
            Console.WriteLine($"Дерево '{Name}' теперь возрастом {Age} лет.");
        }
    }
}