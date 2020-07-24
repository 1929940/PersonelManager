using API.Core.Models;

namespace API.HR.Models {
    public class EmployeeHistoryBase : AddressEntity {
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string PhoneNo { get; set; }
    }
}
