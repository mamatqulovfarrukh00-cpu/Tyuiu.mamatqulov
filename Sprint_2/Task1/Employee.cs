namespace Tyuiu.mamatqulov.Sprint_2.Task1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string position, double salary)
        {
            Name = name; Position = position; Salary = salary;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Сотрудник: {Name}, Должность: {Position}, Зарплата: {Salary} сум");
        }
    }
}