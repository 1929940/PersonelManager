using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Resx;
using CommunicationLibrary.HR.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunicationLibrary.HR.Requests {
    public class LocationsRequestHandler : BaseRequestHandler<Location> {

        public LocationsRequestHandler() {
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
