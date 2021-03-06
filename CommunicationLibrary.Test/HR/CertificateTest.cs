﻿using CommunicationAndCommonsLibrary.HR.Comparers;
using CommunicationAndCommonsLibrary.HR.Models;
using CommunicationAndCommonsLibrary.HR.Requests;
using CommunicationAndCommonsLibrary.Test.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationAndCommonsLibrary.Test.HR {
    public class CertificateTest : BaseTest<PersonelDocument> {
        public CertificateTest() {
            _requestHandler = new CertificateRequestHandler();
            _comparer = new PersonelDocumentComperer();

            _baseRow = new PersonelDocument() {
                Employee = new EmployeeSimplified() { Id = 1 },
                Title = "Certyfikat spawalniczy",
                IssuedBy = "IssuedByTest",
                Number = "00/01/2020",
                ValidFrom = DateTime.Now.AddYears(-2),
                ValidTo = DateTime.Now
            };

            _updatedRow = new PersonelDocument() {
                Employee = new EmployeeSimplified() { Id = 1 },
                Title = "CERTYFIKAT MONTERSKI",
                IssuedBy = "IssuedByTest",
                Number = "01/01/2020",
                ValidFrom = DateTime.Now.AddYears(-2).AddDays(10),
                ValidTo = DateTime.Now.AddDays(10)
            };
        }

        [Fact]
        public void GetEmployeeCertificates_ShouldPass() {
            var employeeCertificates = (_requestHandler as CertificateRequestHandler).GetEmployeeCertificates(1);
            var certificates = _requestHandler.Get();

            Assert.Equal(employeeCertificates.Count(), certificates.Count(x => x.Employee.Id == 1));
        }

        [Fact]
        public async Task GetEmployeeCertificatesAsync_ShouldPass() {
            var employeeCertificates = await (_requestHandler as CertificateRequestHandler).GetEmployeeCertificatesAsync(1);
            var certificates = _requestHandler.Get();

            Assert.Equal(employeeCertificates.Count(), certificates.Count(x => x.Employee.Id == 1));
        }
    }
}
