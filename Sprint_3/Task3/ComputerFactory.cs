using Tyuiu.mamatqulov.Sprint_3.Task1;
using Tyuiu.mamatqulov.Sprint_3.Task2;

namespace Tyuiu.mamatqulov.Sprint_3.Task3
{
    public static class ComputerFactory
    {
        public static Computer CreateGamingPC()
        {
            var pc = new Computer();
            pc.AddComponent(new CPU("Intel Core i9", 5000000m, 16));
            pc.AddComponent(new RAM("Kingston Fury", 2000000m, 32));
            pc.AddComponent(new GPU("RTX 4090", 15000000m, 24));
            pc.AddComponent(new HDD("Samsung SSD", 3000000m, 2));
            return pc;
        }

        public static Computer CreateOfficePC()
        {
            var pc = new Computer();
            pc.AddComponent(new CPU("Intel Core i3", 1500000m, 4));
            pc.AddComponent(new RAM("Corsair", 800000m, 8));
            pc.AddComponent(new HDD("WD Blue", 1000000m, 1));
            return pc;
        }
    }
}