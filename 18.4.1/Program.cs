using System.Reflection;

namespace _18._4._1
{
    class Program
    {
        static void Main()
        {
            Worker worker = new Worker();
            CommandShowDescription commandOne = new CommandShowDescription();
            worker.SetCommand(commandOne);
            worker.Run();
            CommandDownloadFile commandTwo = new CommandDownloadFile();    
            worker.SetCommand(commandTwo);
            worker.Run();
        }
    }
}