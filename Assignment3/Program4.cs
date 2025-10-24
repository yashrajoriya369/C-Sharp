//4.Implement a static logger class called Logger that has a method LogMessage for writing messages on
//console. Demonstrate its usage in a simple console application.


using System;
namespace Assignment3
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("This is a log message.");
            Logger.LogMessage("Logging another message.");
        }
    }
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }
}
