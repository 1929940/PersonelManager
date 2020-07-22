namespace API.HR.Models {
    public class EmployeeDTO : EmployeeBase {
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string PhoneNo { get; set; }

        public int? ForemanId { get; set; }
        public string ForemanFullName { get; set; }

        public int? LocationId { get; set; }
        public string LocationName { get; set; }

        public int? AddressId { get; set; }
        public string FullAddress { get; set; }
    }
}
