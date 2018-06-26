//-----------------------------------------------------------------------
// <copyright file="DependencyResolver.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.DAO.FileSystem.DependencyResolver
{
	using Ninject.Modules;

    /// <summary>
    /// Implement the dependency resolver using ninject
    /// </summary>
    public class DependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IStudentDao>().To<StudentDao>();
        }
    }
}
