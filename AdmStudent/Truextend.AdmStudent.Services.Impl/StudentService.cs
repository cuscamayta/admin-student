using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Commons;
using Truextend.AdmStudent.DAO;
using Truextend.AdmStudent.DAO.FileSystem;
using Truextend.AdmStudent.Domain;

namespace Truextend.AdmStudent.Services.Impl
{
    public class StudentService : IStudentService
    {
        private IStudentDao _studentDao;
        private ILogger _logger;
        public StudentService(IStudentDao studentDao)
        {
            this._studentDao = studentDao;
        }

        public StudentService()
        {
            this._studentDao = new StudentDao();
        }
        public bool InsertNewStudent(Student student)
        {
            try
            {
                var studentId = _studentDao.Insert(student);
                return studentId > 0;
            }
            catch (Exception exception)
            {
                _logger.Error(exception);
                throw;
            }
        }

        private static int counter = 1;
        public int GetTotalStudents()
        {
            try
            {
                var totalStudents = _studentDao.GetAll().Count();
                return totalStudents + counter++;
            }
            catch (Exception exception)
            {
                _logger.Error(exception);
                throw;
            }
        }
    }
}
