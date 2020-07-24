namespace API.HR.Models {
    public class EmployeeDTO : EmployeeBase {
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string PhoneNo { get; set; }

        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public int? ForemanId { get; set; }
        public string ForemanFullName { get; set; }
        public int? LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
