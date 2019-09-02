using System;
using System.Collections.Generic;
using System.Text;

namespace _Unit_Test__Brush_up_af_2._semester
{
    public class Student : Person
    {

        #region InstanceFields

        //private string _name;
        //private string _address;
        private int _semester;
        //private Gender _gender;


        #endregion

        #region Properties

        ///// <summary>
        ///// Retrieves the name or changes it
        ///// </summary>
        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        CheckName(value);
        //        _name = value;
        //    }
        //}

        ///// <summary>
        ///// Retrieves the address or changes it
        ///// </summary>
        //public string Address
        //{
        //    get { return _address; }
        //    set
        //    {
        //        CheckAddress(value);
        //        _address = value;
        //    }
        //}

        /// <summary>
        /// Retrieves the semester or changes it
        /// </summary>
        public int Semester
        {
            get { return _semester; }
            set
            {
                CheckSemester(value);
                _semester = value;
            }
        }


        ///// <summary>
        ///// Retrieves the gender or changes it
        ///// </summary>
        //public Gender Gender
        //{
        //    get { return _gender; }
        //    set { _gender = value; }
        //}


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a student object with the specified values
        /// </summary>
        /// <param name="name">The name of the student</param>
        /// <param name="address">The address of the student</param>
        /// <param name="semester">The student's current semester</param>
        /// <param name="gender">The student's gender</param>
        public Student(string name, string address, int semester, Gender gender) : base(name, address, gender)
        {
            CheckSemester(semester);
            _semester = semester;

        }
        //public Student(string name, string address, int semester, Gender gender)
        //{
        //    CheckName(name);
        //    CheckAddress(address);
        //    CheckSemester(semester);
        //    _name = name;
        //    _address = address;
        //    _semester = semester;
        //    _gender = gender;

        //}


        #endregion

        #region Methods

        /// <summary>
        /// A methods that represents a student object as a string
        /// </summary>
        /// <returns>a string with the students information</returns>
        public override string ToString()
        {
            return $"{nameof(_name)}: {_name}, {nameof(_address)}: {_address}, {nameof(_semester)}: {_semester}, {nameof(_gender)}: {_gender}";
        }

        #endregion

        #region HelpMethods

        //private void CheckName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
        //    {
        //        throw new ArgumentException("name must be at least 2 characters long");
        //    }
        //}

        //private void CheckAddress(string address)
        //{
        //    if (string.IsNullOrWhiteSpace(address))
        //    {
        //        throw new ArgumentException("Address is null or empty");
        //    }

        //}

        private void CheckSemester(int semester)
        {
            if (semester > 8 || semester < 1)
            {
                
                throw new ArgumentOutOfRangeException("semester", semester, "Semester must be bigger than 1, but less than 8");

            }

        }

        #endregion

    }
}
