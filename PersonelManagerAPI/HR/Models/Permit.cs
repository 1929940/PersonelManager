using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.HR.Models {
    public class Permit : PersonelDocumentEntity {
        //TODO: LOCATION

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}
