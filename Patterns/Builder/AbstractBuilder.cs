namespace Patterns.CSharp.Patterns.Builder
{
    public abstract class AbstractBuilder
    {
        public abstract void BuildPartOne();
        public abstract void BuildPartTwo();
        public abstract void BuildPartThree();
        public abstract Product GetResult();
    }
}