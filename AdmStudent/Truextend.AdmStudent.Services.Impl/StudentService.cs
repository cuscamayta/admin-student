using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Commons;
using Truextend.AdmStudent.DAO;
using Truextend.AdmStudent.DAO.FileSystem;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;

namespace Truextend.AdmStudent.Services.Impl
{
    public class StudentService : ServiceBase, IStudentService
    {
        private IStudentDao _studentDao;

        public StudentService(IStudentDao studentDao)
        {
            this._studentDao = studentDao;
        }

        public StudentService()
        {
            this._studentDao = new StudentDao(string.Empty);
        }
        public bool InsertNewStudent(Student student)
        {
            return this.HandlerErrorAndExecute<bool>(() =>
            {
                var studentId = _studentDao.Insert(student);
                return studentId > 0;
            });
        }

        public int GetTotalStudents()
        {
            return this.HandlerErrorAndExecute<int>(() =>
            {
                return _studentDao.GetTotalStudents();
            });
        }

        public bool CreateNewStudent(Student student)
        {
            return this.HandlerErrorAndExecute<bool>(() =>
            {
                _studentDao.Insert(student);
                return true;
            });
        }

        public bool DeleteStudent(Guid id)
        {
            return this.HandlerErrorAndExecute<bool>(() =>
            {
                _studentDao.Delete(id);
                return true;
            });
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.GetAll();
            });
        }

        public IEnumerable<Student> FindStudentByName(string name)
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.FindStudentsByName(name).OrderBy(x => x.Name);
            });
        }

        public IEnumerable<Student> FindStudentByType(TypeStudent type)
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.FindStudentsByType(type).OrderBy(x => x.LastUpdate);
            });
        }

        public IEnumerable<Student> FindStudentByTypeAndGender(Domain.Enums.TypeStudent type, Domain.Enums.Gender gender)
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.FindStudentsByGenderAndType(type, gender).OrderBy(x => x.LastUpdate);
            });
        }


        public IEnumerable<Student> FindStudentById(Guid id)
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.FindById(id);
            });
        }
    }
}
