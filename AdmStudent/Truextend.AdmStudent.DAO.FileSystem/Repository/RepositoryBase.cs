//-----------------------------------------------------------------------
// <copyright file="RepositoryBase.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.DAO.FileSystem.Helpers
{
	using System;
    using Truextend.AdmStudent.Commons;
	
    /// <summary>
    /// Contains the basics and initials function for the common repositories
    /// </summary>
    public class RepositoryBase
    {
        public FileManager CsvHelper;
        /// <summary>
        /// Initialize the class with specific parameter.
        /// </summary>
        /// <param name="pathCsvFile">The current file path.</param>
        public RepositoryBase(string pathCsvFile)
        {
            this.CsvHelper = new FileManager(pathCsvFile);
        }

        /// <summary>
        /// Execute the handler error and a specified function passed as parameter
        /// </summary>
        /// <typeparam name="T">The type of parameter.</typeparam>
        /// <param name="funct">The current function passed as parameter.</param>
        /// <returns>A custom object type of T</returns>
        public T HandlerErrorAndExecute<T>(Func<T> funct)
        {
            try
            {
                return funct();
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
                throw;
            }
        }

    }
}
