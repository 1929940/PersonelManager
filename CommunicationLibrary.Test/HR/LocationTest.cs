using CommunicationLibrary.HR.Comparers;
using CommunicationLibrary.HR.Models;
using CommunicationLibrary.HR.Requests;
using CommunicationLibrary.Test.Core;

namespace CommunicationLibrary.Test.HR {
    public class LocationTest : BaseTest<Location> {

        public LocationTest() {
            _requestHandler = new LocationRequestHandler();
            _comparer = new LocationComparer();

            _baseRow = new Location() {
                Name = "TestLocation",
                Country = "TestCountry",
                Region = "TestRegion",
                City = "TestCity",
                Zip = "00-000",
                Street = "TestStreet",
                Number = "23"
            };

            _updatedRow = new Location() {
                Name = "TESTLOCATION",
                Country = "TESTCOUNTRY",
                Region = "TESTREGION",
                City = "TESTCITY",
                Zip = "00-001",
                Street = "TESTSTREET",
                Number = "20"
            };
        }
    }
}
