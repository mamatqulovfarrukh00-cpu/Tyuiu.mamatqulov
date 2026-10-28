using Tyuiu.mamatqulov.Sprint_1.Task1;
using Tyuiu.mamatqulov.Sprint_1.Task2;
using Tyuiu.mamatqulov.Sprint_1.Task3;

namespace Tyuiu.mamatqulov
{
    public static class Sprint_1_Launcher
    {
        public static void Run()
        {
            Console.WriteLine("🏪 === СПРИНТ #1: ИНКАПСУЛЯЦИЯ И МОДИФИКАТОРЫ === 🏪\n");

            Product laptop = new Product("Ноутбук", 5000000, 10, "Электроника", "Мощный игровой ноутбук");
            Console.WriteLine(laptop.GetProductInfo());
            Console.WriteLine($"Общая стоимость: {laptop.GetTotalPrice()} сум\n");

            Seller ali = new Seller("Али Маматкулов", "EMP-001", 3000000, "+992901234567");
            ali.AddProduct(laptop);
            ali.SellProduct(laptop, 2);
            Console.WriteLine(ali.GetSellerInfo() + "\n");

            Store techStore = new Store("TechWorld", "Худжанд", "09:00 - 20:00");
            techStore.AddSeller(ali);
            techStore.ListProducts();
            Console.WriteLine("\n" + techStore.GetStoreInfo());

            Console.WriteLine("\n✅ Спринт #1 успешно завершен!");
        }
    }
}