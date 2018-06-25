using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truextend.AdmStudent.Commons
{
    public interface ILogger
    {

        void Error(Exception exception);

        void Error(Exception exception, string message);


    }
}
