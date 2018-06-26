using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Commons;

namespace Truextend.AdmStudent.API.Server
{
    class Program
    {
        private const string LOGO = @"
            ___       __         _____ __            __           __     ___    ____  ____
           /   | ____/ /___ ___ / ___// /___  ______/ /__  ____  / /_   /   |  / __ \/  _/
          / /| |/ __  / __ `__ \\__ \/ __/ / / / __  / _ \/ __ \/ __/  / /| | / /_/ // /  
         / ___ / /_/ / / / / / /__/ / /_/ /_/ / /_/ /  __/ / / / /_   / ___ |/ ____// /   
        /_/  |_\__,_/_/ /_/ /_/____/\__/\__,_/\__,_/\___/_/ /_/\__/  /_/  |_/_/   /___/   
                                                                                  
        ";

        static void Main(string[] args)
        {
            try
            {
                Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                Console.WriteLine("Starting WebUI API Service");

                var url = ConfigurationManager.AppSettings["apiUrl"];

                try
                {
                    bool isConsole = "true".Equals(ConfigurationManager.AppSettings["consoleMode"]);
                    Logger.Info(string.Format("Starting as a {0}", isConsole ? "Console App" : "Windows Service"));
                    if (isConsole)
                    {
                        StartAsConsoleApp(ConfigurationManager.AppSettings);
                    }
                    else
                    {
                        StartAsWindowsService(ConfigurationManager.AppSettings);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Fatal("Error while running WebUI API Service!", ex);
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error is " + ex);
                Logger.Fatal("Could not start service!", ex);
                Console.WriteLine(string.Format("App could not start {0}", ex));
                throw ex;
            }
        }


        private static void StartAsConsoleApp(NameValueCollection settings)
        {
            Console.WriteLine(LOGO);
            AdmStudentAPI.ExecuteAPI(settings["apiUrl"]);
        }

        private static void StartAsWindowsService(NameValueCollection settings)
        {
            //TODO implement init as service
        }
    }
}
