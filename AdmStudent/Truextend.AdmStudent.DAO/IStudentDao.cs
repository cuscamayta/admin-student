//-----------------------------------------------------------------------
// <copyright file="IStudentDao.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Truextend.AdmStudent.DAO
{
    using System.Collections.Generic;
    using Truextend.AdmStudent.Domain;
    using Truextend.AdmStudent.Domain.Enums;

    /// <summary>
    /// Interface that contains the custom features for student DAO
    /// </summary>
    public interface IStudentDao : IRepository<Student>
    {
        /// <summary>
        /// Find all the students according the specific nem
        /// </summary>
        /// <param name="name">The specific name for search</param>
        /// <returns>A list of student object based on the name criteria</returns>
        IEnumerable<Student> FindStudentsByName(string name);

        /// <summary>
        /// Find all the students base in the type.
        /// </summary>
        /// <param name="type">The current type for search</param>
        /// <returns>A list of student object based in the type specified</returns>
        IEnumerable<Student> FindStudentsByType(TypeStudent type);

        /// <summary>
        /// Find all the students based in the type and gender.
        /// </summary>
        /// <param name="type">The current type specified.</param>
        /// <param name="gender">The current gender specified.</param>
        /// <returns>A list of students based in the type and gender</returns>
        IEnumerable<Student> FindStudentsByGenderAndType(TypeStudent type, Gender gender);

        /// <summary>
        /// Calculate the total of records
        /// </summary>
        /// <returns>A int that represent the total students into the repositorie</returns>
        int GetTotalStudents();

    }
}
