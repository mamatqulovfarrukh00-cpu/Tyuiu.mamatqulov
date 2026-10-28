using System.Collections.Generic;
using Tyuiu.mamatqulov.Sprint_3.Task1;

namespace Tyuiu.mamatqulov.Sprint_3.Task2
{
    public class Computer
    {
        private List<Component> components = new List<Component>();

        public void AddComponent<T>(T component) where T : Component, IInstallable
        {
            components.Add(component);
            component.Install();
        }

        public void RemoveComponent<T>(T component) where T : Component
        {
            if (components.Remove(component)) Console.WriteLine($"Компонент {component.Name} удален");
            else Console.WriteLine($"Компонент {component.Name} не найден");
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var c in components) total += c.Price;
            return total;
        }

        public void ShowSpecs()
        {
            Console.WriteLine("Спецификации компьютера:");
            foreach (var c in components) Console.WriteLine(c.GetInfo());
        }
    }
}