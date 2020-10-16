using CommunicationLibrary.Core.Models;

namespace CommunicationLibrary.HR.Models {
    public class PersonelDocument : DocumentEntity  {
        public EmployeeSimplified Employee { get; set; }

        public PersonelDocument() {
            Employee = new EmployeeSimplified();
        }
    }
}
