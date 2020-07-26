using CommunicationLibrary.HR.Comparers;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using CommunicationLibrary.Test.Core;

namespace CommunicationLibrary.Test.HR {
    //TODO: Change RequestHandler names to singular form, make sure everything is singular besides controller
    public class ForemanTest : BaseTest<Foreman> {

        public ForemanTest() {
            _requestHandler = new ForemanRequestHandler();
            _comparer = new ForemanComparer();

            _baseRow = new Foreman() {
                LocationId =  1,
                FirstName = "FirstNameForeman",
                LastName = "LastNameForeman",
                Mail = "Foreman@mail.co",
                PhoneNo = "000-000-000"
            };

            _updatedRow = new Foreman() {
                LocationId = 1,
                FirstName = "FIRSTNAMEFOREMAN",
                LastName = "LASTNAMEFOREMAN",
                Mail = "Foreman@mail.uk",
                PhoneNo = "001-001-001"
            };

        }

    }
}
