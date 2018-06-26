using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;
using Truextend.AdmStudent.DAO.FileSystem;
using Truextend.AdmStudent.Commons.Helpers;
using System.IO;

namespace Truextend.AdmStudent.DAO.Tests
{
    [TestClass]
    public class StudentDaoTest
    {
        private IStudentDao _studentDao;

        [TestInitialize]
        public void Initialize()
        {
            var currentPathCsvFile = string.Concat(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")), @"\FakeData\students.csv");
            _studentDao = new StudentDao(currentPathCsvFile);
        }

        [TestMethod]
        public void ShouldBeCreateANewStudentAndReturnTheCurrentId()
        {
            var newStudent = new Student("Pepe", TypeStudent.Elementary, Gender.Female, DateTime.Now.ToTimestamp());
            var studentId = _studentDao.Insert(newStudent);

            Assert.IsNotNull(studentId);
            Assert.IsTrue(studentId > 0);
        }

        [TestMethod]
        public void ShouldBeReturnTheListOfStudents()
        {
            var students = _studentDao.GetAll();
            Assert.AreNotEqual(null, students);
        }

        [TestMethod]
        public void ShouldBeDeleteAStudent()
        {

        }

        [TestMethod]
        public void ShouldBeSearchStudent()
        {

        }

        [TestMethod]
        public void ShouldBeOrderStudentAlphabetically()
        {

        }



    }
}
