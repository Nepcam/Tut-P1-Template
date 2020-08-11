using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_P1
{
    class Student
    {
        // A class has two things;
        // All of the fields (data)

        // All of the methods

        private int _id;
        private string _firstname;
        private string _surname;
        private bool _hasPaid;

        /// <summary>
        /// This constructor method will initialise the fields to default values
        /// </summary>
        public Student()
        {
            _id = 0;
            _surname = "";
            _firstname = "";
            _hasPaid = false;
        }

        /// <summary>
        /// Initialises the object to the values passed in
        /// </summary>
        /// <param name="id">The id number of the student</param>
        /// <param name="surname">The surname of the student</param>
        /// <param name="firstname">The firstname of the student</param>
        public Student(int id, string surname, string firstname)
        {
            _id = id;
            _surname = surname;
            _firstname = firstname;
            _hasPaid = false;
        }

        /// <summary>
        /// Gets and sets the surname of the student
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        /// <summary>
        /// Gets and sets the firstname of the student
        /// </summary>
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        /// <summary>
        /// Gets the id of the student
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Gets whether the student has paid their fees
        /// </summary>
        public bool Haspaid
        {
            get { return _hasPaid; }
        }

        /// <summary>
        /// Sets the has paid to true to show the student has paid their fees.
        /// </summary>
        public void Pay()
        {
            _hasPaid = true;
        }

        /// <summary>
        /// Returns back all information about a student
        /// </summary>
        /// <returns>All of the student information padded out</returns>
        public override string ToString()
        {
            //return _id.ToString().PadRight(6) + _firstname.PadRight(10) + _surname.PadRight(10) + _hasPaid;
            return Id.ToString().PadRight(6) + Firstname.PadRight(10) + Surname.PadRight(10) + Haspaid;
        }
    }
}
