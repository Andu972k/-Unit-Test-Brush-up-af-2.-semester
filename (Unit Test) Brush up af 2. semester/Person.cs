using System;
using System.Collections.Generic;
using System.Text;

namespace _Unit_Test__Brush_up_af_2._semester
{
    public class Person
    {

        #region InstanceFields

        protected string _name;
        protected string _address;
        protected Gender _gender;


        #endregion

        #region Properties

        /// <summary>
        /// Retrieves the name or changes it
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                CheckName(value);
                _name = value;
            }
        }

        /// <summary>
        /// Retrieves the address or changes it
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                CheckAddress(value);
                _address = value;
            }
        }


        /// <summary>
        /// Retrieves the gender or changes it
        /// </summary>
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a person object with the specified values
        /// </summary>
        /// <param name="name">The name of the person</param>
        /// <param name="address">The address of the person</param>
        /// <param name="gender">The person's gender</param>
        public Person(string name, string address, Gender gender)
        {
            CheckName(name);
            CheckAddress(address);
            _name = name;
            _address = address;
            _gender = gender;

        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}, {nameof(Gender)}: {Gender}";
        }

        #endregion

        #region HelpMethods

        private void CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2)
            {
                throw new ArgumentException("name must be at least 2 characters long");
            }
        }

        private void CheckAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Address is null or empty");
            }

        }

        #endregion

    }
}
