using API.Business.Models;
using API.HR.Logic;
using API.Payroll.Logic;
using API.Payroll.Models;
using System;
using System.Linq;

namespace API.Business.Logic {
    public class DashboardManager {
        public static DashboardDTO CreateDashboardDTO(Contract contract, ConfigurationPage configuration) {
            var employee = contract.Employee;
            var history = contract.Employee.History.Last();

            var lastCertificate = PersonelDocumentManager.GetOldestDoc(employee.Certificates);
            var lastMedical = PersonelDocumentManager.GetOldestDoc(employee.MedicalCheckups);
            var lastSafety = PersonelDocumentManager.GetOldestDoc(employee.SafetyTrainings);

            var latestLeave = LeaveManager.GetClosestLeave(employee.Leaves);

            var dto = new DashboardDTO() {
                EmployeeFullName = string.Format($"{history.LastName} {employee.FirstName}"),
                Profession = history.Profession,
                ContractNumber = contract.Number,
                ContractFrom = contract.ValidFrom,
                ContractTo = contract.ValidTo,
                ForemanName = string.Format($"{history.Foreman.LastName} {history.Foreman.FirstName}"),
                LocalizationName = history.Location.Name,
                ContractAdvancesValue = ContractManager.GetAdvancesTotalValue(contract),
                ContractPaymentValue = ContractManager.GetPaymentValue(contract),
                ContractTaxValue = ContractManager.GetTaxValue(contract),
                CertificateExpirationDate = lastCertificate.ValidTo,
                CertificateStatus = GetWarning(lastCertificate.ValidTo, configuration.WarningBeforeCertificateExpires),
                MedicalCheckupExpirationDate = lastMedical.ValidTo,
                MedicalCheckupStatus = GetWarning(lastMedical.ValidTo, configuration.WarningBeforeMedicalCheckupExpires),
                SafetyTrainingExpirationDate = lastSafety.ValidTo,
                SafetyTrainingStatus = GetWarning(lastSafety.ValidTo, configuration.WarningBeforeSafetyTrainingExpires),
                LeavePeriod = string.Format($"{latestLeave.From.ToString("DD-mm-YYYY")} - {latestLeave.ActualTo?.ToString("DD-mm-YYYY")}"),
                TypeOfLeave = latestLeave.Type,
                LeaveStatus = GetLeaveWarning(latestLeave.From, latestLeave.ActualTo, configuration.MaximumLeaveTimeInDays)
            };
            return dto;
        }

        private static ExpirationWarnings GetWarning(DateTime? date, int firstWarningInDays) {
            if (date == null)
                return ExpirationWarnings.NoData;
            if (date <= DateTime.Today)
                return ExpirationWarnings.Expired;
            if (date <= DateTime.Today.AddDays(firstWarningInDays))
                return ExpirationWarnings.Expiring;
            return ExpirationWarnings.Ok;
        }

        private static ExpirationWarnings GetLeaveWarning(DateTime from, DateTime? actualTo, int maxDays) {
            if (from < DateTime.Today.AddDays(maxDays) && (actualTo == null || actualTo > DateTime.Today))
                return ExpirationWarnings.Expired;

            return ExpirationWarnings.Ok;
        }

    }
}
