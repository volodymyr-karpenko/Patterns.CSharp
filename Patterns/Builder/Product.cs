using System.Collections;

namespace Patterns.CSharp.Patterns.Builder
{
    public class Product
    {
        private ArrayList parts = new ArrayList();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach (var item in parts)
            {
                PatternUseCase.Output += GetType().Name + " Part " + (parts.IndexOf(item) + 1).ToString() + ": " + item + "\r\n\r\n";
            }
        }
    }
}