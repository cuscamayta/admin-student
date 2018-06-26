using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.DAO.FileSystem.Helpers;
using Truextend.AdmStudent.Domain;
using System.IO;
using Truextend.AdmStudent.Commons.Helpers;

namespace Truextend.AdmStudent.DAO.FileSystem
{
    public class StudentDao : RepositoryBase, IStudentDao
    {
        public StudentDao(string pathCsvFile)
            : base(pathCsvFile)
        {
        }


        public int Insert(Student entity)
        {
            return HandlerErrorAndExecute<int>(() =>
            {
                CsvHelper.InsertNewLine(entity.ToCsvString());
                return 1;
            });
        }

        public int Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Student entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList();
                return students;
            });
        }

        public IEnumerable<Student> FindById(Guid id)
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList().Where(x => x.Id == id);
                return students;
            });
        }



       

        public int Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
