using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.API
{
    public class AdmStudentAPI
    {
        private string _url;
        private StudentSetupModule StudentModule;
        public AdmStudentAPI(string url)
        {
            this._url = url;
            this.StudentModule = new StudentSetupModule();
        }

        public static void ExecuteAPI(string url, bool isConsole = true)
        {
            if (isConsole)
            {
                using (var host = new NancyHost(new Uri(url), new APIBootstrapper()))
                {
                    host.Start();
                    Console.Write(string.Format("Running on {0}\n", url));
                    Console.Write("Press enter to exit\n");
                    Console.ReadLine();
                    Console.Write("Closing app!");
                }
            }
            else
            {
                //TODO code necesary for install as service
            }
        }


    }
}
