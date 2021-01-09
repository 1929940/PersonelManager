using CommunicationAndCommonsLibrary.HR.Comparers;
using CommunicationAndCommonsLibrary.HR.Models;
using CommunicationAndCommonsLibrary.HR.Requests;
using CommunicationAndCommonsLibrary.Test.Core;
using System;

namespace CommunicationAndCommonsLibrary.Test.HR {
    public class LeaveTest : BaseTest<Leave> {

        public LeaveTest() {
            _requestHandler = new LeaveRequestHandler();
            _comparer = new LeaveComparer();

            _baseRow = new Leave() {
                Employee = new EmployeeSimplified() {  Id = 1 },
                From = DateTime.Now.AddDays(-10),
                To = DateTime.Now,
                Type = "Vacation",
                Comment = "Comment"
            };

            _updatedRow = new Leave() {
                Employee = new EmployeeSimplified() { Id = 1 },
                From = DateTime.Now.AddDays(-20),
                To = DateTime.Now,
                Type = "Vanished",
                Comment = "COMMENT"
            };

        }
    }
}
