using API.HR.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Payroll.Models {
    public class Contract : PersonelDocumentEntity {
        public decimal Value { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TaxPercent { get; set; }
        public string ContractSubject { get; set; }

        [ForeignKey("Payment")]
        public int? PaymentId { get; set; }
        public Payment Payment { get; set; }

        public bool IsRealized { get; set; }

        public virtual ICollection<Advances> Advances { get; set; }
    }
}
