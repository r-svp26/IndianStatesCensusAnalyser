using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyser
{
    /// <summary>
    /// Exception class
    /// </summary>
    public class CensusAnalyserException : Exception
    {
        public ExceptionType type;
        /// <summary>
        /// declared types of exception
        /// </summary>
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_DELIMITER, INCORRECT_HEADER, NO_SUCH_COUNTRY
        }
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exceptionType"></param>
        public CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.type = exceptionType;
        }
    }
}
