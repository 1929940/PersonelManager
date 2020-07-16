﻿using System;

namespace API.Core.Models {
    public abstract class BaseEntity {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}
