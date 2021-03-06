﻿using CommunicationAndCommonsLibrary.Core.Models;
using System;

namespace CommunicationAndCommonsLibrary.HR.Models {
    public class Leave : BaseEntity {
        public DateTime From { get; set; } = DateTime.Now;
        public DateTime? To { get; set; } = DateTime.Now;
        public string Type { get; set; }
        public string Comment { get; set; }
        public EmployeeSimplified Employee { get; set; }
    }
}
