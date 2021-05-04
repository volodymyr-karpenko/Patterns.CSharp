namespace Patterns.CSharp.Patterns.Interpreter
{
    public class Context
    {
        public char Vocabulary { get; set; }
        public string Source { get; set; }
        public bool Result { get; set; }
        public int Position { get; set; }
    }
}