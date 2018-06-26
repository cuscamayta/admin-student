using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Commons;

namespace Truextend.AdmStudent.Services.Impl
{
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
