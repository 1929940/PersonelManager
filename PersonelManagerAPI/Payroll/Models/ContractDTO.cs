﻿using API.HR.Models;
using System.Collections.Generic;

namespace API.Payroll.Models {
    public class ContractDTO : ContractBase {
        public EmployeeSimplifiedDTO EmployeeSimplified {get; set;}
        public Payment Payment { get; set; }
        public IEnumerable<Advance> Advances { get; set; }
    }
}