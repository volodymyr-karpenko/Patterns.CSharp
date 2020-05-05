namespace Patterns.CSharp.Patterns.Iterator
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Enumerable items = new Enumerable();

            for (int i = 0; i < 10; i++)
            {
                items[i] = i.ToString();
            }
            
            foreach (var item in items)
            {
                PatternUseCase.Output += item + "\r\n\r\n";
            }
        }
    }
}