using System;
using System.Collections.Generic;
using NLog;



namespace NLogDemo1_1734
{
    public class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Info("這是一條 Info 訊息");
            logger.Error("這是一條 Error 訊息");

            Console.WriteLine("Log 寫入完成");
            Console.ReadLine();
        }
    }
}
