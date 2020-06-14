//-----------------------------------------------------------------------
// <copyright file="DependencyResolver.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API
{
    using Ninject;
    using System.Collections.Specialized;
    using Truextend.AdmStudent.Services;
    using Truextend.AdmStudent.Services.Impl;

    public class DependencyResolver
    {
        public static IKernel RegisterAndCreateKernel(NameValueCollection settings)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IStudentService>().To<StudentService>();

            return kernel;
        }
    }
}
