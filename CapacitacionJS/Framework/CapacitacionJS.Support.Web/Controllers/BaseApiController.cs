using System;
using System.Web.Http;
using CapacitacionJS.Support.Exceptions;
using CapacitacionJS.Support.Web.Factories;
using CapacitacionJS.Support.Web.Models;

namespace CapacitacionJS.Support.Web.Controllers
{
    public abstract class BaseApiController<TIService> : ApiController
    {
        #region FIELDS
        protected TIService _service { get; private set; }
        #endregion

        #region CONSTRUCTORS
        protected BaseApiController(TIService service)
        {
            _service = service;
        }
        #endregion

        #region METHODS
        protected ResponseData<T> Execute<T>(Func<T> serviceAction)
        {
            try
            {
                return ResponseFactory<T>.CreateSuccessResponse(serviceAction.Invoke());
            }
            catch (BusinessException ex)
            {
                return ResponseFactory<T>.CreateErrorResponse(ex);
            }
            catch (Exception ex)
            {
                return ResponseFactory<T>.CreateFatalResponse(ex.ToString());
            }
        }
        #endregion
    }
}
