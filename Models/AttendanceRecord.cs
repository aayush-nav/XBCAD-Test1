﻿namespace XBCAD7319_HR_App_Test1.Models
{
    // Github Testing
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan CheckIn { get; set; }
        public TimeSpan CheckOut { get; set; }
        public string Status { get; set; }
    }
}