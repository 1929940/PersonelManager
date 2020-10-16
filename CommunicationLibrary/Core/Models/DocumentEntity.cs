using System;

namespace CommunicationLibrary.Core.Models {
    public class DocumentEntity : BaseEntity{
        public string Title { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string IssuedBy { get; set; }
        public string Number { get; set; }

        public DocumentEntity() {
            ValidFrom = DateTime.Today;
            ValidTo = DateTime.Today.AddYears(2);
        }
    }
}
