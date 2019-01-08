using System.Runtime.Serialization;

namespace CapacitacionJS.Services.Data
{
    [DataContract]
    public class ContentSummaryData
    {
        #region PROPERTIES
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
        #endregion
    }
}
