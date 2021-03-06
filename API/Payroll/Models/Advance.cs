﻿using System.ComponentModel.DataAnnotations.Schema;

namespace API.Payroll.Models {
    public class Advance : AdvanceBase {
        [ForeignKey("Contract")]
        public int ContractId { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual Contract Contract { get; set; }
    }
}
