using System.Collections.Generic;
using Tyuiu.mamatqulov.Sprint_1.Task2;

namespace Tyuiu.mamatqulov.Sprint_1.Task3
{
    public class Store
    {
        // 3.a.i - private
        private string storeName;
        // 3.a.ii - private
        private string location;
        // 3.a.iii - public
        public string storeHours;

        private List<Seller> sellers = new List<Seller>();

        public Store(string storeName, string location, string storeHours)
        {
            this.storeName = storeName;
            this.location = location;
            this.storeHours = storeHours;
        }

        // 3.b.i
        public void AddSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        // 3.b.ii
        public void ListProducts()
        {
            Console.WriteLine($"Магазин '{storeName}' в {location}:");
            foreach (var seller in sellers)
            {
                Console.WriteLine(seller.GetSellerInfo());
            }
        }

        // 3.b.iii
        public string GetStoreInfo()
        {
            return $"Магазин: {storeName}, Адрес: {location}, Часы работы: {storeHours}";
        }
    }
}