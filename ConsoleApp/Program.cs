// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter pattern name (e.g. Chain Of Responsibility)");

Console.WriteLine();

string patternName = Console.ReadLine();

string output = string.Empty;

var patternOutput = new Dictionary<string, string>
{
    { PatternName.AbstractFactory, new ConsoleApp.Patterns.AbstractFactory.UseCase().GetOutput() },
    { PatternName.Adapter, new ConsoleApp.Patterns.Adapter.UseCase().GetOutput() },
    { PatternName.Bridge, new ConsoleApp.Patterns.Bridge.UseCase().GetOutput() },
    { PatternName.Builder, new ConsoleApp.Patterns.Builder.UseCase().GetOutput() },
    { PatternName.ChainOfResponsibility, new ConsoleApp.Patterns.ChainOfResponsibility.UseCase().GetOutput() },
    { PatternName.Command, new ConsoleApp.Patterns.Command.UseCase().GetOutput() },
    { PatternName.Composite, new ConsoleApp.Patterns.Composite.UseCase().GetOutput() },
    { PatternName.Decorator, new ConsoleApp.Patterns.Decorator.UseCase().GetOutput() },
    { PatternName.Facade, new ConsoleApp.Patterns.Facade.UseCase().GetOutput() },
    { PatternName.FactoryMethod, new ConsoleApp.Patterns.FactoryMethod.UseCase().GetOutput() },
    { PatternName.Flyweight, new ConsoleApp.Patterns.Flyweight.UseCase().GetOutput() },
    { PatternName.Interpreter, new ConsoleApp.Patterns.Interpreter.UseCase().GetOutput() },
    { PatternName.Iterator, new ConsoleApp.Patterns.Iterator.UseCase().GetOutput() },
    { PatternName.Mediator, new ConsoleApp.Patterns.Mediator.UseCase().GetOutput() },
    { PatternName.Memento, new ConsoleApp.Patterns.Memento.UseCase().GetOutput() },
    { PatternName.Observer, new ConsoleApp.Patterns.Observer.UseCase().GetOutput() },
    { PatternName.Prototype, new ConsoleApp.Patterns.Prototype.UseCase().GetOutput() },
    { PatternName.Proxy, new ConsoleApp.Patterns.Proxy.UseCase().GetOutput() },
    { PatternName.Singleton, new ConsoleApp.Patterns.Singleton.UseCase().GetOutput() },
    { PatternName.State, new ConsoleApp.Patterns.State.UseCase().GetOutput() },
    { PatternName.Strategy, new ConsoleApp.Patterns.Strategy.UseCase().GetOutput() },
    { PatternName.TemplateMethod, new ConsoleApp.Patterns.TemplateMethod.UseCase().GetOutput() },
    { PatternName.Visitor, new ConsoleApp.Patterns.Visitor.UseCase().GetOutput() }
};

patternOutput.TryGetValue(patternName, out output);

Console.WriteLine(string.IsNullOrWhiteSpace(output) ? "\r\n\r\nValid pattern name not provided\r\n\r\n" : "\r\n\r\n" + patternName + " output:\r\n\r\n" + output);

static class PatternName
{
    public static readonly string AbstractFactory = "Abstract Factory";
    public static readonly string Adapter = "Adapter";
    public static readonly string Bridge = "Bridge";
    public static readonly string Builder = "Builder";
    public static readonly string ChainOfResponsibility = "Chain Of Responsibility";
    public static readonly string Command = "Command";
    public static readonly string Composite = "Composite";
    public static readonly string Decorator = "Decorator";
    public static readonly string Facade = "Facade";
    public static readonly string FactoryMethod = "Factory Method";
    public static readonly string Flyweight = "Flyweight";
    public static readonly string Interpreter = "Interpreter";
    public static readonly string Iterator = "Iterator";
    public static readonly string Mediator = "Mediator";
    public static readonly string Memento = "Memento";
    public static readonly string Observer = "Observer";
    public static readonly string Prototype = "Prototype";
    public static readonly string Proxy = "Proxy";
    public static readonly string Singleton = "Singleton";
    public static readonly string State = "State";
    public static readonly string Strategy = "Strategy";
    public static readonly string TemplateMethod = "TemplateMethod";
    public static readonly string Visitor = "Visitor";
}
