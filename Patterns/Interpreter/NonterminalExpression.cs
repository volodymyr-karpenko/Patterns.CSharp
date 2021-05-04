﻿namespace Patterns.CSharp.Patterns.Interpreter
{
    public class NonterminalExpression : AbstractExpression
    {
        AbstractExpression terminalExpression;
        AbstractExpression nonterminalExpression;

        public override void Interpret(Context context)
        {
            if (context.Position < context.Source.Length)
            {
                terminalExpression = new TerminalExpression();
                terminalExpression.Interpret(context);
                context.Position++;                

                if (context.Result)
                {
                    nonterminalExpression = new NonterminalExpression();
                    nonterminalExpression.Interpret(context);
                }
            }
        }
    }
}