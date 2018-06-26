using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.DAO;
using Truextend.AdmStudent.DAO.FileSystem;

namespace Truextend.AdmStudent.Services.Impl.DependencyResolver
{
    public class DependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IStudentDao>().To<StudentDao>();
        }
    }
}
