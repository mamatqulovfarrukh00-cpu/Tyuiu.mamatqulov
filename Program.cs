namespace Tyuiu.mamatqulov
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("   ВЫБОР СПРИНТА ДЛЯ ПРОВЕРКИ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Запустить Спринт #0 (Растения / OOP Basics)");
                Console.WriteLine("2. Запустить Спринт #1 (Инкапсуляция / Модификаторы)");
                Console.WriteLine("3. Запустить Спринт #2 (Наследование / Интерфейсы)");
                Console.WriteLine("4. Запустить Спринт #3 (Полиморфизм / Generic)");
                Console.WriteLine("0. Выход");
                Console.WriteLine("----------------------------------------");
                Console.Write("Выберите номер спринта: ");
                
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1": Sprint_0_Launcher.Run(); break;
                    case "2": Sprint_1_Launcher.Run(); break;
                    case "3": Sprint_2_Launcher.Run(); break;
                    case "4": Sprint_3_Launcher.Run(); break;
                    case "0": return;
                    default: Console.WriteLine(" Неверный выбор."); break;
                }
                
                Console.WriteLine("\nНажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }
}