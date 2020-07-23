using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Business.Helpers {
    public class AppSecrets {
        public string EmailPassword { get; set; }
        public string EmailLogin { get; set; }
        public string EmailAddress { get; set; }
        public string AuthSecret { get; set; }
        public string Issuer { get; set; }
    }
}
