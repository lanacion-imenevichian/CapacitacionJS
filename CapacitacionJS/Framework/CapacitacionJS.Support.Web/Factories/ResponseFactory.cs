using CapacitacionJS.Support.Exceptions;
using CapacitacionJS.Support.Web.Enums;
using CapacitacionJS.Support.Web.Models;

namespace CapacitacionJS.Support.Web.Factories
{
    public static class ResponseFactory<T>
    {
        public static ResponseData<T> CreateSuccessResponse(T data)
        {
            return new ResponseData<T>
            {
                Status = ResponseStates.Success.ToString(),
                Data = data
            };
        }

        public static ResponseData<T> CreateErrorResponse(BusinessException ex)
        {
            return new ResponseData<T>
            {
                Status = ResponseStates.Error.ToString(),
                MessageCode = ex.ErrorCode,
                Message = ex.Message
            };
        }

        public static ResponseData<T> CreateFatalResponse(string errorMessage)
        {
            return new ResponseData<T>
            {
                Status = ResponseStates.Fatal.ToString(),
                Message = errorMessage
            };
        }
    }
}
