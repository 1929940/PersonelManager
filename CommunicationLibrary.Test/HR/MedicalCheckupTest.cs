using CommunicationLibrary.HR.Comparers;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using CommunicationLibrary.Test.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationLibrary.Test.HR {
    public class MedicalCheckupTest : BaseTest<PersonelDocument> {
        public MedicalCheckupTest() {
            _requestHandler = new MedicalCheckupRequestHandler();
            _comparer = new PersonelDocumentComperer();

            _baseRow = new PersonelDocument() {
                Employee = new EmployeeSimplified() { Id = 1 },
                Title = "Title",
                IssuedBy = "IssueBy",
                Number = "00/01/2020",
                ValidFrom = DateTime.Now.AddYears(-2),
                ValidTo = DateTime.Now
            };

            _updatedRow = new PersonelDocument() {
                Employee = new EmployeeSimplified() { Id = 1 },
                Title = "TITLE",
                IssuedBy = "ISSUEDBY",
                Number = "01/01/2020",
                ValidFrom = DateTime.Now.AddYears(-2).AddDays(10),
                ValidTo = DateTime.Now.AddDays(10)
            };
        }

        [Fact]
        public void GetEmployeeCertificates_ShouldPass() {
            var employeeMedicalcheckups = (_requestHandler as MedicalCheckupRequestHandler).GetEmployeeMedicalCheckups(1);
            var medicalCheckups = _requestHandler.Get();

            Assert.Equal(employeeMedicalcheckups.Count(), medicalCheckups.Count(x => x.Employee.Id == 1));
        }

        [Fact]
        public async Task GetEmployeeCertificatesAsync_ShouldPass() {
            var employeeMedicalcheckups = await (_requestHandler as MedicalCheckupRequestHandler).GetEmployeeMedicalCheckupsAsync(1);
            var medicalCheckups = _requestHandler.Get();

            Assert.Equal(employeeMedicalcheckups.Count(), medicalCheckups.Count(x => x.Employee.Id == 1));
        }
    }
}
