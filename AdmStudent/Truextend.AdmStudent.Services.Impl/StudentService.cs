//-----------------------------------------------------------------------
// <copyright file="StudentService.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Services.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Truextend.AdmStudent.DAO;
    using Truextend.AdmStudent.Domain;
    using Truextend.AdmStudent.Domain.Enums;

    /// <summary>
    /// The implementation for services Student.
    /// </summary>
    public class StudentService : ServiceBase, IStudentService
    {
        private IStudentDao _studentDao;


        public StudentService(IStudentDao studentDao)
        {
            this._studentDao = studentDao;
        }

        /// <summary>
        /// Find all the students according the specific nem
        /// </summary>
        /// <param name="name">The specific name for search</param>
        /// <returns>A list of student object based on the name criteria</returns>
        public bool InsertNewStudent(Student student)
        {
            return this.HandlerErrorAndExecute<bool>(() =>
            {
                var studentId = _studentDao.Insert(student);
                return studentId > 0;
            });
        }

        /// <summary>
        /// Find all the students according the specific nem
        /// </summary>
        /// <param name="name">The specific name for search</param>
        /// <returns>A list of student object based on the name criteria</returns>
        public int GetTotalStudents()
        {
            return this.HandlerErrorAndExecute<int>(() =>
            {
                return _studentDao.GetTotalStudents();
            });
        }

        /// <summary>
        /// Create a new student
        /// </summary>
        /// <param name="student">the current student for insert</param>
        /// <returns>a boolean thah indicate if the operation was success. </returns>
        public bool CreateNewStudent(Student student)
        {
            return this.HandlerErrorAndExecute<bool>(() =>
            {
                _studentDao.Insert(student);
                return true;
            });
        }

        /// <summary>
        /// Delete a specific student
        /// </summary>
        /// <param name="id">the id for the student to delete.</param>
        /// <returns>a boolean that indicate if the operation was success.</returns>
        public bool DeleteStudent(Guid id)
        {
            return this.HandlerErrorAndExecute<bool>(() =>
            {
                _studentDao.Delete(id);
                return true;
            });
        }

        /// <summary>
        /// Get all the student in the repository
        /// </summary>        
        /// <returns>A list of student object </returns>
        public IEnumerable<Student> GetAllStudents()
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.GetAll().OrderBy(x => x.Name);
            });
        }

        /// <summary>
        /// Find all the students according the specific nem
        /// </summary>
        /// <param name="name">The specific name for search</param>
        /// <returns>A list of student object based on the name criteria</returns>
        public IEnumerable<Student> FindStudentByName(string name)
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.FindStudentsByName(name).OrderBy(x => x.Name);
            });
        }

        /// <summary>
        /// Find all the students according the specific nem
        /// </summary>
        /// <param name="name">The specific name for search</param>
        /// <returns>A list of student object based on the name criteria</returns>
        public IEnumerable<Student> FindStudentByType(TypeStudent type)
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.FindStudentsByType(type).OrderBy(x => x.LastUpdate);
            });
        }

        /// <summary>
        /// Find all the students according the specific nem
        /// </summary>
        /// <param name="name">The specific name for search</param>
        /// <returns>A list of student object based on the name criteria</returns>
        public IEnumerable<Student> FindStudentByTypeAndGender(Domain.Enums.TypeStudent type, Domain.Enums.Gender gender)
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.FindStudentsByGenderAndType(type, gender).OrderBy(x => x.LastUpdate);
            });
        }

        /// <summary>
        /// Find all the students according the specific nem
        /// </summary>
        /// <param name="name">The specific name for search</param>
        /// <returns>A list of student object based on the name criteria</returns>
        public IEnumerable<Student> FindStudentById(Guid id)
        {
            return this.HandlerErrorAndExecute<IEnumerable<Student>>(() =>
            {
                return _studentDao.FindById(id);
            });
        }
    }
}
