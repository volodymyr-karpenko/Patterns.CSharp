namespace Patterns.CSharp.Patterns.Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}