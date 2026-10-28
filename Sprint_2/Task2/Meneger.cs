using Tyuiu.mamatqulov.Sprint_2.Task1;

namespace Tyuiu.mamatqulov.Sprint_2.Task2
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, string position, double salary, string department) 
            : base(name, position, salary) 
        { 
            Department = department; 
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Отдел: {Department}");
        }
    }
}