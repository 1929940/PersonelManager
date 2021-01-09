using CommunicationAndCommonsLibrary.Core.Models;

namespace CommunicationAndCommonsLibrary.HR.Models {
    public class PersonelDocument : DocumentEntity  {
        public EmployeeSimplified Employee { get; set; }

        public PersonelDocument() {
            Employee = new EmployeeSimplified();
        }
    }
}
