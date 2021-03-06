﻿namespace CommunicationAndCommonsLibrary.Core.Models {
    public class AddressEntity : BaseEntity{
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}
