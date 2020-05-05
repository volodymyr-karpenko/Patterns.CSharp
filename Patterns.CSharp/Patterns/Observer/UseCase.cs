namespace Patterns.CSharp.Patterns.Observer
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            ConcreteSubjectOne subjectOne = new ConcreteSubjectOne();
            subjectOne.Attach(new ConcreteObserverOne(subjectOne));
            subjectOne.Attach(new ConcreteObserverTwo(subjectOne));
            subjectOne.State = "SOME STATE...";
            subjectOne.Notify();

            ConcreteSubjectTwo subjectTwo = new ConcreteSubjectTwo();
            subjectTwo.Attach(new ConcreteObserverOne(subjectTwo));
            subjectTwo.Attach(new ConcreteObserverTwo(subjectTwo));
            subjectTwo.State = "SOME OTHER STATE...";
            subjectTwo.Notify();
        }
    }
}