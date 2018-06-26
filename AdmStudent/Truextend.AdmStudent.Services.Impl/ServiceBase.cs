//-----------------------------------------------------------------------
// <copyright file="ServiceBase.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Services.Impl
{
    using System;
    using Truextend.AdmStudent.Commons;
    public class ServiceBase
    {
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
