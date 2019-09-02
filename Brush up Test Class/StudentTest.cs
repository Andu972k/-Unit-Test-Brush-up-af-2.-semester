using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _Unit_Test__Brush_up_af_2._semester;

namespace Brush_up_Test_Class
{
    [TestClass]
    public class StudentTest
    {

        #region InstanceFields

        private Person _student;


        #endregion

        [TestInitialize]
        public void TestInit()
        {
            _student = new Student("anders", "someplace", 2, Gender.Male);
        }

        #region TestMethods

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestName_OneCharacter()
        {
            _student.Name = "a";

        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestName_Constructor()
        {

            Student _newStudent = new Student(null, "Somewhere", 2, Gender.Male);

        }

        [TestMethod]
        public void TestName()
        {
            
            Assert.AreEqual("anders", _student.Name);
            _student.Name = "an";
            Assert.AreEqual("an", _student.Name);



        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestAddress_AddressIsNull()
        {
            _student.Address = null;
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TestAddress_constructor()
        {
            Student newStudent = new Student("Elizabeth", null, 4, Gender.Female);
        }

        [TestMethod]
        public void TestAddress()
        {
            Assert.AreEqual("someplace", _student.Address);
            _student.Address = "The best address";
            Assert.AreEqual("The best address", _student.Address);
        }



        

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSemester_LessThanOne()
        {
            //_student.Semester = 0;
            ((Student) _student).Semester = 0;

        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestSemester_MoreThanEight()
        {
            //_student.Semester = 9;
            ((Student)_student).Semester = 9;
        }

        [TestMethod]
        public void TestSemester_WithinInterval()
        {
            

            //Assert.AreEqual(2, _student.Semester);
            //_student.Semester = 4;
            //Assert.AreEqual(4, _student.Semester);
            //_student.Semester = 8;
            //Assert.AreEqual(8, _student.Semester);

            Assert.AreEqual(2, ((Student)_student).Semester);
            ((Student)_student).Semester = 4;
            Assert.AreEqual(4, ((Student)_student).Semester);
            ((Student)_student).Semester = 8;
            Assert.AreEqual(8, ((Student)_student).Semester);
        }


        [TestMethod]
        public void TestGender()
        {
            Assert.AreEqual(Gender.Male, _student.Gender);
            _student.Gender = Gender.Female;
            Assert.AreEqual(Gender.Female, _student.Gender);
        }



        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual("_name: anders, _address: someplace, _semester: 2, _gender: Male", _student.ToString());
        }
        




        #endregion



    }
}
