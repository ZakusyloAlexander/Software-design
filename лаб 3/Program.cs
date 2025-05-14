
using Adapter;
using Decorator;
using Bridge;
using Proxy;
using Composite;
using Flyweight;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Міст ===");
        Shape triangle = new Triangle(new RasterRenderer());
        triangle.Draw();

        Console.WriteLine("\n=== Адаптер ===");
        var logger = new Logger();
        logger.Warn("Попередження у варіанті 2");

        Console.WriteLine("\n=== Декоратор ===");
        IHero paladin = new Paladin();
        paladin = new Sword(paladin);
        Console.WriteLine(paladin.GetDescription());

        Console.WriteLine("\n=== Проксі ===");
        var proxy = new SmartTextChecker();
        proxy.ReadFile("sample.txt");

        Console.WriteLine("\n=== Компонувальник ===");
        var block = new LightElementNode("section", "block", false);
        block.AddChild(new LightTextNode("Контент секції"));
        Console.WriteLine(block.OuterHTML());

        Console.WriteLine("\n=== Легковаговик ===");
        var builder = new HtmlBuilder();
        builder.BuildFromText(new[] { "Тема", "  Деталі", "Зміст тексту..." });
        builder.Display();
    }
}
