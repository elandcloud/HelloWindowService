using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace HelloWindowService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            TestCode();
        }

        private static void TestCode()
        {
            string path = @"c:\good.txt";
            if (!File.Exists(path))
                File.Create(path);
            File.AppendAllText(path, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "hello windows service Release"+"\r\n");
        }


        protected override void OnStop()
        {
        }
    }
}
