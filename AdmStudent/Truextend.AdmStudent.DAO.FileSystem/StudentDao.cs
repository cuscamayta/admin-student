using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truextend.AdmStudent.DAO.FileSystem.Helpers;
using Truextend.AdmStudent.Domain;
using System.IO;
using Truextend.AdmStudent.Commons.Helpers;
using Truextend.AdmStudent.Commons;
using Truextend.AdmStudent.Domain.Enums;

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

        public bool Delete(Student entity)
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

        public bool Delete(Guid id)
        {
            return this.HandlerErrorAndExecute<bool>(() =>
            {
                var studentDeleted = CsvHelper.FindAndRemoveLine(id.ToString()).BuildStudent();
                return true;
            });
        }

        public IEnumerable<Student> FindStudentsByName(string name)
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList().Where(x => x.Name.ToUpper().Equals(name.ToUpper())).ToList();
                return students;
            });
        }

        public IEnumerable<Student> FindStudentsByType(TypeStudent type)
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList().Where(x => x.Type == type);
                return students;
            });
        }

        public IEnumerable<Student> FindStudentsByGenderAndType(TypeStudent type, Gender gender)
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList().Where(x => x.Type == type && x.Gender == gender);
                return students;
            });
        }


        public int GetTotalStudents()
        {
            throw new NotImplementedException();
        }
    }
}
