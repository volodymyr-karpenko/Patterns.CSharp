namespace ConsoleApp.Patterns.State
{
    public class Context
    {
        public AbstractState State { get; set; }

        public Context(AbstractState state)
        {
            State = state;
        }

        public void Request()
        {
            State.Handle(this);
        }
    }
}