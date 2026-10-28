using Tyuiu.mamatqulov.Sprint_3.Task1;
using Tyuiu.mamatqulov.Sprint_3.Task2;
using Tyuiu.mamatqulov.Sprint_3.Task3;

namespace Tyuiu.mamatqulov
{
    public static class Sprint_3_Launcher
    {
        public static void Run()
        {
            Console.WriteLine("️ === СПРИНТ #3: ПОЛИМОРФИЗМ И GENERIC КЛАССЫ === \n");

            var cpu1 = new CPU("Intel i7", 3000000m, 8);
            var cpu2 = new CPU("AMD Ryzen 7", 3000000m, 8);
            Console.WriteLine($"CPU1 == CPU2 по цене: {cpu1 == cpu2}");
            Console.WriteLine();

            Console.WriteLine("--- Сборка Игрового ПК ---");
            var gamingPC = ComputerFactory.CreateGamingPC();
            gamingPC.ShowSpecs();
            Console.WriteLine($"Общая стоимость: {gamingPC.GetTotalPrice()} сум\n");

            Console.WriteLine("--- Удаление компонента ---");
            gamingPC.RemoveComponent(cpu1);
            Console.WriteLine();

            Console.WriteLine("--- Сборка Офисного ПК ---");
            var officePC = ComputerFactory.CreateOfficePC();
            officePC.ShowSpecs();
            Console.WriteLine($"Общая стоимость: {officePC.GetTotalPrice()} сум");

            Console.WriteLine("\n✅ Спринт #3 успешно завершен!");
        }
    }
}