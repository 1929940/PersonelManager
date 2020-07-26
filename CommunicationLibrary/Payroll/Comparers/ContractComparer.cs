﻿using CommunicationLibrary.Payroll.Models;
using System.Collections.Generic;

namespace CommunicationLibrary.Payroll.Comparers {
    public class ContractComparer : IEqualityComparer<Contract> {
        public bool Equals(Contract x, Contract y) =>
            x.Employee?.Id == y.Employee?.Id &&
            x.Title == y.Title &&
            x.Number == y.Number &&
            x.ContractSubject == y.ContractSubject &&
            x.ValidFrom == y.ValidFrom &&
            x.ValidTo == y.ValidTo &&
            x.HourlySalary == y.HourlySalary &&
            x.Value == y.Value &&
            x.TaxPercent == y.TaxPercent &&
            x.IsRealized == y.IsRealized;


        public int GetHashCode(Contract obj) => obj.GetHashCode();
    }
}
