using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;
using Truextend.AdmStudent.DAO.FileSystem;

namespace Truextend.AdmStudent.DAO.Tests
{
    [TestClass]
    public class StudentDaoTest
    {

        private  IStudentDao _studentDao;
        [TestInitialize]
        public void Initialize()
        {
            _studentDao = new StudentDao();
        }

        [TestMethod]
        public void ShouldBeCreateANewStudentAndReturnTheCurrentId()
        {
            var newStudent = new Student() { Type = TypeStudent.Elementary, Name = "Pepe", Gender = Gender.Female, LastUpdate = new TimeSpan() };
            var studentId = _studentDao.Insert(newStudent);

            Assert.IsNotNull(studentId);
            Assert.IsTrue(studentId > 0);
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
