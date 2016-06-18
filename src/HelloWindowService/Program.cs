using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace HelloWindowService
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
#if DEBUG
            TestCode();
            Console.Read();
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new Service1() 
            };
            ServiceBase.Run(ServicesToRun);
#endif

        }

        private static void TestCode()
        {
            string path = @"c:\good.txt";
            if (!File.Exists(path))
                File.Create(path);
            File.AppendAllText(path, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "hello windows service Debug" + "\r\n");
        }
    }
}
