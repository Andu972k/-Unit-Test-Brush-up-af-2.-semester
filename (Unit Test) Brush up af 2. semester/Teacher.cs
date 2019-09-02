using System;
using System.Collections.Generic;
using System.Text;

namespace _Unit_Test__Brush_up_af_2._semester
{
    class Teacher : Person
    {


        #region InstanceFields

        //private string _name;
        //private string _address;
        private double _salary;
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
        public double Salary
        {
            get { return _salary; }
            set
            {
                CheckSalary(value);
                _salary = value;
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

        public Teacher(string name, string address, double salary, Gender gender) : base(name, address, gender)
        {
            //CheckName(name);
            //CheckAddress(address);
            CheckSalary(salary);
            //_name = name;
            //_address = address;
            _salary = salary;
            //_gender = gender;

        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}, {nameof(Salary)}: {Salary}, {nameof(Gender)}: {Gender}";
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

        private void CheckSalary(double salary)
        {
            if (salary < 0)
            {

                throw new ArgumentOutOfRangeException("salary", salary, "Salary must be bigger than 0");

            }

        }

        #endregion



    }
}
