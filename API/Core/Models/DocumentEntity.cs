using System;

namespace API.Core.Models {
    public abstract class DocumentEntity : BaseEntity {
        public string Title { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string IssuedBy { get; set; }
        public string Number { get; set; }
    }
}
