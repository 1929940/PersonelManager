
using API.HR.Models;

namespace API.Payroll.Models {
    public class AdvanceDTO : AdvanceBase {
        public ContractSimplifiedDTO Contract { get; set; }
        public EmployeeSimplifiedDTO Employee { get; set; }
    }
}
