using System.Collections.Generic;
using System.Web.Http;
using CapacitacionJS.Services.Contracts;
using CapacitacionJS.Services.Data;
using CapacitacionJS.Services.Implementations;
using CapacitacionJS.Support.Web.Controllers;
using CapacitacionJS.Support.Web.Models;

namespace CapacitacionJS.Web.Controllers
{
    public class ContentController : BaseApiController<IContentService>
    {
        #region CONSTRUCTORS
        public ContentController()
            : base(ContentService.Instance)
        { }
        #endregion

        #region METHODS
        [HttpPost]
        public ResponseData<ContentData> Add(ContentData content)
        {
            return Execute(() => _service.Add(content));
        }

        [HttpGet]
        public ResponseData<ContentData> Get(int id)
        {
            return Execute(() => _service.Get(id));
        }

        [HttpGet]
        public ResponseData<List<ContentSummaryData>> Get()
        {
            return Execute(() => _service.GetSummary());
        }

        [HttpPut]
        public ResponseData<ContentData> Update(ContentData content)
        {
            return Execute(() => _service.Update(content));
        }

        [HttpDelete]
        public ResponseData<bool> Delete(int id)
        {
            return Execute(() => _service.Delete(id));
        }
        #endregion
    }
}
