using API.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.HR.Models {
    public class Foreman : BaseEntity {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Mail { get; set; }


        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}
