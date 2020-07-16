using API.Core.Models;
using API.HR.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Payroll.Models {
    public class Contract : PersonelDocumentEntity {
        public decimal Value { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal TaxPercent { get; set; }
        public string ContractSubject { get; set; }

        [ForeignKey("Salary")]
        public int SalaryId { get; set; }
        public Salary Salary { get; set; }

        public bool IsRealized { get; set; }

        public virtual ICollection<Advances> Advances { get; set; }
    }
}
