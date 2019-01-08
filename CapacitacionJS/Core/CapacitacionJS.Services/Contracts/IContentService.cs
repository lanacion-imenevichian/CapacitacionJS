using System.Collections.Generic;
using CapacitacionJS.Services.Data;

namespace CapacitacionJS.Services.Contracts
{
    public interface IContentService
    {
        ContentData Add(ContentData content);
        ContentData Get(int id);
        List<ContentSummaryData> GetSummary();
        ContentData Update(ContentData content);
        bool Delete(int id);
    }
}
