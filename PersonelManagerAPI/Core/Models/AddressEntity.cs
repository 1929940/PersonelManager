namespace API.Core.Models {
    public abstract class AddressEntity : BaseEntity {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}