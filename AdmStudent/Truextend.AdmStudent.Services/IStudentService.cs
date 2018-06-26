using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;

namespace Truextend.AdmStudent.Services
{
    public interface IStudentService
    {
        bool CreateNewStudent(Student student);
        bool DeleteStudent(Guid id);
        IEnumerable<Student> FindStudentById(Guid id);
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> FindStudentByName(string name);
        IEnumerable<Student> FindStudentByType(TypeStudent type);
        IEnumerable<Student> FindStudentByTypeAndGender(TypeStudent type, Gender gender);
        int GetTotalStudents();
    }
}
