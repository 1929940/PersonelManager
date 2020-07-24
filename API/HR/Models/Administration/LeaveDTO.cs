namespace API.HR.Models {
    public class LeaveDTO : LeaveBase {
        public EmployeeSimplifiedDTO Employee { get; set; }
    }
}
