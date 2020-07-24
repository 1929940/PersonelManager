using API.Core.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.HR.Models {
    public class Leave : LeaveBase {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
