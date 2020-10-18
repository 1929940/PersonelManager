using CommunicationLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desktop.UI.Core.Helpers.Enums;

namespace Desktop.UI.Core.Bufor {
    public class BuforObject<T> where T : BaseEntity {
        public Status Status { get; set; }
        public T Value { get; set; }
    }
}
