using CommunicationAndCommonsLibrary.Core.Models;
using CommunicationAndCommonsLibrary.Core.Requests;
using System.Collections.Generic;

namespace CommunicationAndCommonsLibrary.Core.Bufor {
    public class Bufor<T> where T : BaseEntity {
        public List<T> DisplayBufor { get; set; }
        public TransactionBufor<T> TransactionBufor { get; set; }

        public Bufor(BaseRequestHandler<T> handler) {
            DisplayBufor = new List<T>();
            TransactionBufor = new TransactionBufor<T>(handler);
        }
    }
}
