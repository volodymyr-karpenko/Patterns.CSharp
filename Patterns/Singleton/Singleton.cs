namespace Patterns.CSharp.Patterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly object syncRoot = new object();

        private Singleton()
        {
        }

        // Use either "volatile" keyword or "lock" construction. Both of those are used here for demonstartion only
        // Visit https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/volatile to learrn more

        private static volatile Singleton _uniqueInstance;
        public static Singleton Instance
        {
            get 
            {
                if (_uniqueInstance == null)
                {
                    lock (syncRoot)
                    {
                        if (_uniqueInstance == null)
                        {
                            _uniqueInstance = new Singleton();
                        }
                    }
                }

                return _uniqueInstance;
            }
        }
    }
}