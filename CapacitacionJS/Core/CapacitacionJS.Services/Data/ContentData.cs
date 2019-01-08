using System;
using System.Runtime.Serialization;

namespace CapacitacionJS.Services.Data
{
    [DataContract]
    public class ContentData
    {
        #region PROPERTIES
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "data")]
        public string Data { get; set; }

        [DataMember(Name = "createdAt")]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "updatedAt")]
        public DateTime UpdatedAt { get; set; }
        #endregion
    }
}
