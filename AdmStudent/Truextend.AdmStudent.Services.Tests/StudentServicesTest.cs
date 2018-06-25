using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;

namespace Truextend.AdmStudent.Services.Tests
{
    [TestClass]
    public class StudentServicesTest
    {

        private readonly IStudentService _studentService;
        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void ShouldBeStoreStudentAfterInsert()
        {
            var studentCountInit = _studentService.GetTotalStudents();
            var newStudent =  new Student() { Type = TypeStudent.Elementary, Name = "Pepe", Gender = Gender.Female, LastUpdate = new TimeSpan() };
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
