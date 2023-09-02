using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Logger  // sealed to prevent inheritance  This ensures that no other class can extend or inherit from it.
    {
        //The instance field is declared as a Lazy<Logger> instance. This Lazy<T>
        //type ensures that the singleton instance is created only when it's first accessed.
        private static readonly Lazy<Logger> instance = new Lazy<Logger>(() => new Logger());

        private Logger()
        {
            // Private constructor to prevent external instantiation. can't create a Logger instance using the new keyword from outside the class.
        }

        public static Logger Instance => instance.Value; //Instance property provides the global point of access to the single instance 

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] - {message}");
        }

    }
}
