using API.Core.Models;
using API.HR.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Payroll.Models {
    public class Contract : ContractBase {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual ICollection<Advance> Advances { get; set; }
    }
}
