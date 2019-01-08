using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapacitacionJs.Models.Domain;
using CapacitacionJS.Services.Contracts;
using CapacitacionJS.Services.Data;
using CapacitacionJS.Services.Mappers;
using CapacitacionJS.Support.Exceptions;

namespace CapacitacionJS.Services.Implementations
{
    public class ContentService : IContentService
    {
        #region FIELDS
        private static ContentService _instance;
        private Dictionary<int, Content> _dictionary;
        #endregion

        #region CONSTRUCTORS
        private ContentService()
        {
            _dictionary = new Dictionary<int, Content>();

            InitDictionary();
        }
        #endregion

        #region PROPERTIES
        public static ContentService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContentService();
                }

                return _instance;
            }
        }
        #endregion

        #region METHODS
        public ContentData Add(ContentData contentData)
        {
            int id = (_dictionary.Keys.Count > 0) ? _dictionary.Keys.Max() + 1 : 1;
            var content = contentData.MapToContent(id);

            content.Id = id;
            content.CreatedAt = DateTime.Now;
            content.UpdatedAt = content.CreatedAt;

            _dictionary.Add(id, content);

            return Get(id);
        }

        public ContentData Get(int id)
        {
            if (!_dictionary.ContainsKey(id))
            {
                throw new BusinessException("El Id no existe.");
            }

            return _dictionary.First(d => d.Key == id).Value.MapToContentData();
        }

        public List<ContentSummaryData> GetSummary()
        {
            var contents = _dictionary.Values.ToList();

            return contents.MapToContentSummaryDataList();
        }

        public ContentData Update(ContentData contentData)
        {
            if (!_dictionary.ContainsKey(contentData.Id))
            {
                throw new BusinessException("El Id no existe.");
            }

            int id = contentData.Id;
            var domainContent = _dictionary.First(d => d.Key == id).Value;

            domainContent.Name = contentData.Name;
            domainContent.Description = contentData.Description;
            domainContent.Data = contentData.Data;
            domainContent.UpdatedAt = DateTime.Now;

            _dictionary[id] = domainContent;

            return Get(id);
        }

        public bool Delete(int id)
        {
            if (!_dictionary.ContainsKey(id))
            {
                throw new BusinessException("El Id no existe.");
            }

            return _dictionary.Remove(id);
        }

        private void InitDictionary()
        {
            var contentData = new ContentData();

            for (int i = 1; i <= 5; i++)
            {
                contentData.Name = "Sujeto Experimental #" + i;
                contentData.Description = "Descripción de SE" + i;
                contentData.Data = "Estado: Completamente desquiciado";

                Add(contentData);
            }
        }
        #endregion
    }
}
