using Lab2.FactoryMethod;
using Lab2.AbstractFactory;
using Lab2.Singleton;
using Lab2.Prototype;
using Lab2.Builder;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=== Підписки через Фабрику ===");
            Console.ResetColor();
            FactoryMethodDemo.Run();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n=== Фабрика Брендів ===");
            Console.ResetColor();
            AbstractFactoryDemo.Run();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Єдиний екземпляр (Singleton) ===");
            Console.ResetColor();
            SingletonDemo.Run();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=== Клонування вірусів ===");
            Console.ResetColor();
            PrototypeDemo.Run();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Побудова героя ===");
            Console.ResetColor();
            BuilderDemo.Run();
        }
    }
}
