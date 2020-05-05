namespace Patterns.CSharp.Patterns.Builder
{
    public class ConcreteBuilderOne : AbstractBuilder
    {
        private Product product = new Product();

        public override void BuildPartOne()
        {
            product.Add(GetType().Name + " => " + nameof(BuildPartOne));
        }

        public override void BuildPartTwo()
        {
            product.Add(GetType().Name + " => " + nameof(BuildPartTwo));
        }

        public override void BuildPartThree()
        {
            product.Add(GetType().Name + " => " + nameof(BuildPartThree));
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}