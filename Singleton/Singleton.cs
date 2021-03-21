﻿

namespace Creational.Singleton
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {

        }

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get { return instance; }
        }
    }
}
