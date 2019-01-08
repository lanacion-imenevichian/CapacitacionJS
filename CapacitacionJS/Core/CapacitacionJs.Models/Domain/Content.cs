using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapacitacionJs.Models.Domain
{
    public class Content
    {
        #region PROPERTIES
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public string Data { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        #endregion
    }
}
