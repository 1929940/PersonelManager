using API.Core.Models;
using System;

namespace API.HR.Models {
    public class LeaveBase : BaseEntity {
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
    }
}
