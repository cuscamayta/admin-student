using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Commons;

namespace Truextend.AdmStudent.DAO.FileSystem.Helpers
{
    public class RepositoryBase
    {
        public FileManager CsvHelper;
        public RepositoryBase(string pathCsvFile)
        {
            this.CsvHelper = new FileManager(pathCsvFile);
        }

        public T HandlerErrorAndExecute<T>(Func<T> funct)
        {
            try
            {
                return funct();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
