using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.DAO.FileSystem.DependencyResolver
{
    public class DependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IStudentDao>().To<StudentDao>();
        }
    }
}
