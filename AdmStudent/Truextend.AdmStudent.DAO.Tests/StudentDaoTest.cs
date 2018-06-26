using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Truextend.AdmStudent.Domain;
using Truextend.AdmStudent.Domain.Enums;
using Truextend.AdmStudent.DAO.FileSystem;
using Truextend.AdmStudent.Commons.Helpers;
using System.IO;
using System.Linq;

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
            var studentId = new Guid("afca65e0-2298-4c81-9532-9aed46e6572c");
            _studentDao.Delete(studentId);
            var students = _studentDao.FindById(studentId);
            Assert.IsTrue(students == null || !students.Any());
        }

        [TestMethod]
        public void ShouldBeSearchStudentByName()
        {
            var students = _studentDao.FindStudentsByName("ramona");
            Assert.IsTrue(students.Count() >= 1);
        }

        [TestMethod]
        public void ShouldBeSearchStudentByType()
        {
            var students = _studentDao.FindStudentsByType(TypeStudent.Elementary);
            Assert.IsTrue(students.Count() >= 3);
        }

        [TestMethod]
        public void ShouldBeSearchStudentByTypeAndGender()
        {
            var students = _studentDao.FindStudentsByGenderAndType(TypeStudent.Elementary, Gender.Female);
            Assert.IsTrue(students.Count() >= 2);
        }



    }
}
