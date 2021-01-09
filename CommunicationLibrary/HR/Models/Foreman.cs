using CommunicationAndCommonsLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationAndCommonsLibrary.HR.Models {
    public class Foreman : BaseEntity{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Mail { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
