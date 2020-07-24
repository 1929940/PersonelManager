using System;

namespace API.Payroll.Models {
    public class ContractSimplifiedDTO {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool IsRealized { get; set; }
    }
}
