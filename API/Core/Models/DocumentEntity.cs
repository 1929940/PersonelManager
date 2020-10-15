using System;

namespace API.Core.Models {
    public abstract class DocumentEntity : BaseEntity {
        public string Title { get; set; }
        //TODO:
        //CAN I CONVERT THIS TO SMALLDATETIME - stores up to minutes or perhaps timestamp?
        //GENERALY YOU WANT TO READ ABOUT TYPES IN YOUR BOOK AND USE THE KNOWLEDGE
        //[Column(TypeName = "Money")]
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string IssuedBy { get; set; }
        public string Number { get; set; }
    }
}
