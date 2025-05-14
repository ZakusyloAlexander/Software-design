
using ChainOfResponsibility;
using Mediator;
using Observer;
using Strategy;
using Memento;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== Спостерігач ===");
        var header = new LightElementNode("header");
        header.AddEventListener("click", new ClickListener());
        header.TriggerEvent("click");

        Console.WriteLine("\n=== Стратегія ===");
        var image = new Image(new LocalImageLoader());
        image.Display("D:/Photos/photo.jpg");

        Console.WriteLine("\n=== Ланцюжок відповідальностей ===");
        var nodeA = new VoiceMenu("1");
        var nodeB = new VoiceMenu("3");
        nodeA.SetNext(nodeB);
        nodeA.HandleRequest("3: Переключення");

        Console.WriteLine("\n=== Посередник ===");
        var center = new CommandCentre();
        center.AddRunway(new Runway("Runway-X"));
        var aircraft = new Aircraft("Boeing-900", center);
        aircraft.RequestLanding();

        Console.WriteLine("\n=== Мементо ===");
        var editor = new TextEditor();
        editor.Type("Оригінальний текст. ");
        editor.Type("Змінено.");
        editor.Print();
        editor.Undo();
        editor.Print();
    }
}
