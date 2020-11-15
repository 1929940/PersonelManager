using API.HR.Models;

namespace API.Payroll.Models {
    public class PaymentDTO : PaymentBase {
        public ContractSimplifiedDTO Contract { get; set; }
        public EmployeeSimplifiedDTO Employee { get; set; }
        public bool IsRealized { get; set; }
    }
}
