﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Models
{
    public class LeaveRequestVM
    {
        public int Id { get; set; }
        
        public EmployeeVM RequestiongEmployee { get; set; }
        [Display(Name ="Emplyee Name")]
        public string RequestingEmployeeId { get; set; }
        [Display(Name = "Start Date")]
        [Required]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        public DateTime EndDate { get; set; }
        
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public EmployeeVM ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
        [Display(Name = "Emplyee Comments")]
        [MaxLength(300)]
        public string RequestComments { get; set; }

    }

    public class AdminLeaveRequestViewVM
    {
        [Display(Name = "Total Number Of Requests")]
        public int TotalRequests { get; set; } 
        [Display(Name ="Approved Requests")]
        public int ApprovedRequests { get; set; }
        [Display(Name ="Pending Requests")]
        public int PendingRequests { get; set; }
        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }

    public class CreateLeaveRequestVM
    {
        [Display(Name = "Start Date")]
        [Required]
        public string StartDate { get; set; }
        [Display(Name = "End Date")]
        [Required]
        public string EndDate { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
        [Display(Name ="Leave Type")]
        public int LeaveTypeId { get; set; }
        [Display(Name = "Emplyee Comments")]
        [MaxLength(300)]
        public string RequestComments { get; set; }
    }

    public class EmployeeLeaveRequestViewVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
