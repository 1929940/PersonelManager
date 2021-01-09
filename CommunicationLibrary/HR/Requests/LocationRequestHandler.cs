using CommunicationAndCommonsLibrary.Core.Requests;
using CommunicationAndCommonsLibrary.Core.Resx;
using CommunicationAndCommonsLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.HR.Requests {
    public class LocationRequestHandler : BaseRequestHandler<Location> {

        public LocationRequestHandler() {
            _controllerName = "Locations";
        }

        public IEnumerable<Location> GetEmployeeLocations(int id) {
            return base.Get(id, RouteVerbs.GET_EMPLOYEE_LOCATIONS);
        }

        public async Task<IEnumerable<Location>> GetEmployeeLocationsAsync(int id) {
            return await base.GetAsync(id, RouteVerbs.GET_EMPLOYEE_LOCATIONS);
        }
    }
}
