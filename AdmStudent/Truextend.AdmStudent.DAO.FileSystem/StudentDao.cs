//-----------------------------------------------------------------------
// <copyright file="StudentDao.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Truextend.AdmStudent.DAO.FileSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Truextend.AdmStudent.DAO.FileSystem.Helpers;
    using Truextend.AdmStudent.Domain;
    using Truextend.AdmStudent.Domain.Enums;

    /// <summary>
    /// The implementation of student Dao
    /// </summary>
    public class StudentDao : RepositoryBase, IStudentDao
    {
        /// <summary>
        /// Initialize a new instance of <see cref="StudentDao"/>  class.
        /// </summary>
        /// <param name="pathCsvFile"></param>
        public StudentDao(string pathCsvFile = "")
            : base(pathCsvFile)
        {
        }

        /// <inheritdoc />
        public int Insert(Student entity)
        {
            return HandlerErrorAndExecute<int>(() =>
            {
                CsvHelper.InsertNewLine(entity.ToCsvString());
                return 1;
            });
        }

        /// <inheritdoc />
        public bool Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public int Update(Student entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<Student> GetAll()
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList();
                return students;
            });
        }

        /// <inheritdoc />
        public IEnumerable<Student> FindById(Guid id)
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList().Where(x => x.Id == id);
                return students;
            });
        }

        /// <inheritdoc />
        public bool Delete(Guid id)
        {
            return this.HandlerErrorAndExecute<bool>(() =>
            {
                var studentDeleted = CsvHelper.FindAndRemoveLine(id.ToString()).BuildStudent();
                return true;
            });
        }

        /// <inheritdoc />
        public IEnumerable<Student> FindStudentsByName(string name)
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList().Where(x => x.Name.ToUpper().Equals(name.ToUpper())).ToList();
                return students;
            });
        }

        /// <inheritdoc />
        public IEnumerable<Student> FindStudentsByType(TypeStudent type)
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList().Where(x => x.Type == type);
                return students;
            });
        }

        /// <inheritdoc />
        public IEnumerable<Student> FindStudentsByGenderAndType(TypeStudent type, Gender gender)
        {
            return HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                var students = CsvHelper.ReadAllLines().ToList().Where(x => x.Type == type && x.Gender == gender);
                return students;
            });
        }

        /// <inheritdoc />
        public int GetTotalStudents()
        {
            return HandlerErrorAndExecute<int>(() =>
            {
                var totalStudents = CsvHelper.GetTotalLines();
                return totalStudents;
            });
        }
    }
}
