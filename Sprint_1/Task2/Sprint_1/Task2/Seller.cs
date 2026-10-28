using System.Collections.Generic;
using Tyuiu.mamatqulov.Sprint_1.Task1;

namespace Tyuiu.mamatqulov.Sprint_1.Task2
{
    public class Seller
    {
        // 2.a.i - private
        private string name;
        // 2.a.ii - private
        private string employeeId;
        // 2.a.iii - protected
        protected decimal salary;
        // 2.a.iv - internal
        internal string contactInfo;

        private List<Product> products = new List<Product>();

        public Seller(string name, string employeeId, decimal salary, string contactInfo)
        {
            this.name = name;
            this.employeeId = employeeId;
            this.salary = salary;
            this.contactInfo = contactInfo;
        }

        // 2.b.i
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // 2.b.ii
        public void SellProduct(Product product, int quantity)
        {
            product.UpdateQuantity(-quantity);
            Console.WriteLine($"Продано {quantity} шт. товара '{product.GetProductInfo()}'");
        }

        // 2.b.iii
        public string GetSellerInfo()
        {
            return $"Продавец: {name}, ID: {employeeId}, Зарплата: {salary}, Контакты: {contactInfo}";
        }
    }
}