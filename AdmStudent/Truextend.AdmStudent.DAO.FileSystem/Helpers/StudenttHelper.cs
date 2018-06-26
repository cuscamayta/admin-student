using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;
using Truextend.AdmStudent.Commons.Helpers;

namespace Truextend.AdmStudent.DAO.FileSystem.Helpers
{
    public static class StudentHelper
    {
        public static string ToCsvString(this Student student)
        {
            return string.Format("{0},{1},{2},{3},{4}", student.Id, student.Type.ToString(), student.Name, student.Gender.ToString(), student.LastUpdate);
        }

        public static Student BuildStudent(this string stringStudent)
        {
            return BuildStudentFromString(stringStudent);
        }

        private static Student BuildStudentFromString(string stringStudent)
        {
            var fields = stringStudent.Split(',');
            return new Student(fields[2], fields[1].ToEnum<TypeStudent>(), fields[3].ToEnum<Gender>(), fields[4]) { Id = new Guid(fields[0]) };
        }

        public static IEnumerable<Student> ToList(this IEnumerable<string> csvString)
        {
            var students = csvString.Select(studentStr => BuildStudentFromString(studentStr));
            return students;
        }
    }
}
