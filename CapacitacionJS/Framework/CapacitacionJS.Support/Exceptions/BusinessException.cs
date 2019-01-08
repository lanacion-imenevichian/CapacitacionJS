using System;

namespace CapacitacionJS.Support.Exceptions
{
    [Serializable]
    public class BusinessException : Exception
    {
        #region CONSTRUCTORS
        public BusinessException()
        { }

        public BusinessException(string message)
            : base(message)
        { }

        public BusinessException(string message, Exception innerException)
            : base(message, innerException)
        { }
        #endregion

        #region PROPERTIES
        public string ErrorCode { get; protected set; }
        #endregion
    }
}
