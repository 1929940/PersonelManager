using API.Core.Logic;
using API.Payroll.Models;

namespace API.Payroll.Logic {
    public class PaymentManager : BaseEntityManager {

        public static PaymentDTO CreateDTO(Payment payment) {
            PaymentDTO dto = new PaymentDTO() {
                ContractSimplified = ContractManager.CreateSimplifiedDTO(payment.Contract),
                Id = payment.Id,
                GrossAmount = payment.GrossAmount,
                NetAmount = payment.NetAmount,
                PaidOn = payment.PaidOn
            };

            CopyTags(payment, ref dto);
            return dto;
        }

        public static void UpdateWithDTO(PaymentDTO dto, ref Payment payment) {
            payment.NetAmount = dto.NetAmount;
            payment.GrossAmount = dto.GrossAmount;
            payment.PaidOn = dto.PaidOn;
            payment.ContractId = dto.ContractSimplified.Id;

            CopyTags(dto, ref payment);
        }
    }
}
