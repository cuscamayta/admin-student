using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Services;
using Truextend.AdmStudent.Services.Impl;

namespace Truextend.AdmStudent.API
{
    public class DependencyResolver
    {
        public static IKernel RegisterAndCreateKernel(NameValueCollection settings)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IStudentService>().To<StudentService>();
            //var warrior = kernel.Get<Samurai>();
            //warrior.Attack("the evildoers");
            //Console.ReadLine();

            return kernel;
        }
    }
}
