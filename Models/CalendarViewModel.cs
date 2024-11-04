namespace XBCAD7319_HR_App_Test1.Models
{
    //Calender Test
    public class CalendarViewModel
    {
        public List<WeekViewModel> Weeks { get; set; }
    }

    public class WeekViewModel
    {
        public List<DayViewModel> Days { get; set; }
    }

    public class DayViewModel
    {
        public DateTime Date { get; set; }
        public string Status { get; set; } // For example: Present, Absent, On Leave, etc.
    }
}