using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Domain;

namespace Truextend.AdmStudent.DAO.FileSystem
{
    public class StudentDao : IStudentDao
    {
        public int Insert(Student entity)
        {
            return 1;
        }

        public int Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Student entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return new List<Student>() { new Student() };
        }

        public IEnumerable<Student> FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
