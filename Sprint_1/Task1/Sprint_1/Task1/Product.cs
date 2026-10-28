namespace Tyuiu.mamatqulov.Sprint_1.Task1
{
    public class Product
    {
        // 1.a.i - private
        private string name;
        // 1.a.ii - private
        private decimal price;
        // 1.a.iii - private
        private int quantity;
        // 1.a.iv - protected
        protected string category;
        // 1.a.v - internal
        internal string description;

        public Product(string name, decimal price, int quantity, string category, string description)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.description = description;
        }

        // 1.b.i
        public decimal GetTotalPrice()
        {
            return price * quantity;
        }

        // 1.b.ii
        public void UpdateQuantity(int amount)
        {
            quantity += amount;
        }

        // 1.b.iii
        public string GetProductInfo()
        {
            return $"Товар: {name}, Категория: {category}, Цена: {price}, Кол-во: {quantity}, Описание: {description}";
        }
    }
}