namespace Patterns.CSharp.Patterns.Interpreter
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Context context = new Context();            
            AbstractExpression expression = new NonterminalExpression();

            context.Vocabulary = 'a';
            context.Source = "aba";
            expression.Interpret(context);            
        }
    }
}