using CommunicationLibrary.Core.Logic;
using CommunicationLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.UI.Core.Bufor {
    public class Bufor<T> where T : BaseEntity {
        public List<T> DisplayBufor { get; set; }
        public TransactionBufor<T> TransactionBufor { get; set; }

        public Bufor(BaseRequestHandler<T> handler) {
            DisplayBufor = new List<T>();
            TransactionBufor = new TransactionBufor<T>(handler);
        }
    }
}
