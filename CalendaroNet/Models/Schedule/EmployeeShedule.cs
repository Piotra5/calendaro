using System;
using System.ComponentModel.DataAnnotations;
using CalendaroNet.Models.Employees;

namespace CalendaroNet.Models.Schedule
{
    public class EmployeeSchedule
    {
        public Guid Id { get; set; }
        
        public virtual Employee Employee {get; set;}

        [Required]
        public Guid EmployeeId { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset FinishTime { get; set; }

        public String Role { get; set; }
        public bool? Present { get; set; }

        public String AbsenceReason {get; set;}

    }
}