using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.Domain;

namespace Truextend.AdmStudent.Services
{
    public interface IStudentService
    {
        bool InsertNewStudent(Student student);

        int GetTotalStudents();

    }
}
