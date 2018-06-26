//-----------------------------------------------------------------------
// <copyright file="StudentHelper.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.DAO.FileSystem.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Truextend.AdmStudent.Commons.Helpers;
    using Truextend.AdmStudent.Domain;
    using Truextend.AdmStudent.Domain.Enums;

    /// <summary>
    /// Contains extension methods for student object
    /// </summary>
    public static class StudentHelper
    {
        /// <summary>
        /// Convert a object type of student ini string.
        /// </summary>
        /// <param name="student">The current object type of student</param>
        /// <returns>A string that represent the student object</returns>
        public static string ToCsvString(this Student student)
        {
            return string.Format("{0},{1},{2},{3},{4}", student.Id, student.Type.ToString(), student.Name, student.Gender.ToString(), student.LastUpdate);
        }

        /// <summary>
        /// Build a structure type of student based in a specified string
        /// </summary>
        /// <param name="stringStudent">The specified student string</param>
        /// <returns>a object type of Student</returns>
        public static Student BuildStudent(this string stringStudent)
        {
            return BuildStudentFromString(stringStudent);
        }

        /// <summary>
        /// Build a structure type of student based in a specified string
        /// </summary>
        /// <param name="stringStudent">The specified student string</param>
        /// <returns>a object type of <see cref="Student"/> class.</returns>
        private static Student BuildStudentFromString(string stringStudent)
        {
            var fields = stringStudent.Split(',');
            return new Student(fields[2], fields[1].ToEnum<TypeStudent>(), fields[3].ToEnum<Gender>(), fields[4]) { Id = new Guid(fields[0]) };
        }

        /// <summary>
        /// Create a list type of Student
        /// </summary>
        /// <param name="csvString"></param>
        /// <returns>a list of object type of <see cref="Student"/> class.</returns>
        public static IEnumerable<Student> ToList(this IEnumerable<string> csvString)
        {
            var students = csvString.Select(studentStr => BuildStudentFromString(studentStr));
            return students;
        }
    }
}
