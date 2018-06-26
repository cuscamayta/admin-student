using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;
using Truextend.AdmStudent.Services.Impl;
using System.Linq;

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
            var isSuccess = _studentService.CreateNewStudent(newStudent);
            var studentsCountAfterInsert = _studentService.GetTotalStudents();

            Assert.IsTrue(studentsCountAfterInsert > studentCountInit);
        }


        [TestMethod]
        public void ShouldBeDeleteSpecificStudent()
        {
            var studentId = new Guid("afca65e0-2298-4c81-9532-9aed46e6572c");
            _studentService.DeleteStudent(studentId);
            var students = _studentService.FindStudentById(studentId);
            Assert.IsTrue(students == null || !students.Any());
        }

        [TestMethod]
        public void ShouldBeSearchAStudentSortedAlphabetically()
        {
            var students = _studentService.FindStudentByName("ramona");
            Assert.AreEqual(2, students.Count());
        }

        [TestMethod]
        public void ShouldBeSearchStudentsByTypeAndOrderedByLastUpdate()
        {
            var students = _studentService.FindStudentByType(TypeStudent.Elementary);
            Assert.AreEqual(3, students.Count());
        }

        [TestMethod]
        public void ShouldBeSearchStudentsByGenderAndTypeAndOrderedByLastUpdate()
        {
            var students = _studentService.FindStudentByName("ramona");
            Assert.AreEqual(1, students.Count());
        }
    }
}
