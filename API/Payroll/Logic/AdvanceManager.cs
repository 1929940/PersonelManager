using API.Core.Logic;
using API.HR.Logic;
using API.Payroll.Models;

namespace API.Payroll.Logic {
    public class AdvanceManager : BaseEntityManager {
        public static AdvanceDTO CreateDTO(Advance advance) {
            AdvanceDTO dto = new AdvanceDTO() {
                Contract = ContractManager.CreateSimplifiedDTO(advance.Contract),
                Employee = EmployeeManager.CreateSimplifiedDTO(advance.Contract),
                Id = advance.Id,
                Amount = advance.Amount,
                PaidOn = advance.PaidOn,
                WorkedHours = advance.WorkedHours
            };

            CopyTags(advance, ref dto);
            return dto;
        }

        public static void UpdateWithDTO(AdvanceDTO dto, ref Advance advance) {
            advance.Amount = dto.Amount;
            advance.PaidOn = dto.PaidOn;
            advance.WorkedHours = dto.WorkedHours;
            advance.ContractId = dto.Contract.Id;

            CopyTags(dto, ref advance);
        }
    }
}
