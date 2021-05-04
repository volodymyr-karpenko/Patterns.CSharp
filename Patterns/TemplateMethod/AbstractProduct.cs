namespace Patterns.CSharp.Patterns.TemplateMethod
{
    public abstract class AbstractProduct
    {
        public abstract void CreatePartOne();
        public abstract void CreatePartTwo();
        
        public void TemplateMethod()
        {
            CreatePartOne();
            CreatePartTwo();
        }
    }
}