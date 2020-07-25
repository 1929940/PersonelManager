using CommunicationLibrary.Business.Requests;
using CommunicationLibrary.Core;
using CommunicationLibrary.Payroll.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CommunicationLibrary.Test.Payroll {
    public class AdvancesTest {
        private readonly AdvancesRequestHandler _requestHandler;
        public AdvancesTest() {
            Settings.Url = @"https://localhost:44345";
            _requestHandler = new AdvancesRequestHandler();

            var login = new UserRequestHandler().Login("Jan.Kowalski@PersonelManager.pl", "Macko");
            Settings.Token = login.Token;
        }

        [Fact]
        public void DownloadAllAdvances_ShouldPass() {
            var advances = _requestHandler.Get();
            Assert.NotEmpty(advances);
        }

    }
}
