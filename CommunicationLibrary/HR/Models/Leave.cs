using CommunicationLibrary.Core.Models;
using System;

namespace CommunicationLibrary.HR.Models {
    public class Leave : BaseEntity {
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        public EmployeeSimplified Employee { get; set; }
    }
}
