using System;
using CommandExecutor;

namespace TestConsole
{
    class Program
    {
        //This is a simple example that how CommandExicutor works.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome to this example.Enter Input:");
            Executor ex = new Executor();
            //First we need to add Commands
            ex.AddCommand("Sayhello", SayHello);
            ex.AddCommand("SayBye", SayGoodBye);
            //For Exicuting we just call Exicute and in () we write name of the command 
            ex.Execute(Console.ReadLine());
	        //If you enter "say hello", result would be Hello.
        }
        //Simple function to test
        public static void SayHello()
        {
            Console.WriteLine("Hello.");
        }
        public static void SayGoodBye ()
        {
            Console.WriteLine("GoodBye.");
        }
    }
}
