namespace Patterns.CSharp.Patterns.Interpreter
{
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Result = context.Source[context.Position] == context.Vocabulary;

            PatternUseCase.Output += context.Result ?
                "Symbol " + context.Source[context.Position] + " = Vocabulary " + context.Vocabulary.ToString() + "\r\n\r\n" :                
                "Stop Interpreting. Reason: Invalid " + nameof(context.Source) + ". Symbol " + 
                context.Source[context.Position] + " != Vocabulary " + context.Vocabulary.ToString() + "\r\n\r\n";
        }
    }
}