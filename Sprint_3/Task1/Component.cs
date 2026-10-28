namespace Tyuiu.mamatqulov.Sprint_3.Task1
{
    public interface IInstallable { void Install(); }

    public abstract class Component : IInstallable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Component(string name, decimal price) { Name = name; Price = price; }

        public virtual string GetInfo() => $"{Name} - {Price} сум";
        public override string ToString() => GetInfo();
        public abstract void Install();

        public static bool operator ==(Component a, Component b) => a?.Price == b?.Price;
        public static bool operator !=(Component a, Component b) => !(a == b);
    }

    public class CPU : Component
    {
        public int Cores { get; set; }
        public CPU(string name, decimal price, int cores) : base(name, price) { Cores = cores; }
        public override string GetInfo() => $"CPU: {Name}, Ядра: {Cores}, Цена: {Price}";
        public override void Install() => Console.WriteLine($"Установлен процессор {Name}");
    }

    public class RAM : Component
    {
        public int SizeGB { get; set; }
        public RAM(string name, decimal price, int sizeGB) : base(name, price) { SizeGB = sizeGB; }
        public override string GetInfo() => $"RAM: {Name}, Объем: {SizeGB}GB, Цена: {Price}";
        public override void Install() => Console.WriteLine($"Установлена память {Name}");
    }

    public class GPU : Component
    {
        public int VramGB { get; set; }
        public GPU(string name, decimal price, int vramGB) : base(name, price) { VramGB = vramGB; }
        public override string GetInfo() => $"GPU: {Name}, VRAM: {VramGB}GB, Цена: {Price}";
        public override void Install() => Console.WriteLine($"Установлена видеокарта {Name}");
    }

    public class HDD : Component
    {
        public int CapacityTB { get; set; }
        public HDD(string name, decimal price, int capacityTB) : base(name, price) { CapacityTB = capacityTB; }
        public override string GetInfo() => $"HDD: {Name}, Объем: {CapacityTB}TB, Цена: {Price}";
        public override void Install() => Console.WriteLine($"Установлен диск {Name}");
    }
}