﻿using CommunicationLibrary.Core.Models;
using System;

namespace CommunicationLibrary.Payroll.Models {
    public class Advance : BaseEntity{
        public ContractSimplified Contract { get; set; }
        public int WorkedHours { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaidOn { get; set; }
    }
}