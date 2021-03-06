﻿namespace API.Core.Models {
    public abstract class AddressEntity : BaseEntity {
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        //TODO VARCHAR 6?
        public string Zip { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
    }
}