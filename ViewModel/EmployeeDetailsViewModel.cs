using XBCAD7319_HR_App_Test1.Models;

namespace XBCAD7319_HR_App_Test1.ViewModel
{
    public class EmployeeDetailsViewModel
    {
        public Employee Employee { get; set; }
        public JobDetails JobDetails { get; set; }
        public List<AttendanceRecord> AttendanceRecords { get; set; }
        public Payroll Payroll { get; set; }
        public List<Review> Reviews { get; set; }
    }
}