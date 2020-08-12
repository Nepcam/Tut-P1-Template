using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_P1
{
    class Calculator
    {
        private int _value;

        /// <summary>
        /// Initialises the object to it's initial value
        /// </summary>
        /// <param name="intialValue">The initial value of the calculator</param>
        public Calculator(int intialValue)
        {
            _value = intialValue;
        }

        /// <summary>
        /// Gets the value of the calculator
        /// </summary>
        public int Value
        {
            get { return _value;  }
        }

        /// <summary>
        /// Gets the value of the calculator as a hexadecimal string
        /// </summary>
        public string Hex
        {
            get { return Convert.ToString(_value, 16); }
        }

        /// <summary>
        /// Gets the value of the calculator as a binary string
        /// </summary>
        public string Binary
        {
            get { return Convert.ToString(_value, 2); }
        }

        /// <summary>
        /// Sets the value of the calculator to zero
        /// </summary>
        public void Clear()
        {
            _value = 0;
        }

        /// <summary>
        /// Return back the current value of the calculator
        /// </summary>
        /// <returns>The current value of the calculator</returns>
        public override string ToString()
        {
            return _value.ToString();
        }

        /// <summary>
        /// Adds the given value to the value of the calculator
        /// </summary>
        /// <param name="addValue"></param>
        public void Add(int addValue)
        {
            _value += addValue;
        }

        /// <summary>
        /// Multiplys the value of the calculator by the given value
        /// </summary>
        /// <param name="multiplyValue"></param>
        public void Multiply(int multiplyValue)
        {
            _value *= multiplyValue;
        }
    }
}
