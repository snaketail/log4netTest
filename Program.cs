using System;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4NetTest
{
    internal class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();   //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            log.Debug("Now Let's Debug");

            log.Info("this is info message");

            log.Warn("This is warning message");

            log.Error("This is my error message");

            Exception e = new DivideByZeroException();

            log.Error("Exception Catched", e);

            Console.ReadLine();
        }
    }
}
