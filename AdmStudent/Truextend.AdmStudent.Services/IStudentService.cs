//-----------------------------------------------------------------------
// <copyright file="IStudentService.cs" company="Truextend">
//     Copyright (c) Truextend. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace Truextend.AdmStudent.Services
{
    using System;
    using System.Collections.Generic;
    using Truextend.AdmStudent.Domain;
    using Truextend.AdmStudent.Domain.Enums;

    /// <summary>
    /// The interface for the student service.
    /// </summary>
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
