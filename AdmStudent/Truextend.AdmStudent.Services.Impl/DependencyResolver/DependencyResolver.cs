﻿//-----------------------------------------------------------------------
// <copyright file="DependencyResolver.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Services.Impl.DependencyResolver
{
    using Ninject.Modules;
    using Truextend.AdmStudent.DAO;
    using Truextend.AdmStudent.DAO.FileSystem;
    public class DependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IStudentDao>().To<StudentDao>();
        }
    }
}
