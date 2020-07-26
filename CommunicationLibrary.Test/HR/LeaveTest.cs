using CommunicationLibrary.HR.Comparers;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using CommunicationLibrary.Test.Core;
using System;

namespace CommunicationLibrary.Test.HR {
    public class LeaveTest : BaseTest<Leave> {

        public LeaveTest() {
            _requestHandler = new LeavesRequestHandler();
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
