using Tyuiu.mamatqulov.Sprint_2.Task1;
using Tyuiu.mamatqulov.Sprint_2.Task2;
using Tyuiu.mamatqulov.Sprint_2.Task3;

namespace Tyuiu.mamatqulov
{
    public static class Sprint_2_Launcher
    {
        public static void Run()
        {
            Console.WriteLine("🏢 === СПРИНТ #2: НАСЛЕДОВАНИЕ И ИНТЕРФЕЙСЫ === \n");

            var emp = new Employee("Иван Иванов", "Разработчик", 4000000);
            emp.PrintInfo(); Console.WriteLine();

            var mgr = new Manager("Мария Петрова", "Старший разработчик", 6000000, "Backend");
            mgr.PrintInfo(); Console.WriteLine();

            var pm = new ProjectManager("Алексей Сидоров", "Lead Developer", 9000000, "IT", "GardenApp");
            pm.PrintInfo();
            Console.WriteLine(pm.GenerateReport());
            Console.WriteLine("Команда проекта:");
            foreach (var m in pm.GetTeamMembers()) Console.WriteLine($"- {m}");

            Console.WriteLine("\n✅ Спринт #2 успешно завершен!");
        }
    }
}