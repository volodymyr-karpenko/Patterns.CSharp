﻿namespace Patterns.CSharp.Patterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly object syncRoot = new object();

        private Singleton()
        {
        }

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