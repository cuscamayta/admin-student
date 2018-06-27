//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API.Server
{
	using System;
    using System.Collections.Specialized;
	using System.Configuration;
    using Truextend.AdmStudent.Commons;

    class Program
    {
        private const string LOGO = @"
         __ _             _            _       _      ___ _____ 
        / _\ |_ _   _  __| | ___ _ __ | |_    /_\    / _ \\_   \
        \ \| __| | | |/ _` |/ _ \ '_ \| __|  //_\\  / /_)/ / /\/
        _\ \ |_| |_| | (_| |  __/ | | | |_  /  _  \/ ___/\/ /_  
        \__/\__|\__,_|\__,_|\___|_| |_|\__| \_/ \_/\/   \____/  
                                                        
        ";

        static void Main(string[] args)
        {
            try
            {
                Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                Console.WriteLine("Starting API Service");

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
