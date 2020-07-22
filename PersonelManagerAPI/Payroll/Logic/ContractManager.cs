using API.Core.Logic;
using API.HR.Logic;
using API.Payroll.Models;
using System.Collections.Generic;
using System.Linq;

namespace API.Payroll.Logic {
    public class ContractManager : BaseEntityManager {
        public static ContractDTO CreateDTO(Contract contract) {
            ContractDTO dto = new ContractDTO() {
                EmployeeSimplified = EmployeeManager.CreateSimplifiedDTO(contract.Employee),
                Title = contract.Title,
                Number = contract.Number,
                ValidFrom = contract.ValidFrom,
                ValidTo = contract.ValidTo,
                ContractSubject = contract.ContractSubject,
                Value = contract.Value,
                HourlySalary = contract.HourlySalary,
                TaxPercent = contract.TaxPercent,
                IsRealized = contract.IsRealized,
                Payment = contract.Payment,
                Advances = contract.Advances
            };
            CopyTags(contract, ref dto);

            return dto;
        }

        public static ContractSimplifiedDTO CreateSimplifiedDTO(Contract contract) {
            return new ContractSimplifiedDTO() {
                Id = contract.Id,
                Title = contract.Title,
                Number = contract.Number,
                ValidFrom = contract.ValidFrom,
                ValidTo = contract.ValidTo,
                IsRealized = contract.IsRealized
            };
        }

        public static void UpdateWithDTO(ContractDTO dto, ref Contract contract) {
            contract.EmployeeId = dto.EmployeeSimplified.Id;
            contract.Title = dto.Title;
            contract.Number = dto.Number;
            contract.ValidFrom = dto.ValidFrom;
            contract.ValidTo = dto.ValidTo;
            contract.ContractSubject = dto.ContractSubject;
            contract.Value = dto.Value;
            contract.HourlySalary = dto.HourlySalary;
            contract.TaxPercent = dto.TaxPercent;
            contract.IsRealized = dto.IsRealized;

            CopyTags(dto, ref contract);
        }
    }
}
