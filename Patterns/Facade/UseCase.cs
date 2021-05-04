namespace Patterns.CSharp.Patterns.Facade
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Facade facade = new Facade();
            facade.OperationAB();
            facade.OperationCD();
        }
    }
}