namespace Patterns.CSharp.Patterns.Singleton
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;
            Output += instance1.GetHashCode() == instance2.GetHashCode() ?
                "Same unique instance: Hash Code " + instance1.GetHashCode().ToString() + " = Hash Code " + instance2.GetHashCode().ToString() : false.ToString();
        }
    }
}