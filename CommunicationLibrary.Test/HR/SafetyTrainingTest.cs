using CommunicationAndCommonsLibrary.HR.Comparers;
using CommunicationAndCommonsLibrary.HR.Models;
using CommunicationAndCommonsLibrary.HR.Requests;
using CommunicationAndCommonsLibrary.Test.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationAndCommonsLibrary.Test.HR {
    public class SafetyTrainingTest : BaseTest<PersonelDocument> {
        public SafetyTrainingTest() {
            _requestHandler = new SafetyTrainingRequestHandler();
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
            var employeeSafetyTrainings = (_requestHandler as SafetyTrainingRequestHandler).GetEmployeeSafetyTrainings(1);
            var safetyTrainings = _requestHandler.Get();

            Assert.Equal(employeeSafetyTrainings.Count(), safetyTrainings.Count(x => x.Employee.Id == 1));
        }

        [Fact]
        public async Task GetEmployeeCertificatesAsync_ShouldPass() {
            var employeeSafetyTrainings = await (_requestHandler as SafetyTrainingRequestHandler).GetEmployeeSafetyTrainingsAsync(1);
            var safetyTrainings = _requestHandler.Get();

            Assert.Equal(employeeSafetyTrainings.Count(), safetyTrainings.Count(x => x.Employee.Id == 1));
        }
    }
}