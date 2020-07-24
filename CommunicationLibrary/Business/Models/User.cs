﻿using CommunicationLibrary.Core.Models;

namespace CommunicationLibrary.Business.Models {
    public class User : BaseEntity {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
    }
}
