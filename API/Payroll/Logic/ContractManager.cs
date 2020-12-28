using API.Business.Models;
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
            decimal nettoValue = decimal.Round(contract.TotalValue - (contract.TotalValue * contract.TaxPercent / 100), 2);
            decimal taxValue = decimal.Round(contract.TotalValue - nettoValue);
            decimal advancesTotalValue = contract.Advances?.Sum(x => x.Amount) ?? 0;
            decimal paymentValue = contract.TotalValue - taxValue - advancesTotalValue;

            ContractDTO dto = new ContractDTO() {
                Employee = EmployeeManager.CreateSimplifiedDTO(contract.Employee),
                Title = contract.Title,
                Number = contract.Number,
                ValidFrom = contract.ValidFrom,
                ValidTo = contract.ValidTo,
                ContractSubject = contract.ContractSubject,
                TotalValue = contract.TotalValue,
                HourlySalary = contract.HourlySalary,
                TaxPercent = contract.TaxPercent,
                IsRealized = contract.IsRealized,
                PaidOn = contract.PaidOn,
                NettoValue = nettoValue,
                TaxValue = taxValue,
                AdvancesTotalValue = advancesTotalValue,
                Paymentvalue = paymentValue
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

        public static ContractHeader CreateContractHeader(Contract contract) {
            return new ContractHeader() {
                Id = contract.Id,
                DisplayValue = string.Format($"{contract.Employee.History.LastOrDefault()?.LastName} {contract.Employee.FirstName} {contract.Number}")
            };
        }

        public static ContractAdvanceData CreateContractAdvanceData(Contract contract, ConfigurationPage configurationPage) {
            decimal advancesTotalValue = contract.Advances.Sum(x => x.Amount);
            decimal modifier = (decimal)configurationPage.PercentOfAdvancesAllowed / 100;

            decimal limit = decimal.Round(modifier * contract.TotalValue, 2);
            return new ContractAdvanceData() {
                Modifier = modifier,
                AdvancesSum = advancesTotalValue,
                ContractValue = contract.TotalValue,
                AdvancesLimit = limit,
                Wage = contract.HourlySalary
            };
        }

        public static void UpdateWithDTO(ContractDTO dto, ref Contract contract) {
            contract.EmployeeId = dto.Employee.Id;
            contract.Title = dto.Title;
            contract.Number = dto.Number;
            contract.ValidFrom = dto.ValidFrom;
            contract.ValidTo = dto.ValidTo;
            contract.ContractSubject = dto.ContractSubject;
            contract.TotalValue = dto.TotalValue;
            contract.HourlySalary = dto.HourlySalary;
            contract.TaxPercent = dto.TaxPercent;
            contract.PaidOn = dto.PaidOn;
            contract.IsRealized = dto.PaidOn != null;

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
