using System.Runtime.Serialization;

namespace CapacitacionJS.Support.Web.Models
{
    [DataContract]
    public class ResponseData<T>
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "messageCode")]
        public string MessageCode { get; set; }

        [DataMember(Name = "data")]
        public T Data { get; set; }
    }
}
