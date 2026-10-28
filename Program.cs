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
                Console.WriteLine("   ВЫБОР СПРИНТА ДЛЯ ПРОВЕРКИ (Tyuiu.mamatqulov)");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Запустить Спринт #0 (Растения / OOP Basics)");
                Console.WriteLine("2. Запустить Спринт #1 (Инкапсуляция / Модификаторы)");
                Console.WriteLine("0. Выход");
                Console.WriteLine("----------------------------------------");
                Console.Write("Выберите номер спринта: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Sprint_0_Launcher.Run();
                        break;
                    case "2":
                        Sprint_1_Launcher.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("❌ Неверный выбор. Попробуйте снова.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }
        }
    }
}