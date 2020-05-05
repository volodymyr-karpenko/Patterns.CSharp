namespace Patterns.CSharp.Patterns.Builder
{
    public class Director
    {
        private AbstractBuilder builder;

        public Director(AbstractBuilder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartOne();
            builder.BuildPartTwo();
            builder.BuildPartThree();
        }
    }
}