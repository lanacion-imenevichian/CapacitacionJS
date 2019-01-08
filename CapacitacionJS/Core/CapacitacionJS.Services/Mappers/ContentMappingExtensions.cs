using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapacitacionJs.Models.Domain;
using CapacitacionJS.Services.Data;

namespace CapacitacionJS.Services.Mappers
{
    public static class ContentMappingExtensions
    {
        public static ContentData MapToContentData(this Content content)
        {
            var contentData = new ContentData();

            contentData.Id = content.Id;
            contentData.Name = content.Name;
            contentData.Description = content.Description;
            contentData.Data = content.Data;
            contentData.CreatedAt = content.CreatedAt;
            contentData.UpdatedAt = content.UpdatedAt;

            return contentData;
        }

        public static Content MapToContent(this ContentData contentData, int id = 0)
        {
            var content = new Content();

            content.Id = (id != 0) ? id : contentData.Id;
            content.Name = contentData.Name;
            content.Description = contentData.Description;
            content.Data = contentData.Data;

            return content;
        }

        public static ContentSummaryData MapToContentSummaryData(this Content content)
        {
            var contentSummaryData = new ContentSummaryData();

            contentSummaryData.Id = content.Id;
            contentSummaryData.Name = content.Name;
            contentSummaryData.Description = content.Description;

            return contentSummaryData;
        }

        public static List<ContentSummaryData> MapToContentSummaryDataList(this List<Content> contents)
        {
            var contentSummaryDataList = new List<ContentSummaryData>();

            contents.ForEach(c => contentSummaryDataList.Add(c.MapToContentSummaryData()));

            return contentSummaryDataList;
        }
    }
}
