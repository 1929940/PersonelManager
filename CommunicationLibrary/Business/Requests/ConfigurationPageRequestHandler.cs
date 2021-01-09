using CommunicationAndCommonsLibrary.Business.Models;
using CommunicationAndCommonsLibrary.Core.Requests;
using System;
using System.Threading.Tasks;

namespace CommunicationAndCommonsLibrary.Business.Requests {
    public class ConfigurationPageRequestHandler : BaseRequestHandler<ConfigurationPage> {

        public ConfigurationPageRequestHandler() {
            _controllerName = "ConfigurationPage";

        }

        public new ConfigurationPage Get() {
            return base.Get(1);
        }

        public async new Task<ConfigurationPage> GetAsync() {
            return await base.GetAsync(1);
        }

        [Obsolete]
        public new ConfigurationPage Create(ConfigurationPage input) => throw new NotImplementedException();

        [Obsolete]
        public new Task<ConfigurationPage> CreateAsync(ConfigurationPage input) => throw new NotImplementedException();


        [Obsolete]
        public new void Delete(int id) => throw new NotImplementedException();

        [Obsolete]
        public new Task DeleteAsync(int id) => throw new NotImplementedException();



    }
}
