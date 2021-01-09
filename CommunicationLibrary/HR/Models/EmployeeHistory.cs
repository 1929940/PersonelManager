using CommunicationAndCommonsLibrary.Core.Models;

namespace CommunicationAndCommonsLibrary.HR.Models {
    public class EmployeeHistory : AddressEntity {
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string PhoneNo { get; set; }
        public int EmployeeId { get; set; }
        public Location Location { get; set; }
        public Foreman Foreman { get; set; }
    }
}
