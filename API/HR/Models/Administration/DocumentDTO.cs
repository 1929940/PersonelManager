using API.Core.Models;

namespace API.HR.Models {
    public class DocumentDTO : DocumentEntity {
        public EmployeeSimplifiedDTO Employee { get; set; }
    }
}
