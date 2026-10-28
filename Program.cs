using Tyuiu.mamatqulov.Sprint_0.Task2;
using Tyuiu.mamatqulov.Sprint_0.Task3;

namespace Tyuiu.mamatqulov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🌿 Спринт #0: Управление садом 🌿\n");

           
            GardenDemo.Run();
            
            Console.WriteLine("\n--------------------------\n");

            
            PolymorphismTest.Run();

            Console.WriteLine("\n✅ Спринт успешно завершен!");
            Console.ReadKey();
        }
    }
}
