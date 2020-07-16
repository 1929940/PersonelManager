using API.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.HR.Models {
    public class Location : AddressEntity {
        public string Name { get; set; }
    }
}
