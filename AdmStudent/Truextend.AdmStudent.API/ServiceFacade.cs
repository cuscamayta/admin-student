//-----------------------------------------------------------------------
// <copyright file="ServiceFacade.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.API
{
    using Ninject;
    using System;
    using System.Configuration;
    using System.IO;
    using Truextend.AdmStudent.DAO.FileSystem;
    using Truextend.AdmStudent.Services;
    using Truextend.AdmStudent.Services.Impl;

    public class ServiceFacade
    {
        private IKernel Kernel;
        private string _pathDataAccess = string.Empty;

        public ServiceFacade()
        {
            Kernel = DependencyResolver.RegisterAndCreateKernel(ConfigurationManager.AppSettings);
            _pathDataAccess = string.Concat(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\")), ConfigurationManager.AppSettings["pathDataAccess"]);
        }

        /// <summary>
        /// The object to lock the initialization when the singleton is first accessed
        /// </summary>
        private static object lockObj = new object();

        /// <summary>
        /// The <see cref="ServicesFacade"/> instance.
        /// </summary>
        private static volatile ServiceFacade instance;
        public static ServiceFacade Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new ServiceFacade();
                        }
                    }
                }

                return instance;
            }
        }

        private readonly IStudentService _studentService;

        public IStudentService StudentService
        {
            get { return _studentService == null ? new StudentService(new StudentDao(_pathDataAccess)) : _studentService; }
        }


    }
}
