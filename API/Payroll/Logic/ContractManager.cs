using API.Core.DBContext;
using API.Core.Logic;
using API.HR.Logic;
using API.Payroll.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq;

namespace API.Payroll.Logic {
    public class ContractManager : BaseEntityManager {
        public static ContractDTO CreateDTO(Contract contract) {
            ContractDTO dto = new ContractDTO() {
                Employee = EmployeeManager.CreateSimplifiedDTO(contract.Employee),
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
                Advances = contract.Advances,
                ValueNetto = decimal.Round(contract.Value - (contract.Value * contract.TaxPercent / 100), 2)
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
            contract.EmployeeId = dto.Employee.Id;
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

        public static string GenerateContractNumber(Contract contract, Context context) {
            string datePart = contract.ValidFrom.ToString("MM/yyyy", CultureInfo.InvariantCulture);
            string searchPattern = string.Format($"%/{datePart}");

            var query = from e in context.Contracts
                        where EF.Functions.Like(e.Number, searchPattern)
                        select int.Parse(e.Number.Substring(0, e.Number.IndexOf('/')));

            int highest = 1;

            var numbers = query.ToList();

            if (numbers.Count() > 0)
                highest = numbers.Max() + 1;

            return string.Format($"{highest}/{datePart}");
        }
    }
}
