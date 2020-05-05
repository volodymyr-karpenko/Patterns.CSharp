namespace Patterns.CSharp.Patterns.Memento
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Originator originator = new Originator();
            originator.State = "ON";
            CareTaker careTaker = new CareTaker();
            careTaker.Memento = originator.CreateMemento();
            originator.State = "OFF";
            originator.SetMemento(careTaker.Memento);
            PatternUseCase.Output += "Current state: " + originator.State;
        }
    }
}