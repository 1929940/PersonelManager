using System;
using System.Collections.Generic;
using System.Text;

namespace CommunicationAndCommonsLibrary.Payroll.Models {
    public class ContractSimplified {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Number { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool IsRealized { get; set; }
    }
}
