﻿using HR.LeaveManagement.Application.DTO.Common;

namespace HR.LeaveManagement.Application.DTO.LeaveRequest {
    public class LeaveRequestDto : BaseDto {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDto? LeaveType { get; set; }
        public int LeavetypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string? RequestedComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Canceled { get; set; }
    }
}
