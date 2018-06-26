using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;
using Truextend.AdmStudent.Services.Impl;

namespace Truextend.AdmStudent.Services.Tests
{
    [TestClass]
    public class StudentServicesTest
    {

        private IStudentService _studentService;
        [TestInitialize]
        public void Initialize()
        {
            _studentService = new StudentService();
        }

        [TestMethod]
        public void ShouldBeStoreStudentAfterInsert()
        {
            var studentCountInit = _studentService.GetTotalStudents();
            var newStudent = new Student() { Type = TypeStudent.Elementary, Name = "Pepe", Gender = Gender.Female, LastUpdate = "123548" };
            var isSuccess = _studentService.InsertNewStudent(newStudent);
            var studentsCountAfterInsert = _studentService.GetTotalStudents();

            Assert.IsTrue(studentsCountAfterInsert > studentCountInit);
        }

        [TestMethod]
        public void ShouldBeInsertNewStudentAndReturnId()
        {

        }


        [TestMethod]
        public void ShouldBeDeleteSpecificStudent()
        {

        }

        [TestMethod]
        public void ShouldBeSearchAStudentSortedAlphabetically()
        {

        }

        [TestMethod]
        public void ShouldBeSearchStudentsByType()
        {

        }

        [TestMethod]
        public void ShouldBeSearchStudentsByGenderAndType()
        {

        }
    }
}
